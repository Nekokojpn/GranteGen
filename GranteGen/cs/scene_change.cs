using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        void scene_change(string scenefilename)
        {
            a_error(scenefilename);
            var msg = MessageBox.Show("シーンを切り替える前に保存をしますか？", "", MessageBoxButton.YesNoCancel);
            if (msg == MessageBoxResult.Yes)
            {

            }
            else if (msg == MessageBoxResult.No)
            {
                //  scene_change1(scenefilename);
                //タイトルに設定します
                _selectedfile_label.Content = scenefilename;
                _currentscene = scenefilename;
                //ファイルチェック
                if(File.Exists(path+@"\scene\"+scenefilename+".sc"))
                {
                    _currentscenefullpath = path + @"\scene\" + scenefilename + ".sc";
                    scene_change_init();
                    data = read(@"\scene\" + scenefilename + ".sc");
                    if(data != "")
                    {
                        
                    }
                    else
                    {
                        Navigate_Error("選択されたシーンファイルを読み込めませんでした。");
                    }
                }
            }
            else if (msg == MessageBoxResult.Cancel)
            {

            }
        }
        void scene_change_init()
        {
            _scene_stack.Children.Clear();
            data = "";
        }
    }
}
