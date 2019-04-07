using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// クラスを作成したりします。イニシャライズ。
        /// </summary>
        private void Initilize()
        {
            #region Pageのイニシャライズ。
            ne = new pages.NavigateExplain();
            nt = new pages.NavigateText();
            ns = new pages.NewScene();
            ip = new pages.insertionPage();
            np = new pages.NavigatePreviewPic();
            #endregion
            #region pages.NewSceneの処理。
            //新規作成ボタンクリック時
            ns.createb.Click += (s, e) =>
            {
                int w = write("scenename=" + ns.scenetext.Text, @"scene\" + ns.scenetext.Text + ".sc");
                if (w != 0) Navigate_Error("新規シーンの作成に失敗しました");
                else
                {
                    navigate_Explain("成功", ns.scenetext.Text + "-シーンファイルを作成することができました。");
                    Button _scenebutton = new Button();
                    _scenebutton.Content = ns.scenetext.Text;
                    _scenebutton.Click += (ss, ee) =>
                    {
                        string scene_name = ((Button)ss).Content.ToString();
                        if (scene_name != _currentscene)
                        {
                            _currentsceneselected = true;
                            scene_change(scene_name);
                        }
                    };
                    _Scenario_stackpanel.Children.Add(_scenebutton);
                }

            };
            #endregion
            ip.cancel.Click += (s1, e1) =>
              {
                  navigate_null();
                  isInsertionMode = false;
              };
        }
    }
}
