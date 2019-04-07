using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        async Task<int> Save()
        {
            await Task.Run(async ()=>
            {
                errdata = "";
                data = "";//dataを初期化していくっ！

                this.Dispatcher.Invoke(() =>
                {
                    this.IsEnabled = false;
                    prg.IsIndeterminate = true;
                    prg_label.Text = "保存中です...";
                });
                await Task.Delay(300);
                this.Dispatcher.Invoke(() =>
                {
                    //_scene_stackの論理ツリーのFrameWorkElementを一つずつin全て調べていく
                    foreach (var childs in LogicalTreeHelper.GetChildren(_scene_stack))
                    {
                        //さらにそのFrameWorkElementの中の論理ツリーを取得し一つずつin全て調べていく
                        foreach (var child in LogicalTreeHelper.GetChildren((DependencyObject)childs))
                        {
                            //labelのContentでタグを判断する
                            if (child is Label)
                            {
                                //Labelにキャスト
                                Label tags = child as Label;
                                if (tags != null)
                                {
                                    //タグ判定
                                    switch (tags.Content)
                                    {
                                        case "テキスト":
                                            //t
                                            s_text(childs as Canvas);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    a_method(errdata);
                    a_method(data);
                    prg.IsIndeterminate = false;
                    prg_label.Text = "";
                    this.IsEnabled = true;
                });
            });
            return 0;
        }
    }
}
