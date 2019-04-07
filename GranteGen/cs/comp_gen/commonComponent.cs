using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GranteGen
{  
    public partial class MainWindow:Window
    {
        //コンポーネント削除とかのボタン、共通のGUIを提供するスペースです。

        internal Button helpButton(string title, string tex)
        {
            Button btn = new Button();//モデルを作っておいてコピーできるかな？
            btn.Style = FindResource("CaptionButtonStyleKey") as Style;
            btn.Content = "s";
            btn.FontSize = 20;
            btn.Margin = new Thickness(560, 0, 0, 0);
            btn.Click += (send, ev) =>
              {
                  Helper hl = new Helper();//->いちいちnewするのは良くないかもしれない
                  hl.Topmost = true;
                  hl.titles = title;
                  hl.helptext = tex;
                  hl.Show();
              };
            return btn;
        }
        /// <summary>
        /// 削除ボタンを返します。イベントハンドラは作成してください。
        /// </summary>
        internal Button removeButton(Canvas canvas,Button insertionBtn)
        {
            Button btn = new Button();
            btn.Style = FindResource("CaptionButtonStyleKey") as Style;
            btn.Content = "r";
            btn.FontSize = 20;
            btn.Margin = new Thickness(580, 0, 0, 0);
            btn.Click += (send, ev) =>
            {
                _scene_stack.Children.Remove(canvas);
                _scene_stack.Children.Remove(insertionBtn);
            };
            return btn;
        }
        /// <summary>
        /// textboxを返します。イベントハンドラは作成してください。
        /// </summary>
        /// <returns></returns>
        internal TextBox componenttxBox(double height)
        {
            TextBox tx = new TextBox();
            tx.Style = FindResource("ComponentTextBox") as Style;
            tx.AcceptsReturn = true;
            tx.Height = height;
            return tx;
        }
        /// <summary>
        /// label(title)を返します。イベントハンドラは作成してください。
        /// </summary>
        /// <returns>Label</returns>
        /// <param name="titleTex">表示するタイトル。</param>
        /// <param name="colorNumber">1:ゲーム進行 2:キャラクター、演出 3:背景 4:コマンド</param>
        internal Label label_title(string titleTex,int colorNumber)
        {
            Label la = new Label();
            la.Style = FindResource("ComponentLabel") as Style;
            Color c;
            switch (colorNumber)
            {
                case 1:
                    c = Color.FromRgb(30, 43, 102);
                    break;
                case 2:
                    c = Color.FromRgb(106, 137, 101);
                    break;
                case 3:
                    c = Color.FromRgb(122, 193, 15);
                    break;
                case 4:
                    c = Color.FromRgb(54, 23, 68);
                    break;
                default:
                    c = Color.FromRgb(30, 43, 102);
                    break;
            }
            la.Background = new SolidColorBrush(c);
            la.Content = titleTex;
            return la;
        }
        internal Button insertionBtn()
        {
            Button rect = new Button();
            rect.Height = 10;
            rect.Style = FindResource("ComponentButton") as Style;
            rect.Click += (sen, ee) =>
            {
                isInsertionMode = true;
                navigate_page("挿入", ip);
                insertionNum = _scene_stack.Children.IndexOf(rect);
            };
            return rect;
        }

    }
}
