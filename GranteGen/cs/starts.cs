using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GranteGen
{
    public partial class MainWindow : Window
    {

        /// <summary>
        /// logoを表示します。
        /// </summary>
        void showLogo()
        {
            logo lg = new logo();
            lg.Topmost = true;
            lg.Show();
        }
        /// <summary>
        /// menuを表示します。
        /// </summary>
        void showMenu()
        {
            menu mn = new menu();
            mn.Topmost = true;
            mn.Closing += (senn, eee) =>
            {
                //プロジェクトのパスまたフォルダ名を設定します.
                if (mn.prjpath != "")
                {
                    path = mn.prjpath;
                    title = mn.title;
                }
                else
                {
                    this.Close();
                }
            };
            mn.Closed += (sen, ee) =>
            {
                //閉じられたら
                if(path != ""&&title!="")
                {
                    prj_loaded();
                    //pathが空でないときはロードが成功と判断する
                    navigate_Explain(title, title + " がロードされました。開発を開始できます。\r\n"+path);
                }
            };
            mn.Show();
        }
    }
}
