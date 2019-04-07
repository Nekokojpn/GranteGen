using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GranteGen
{
    /// <summary>
    /// 各コンポーネントにGUIを提供するクラスです。基本的にCanvasを返します。
    /// </summary>
    public partial class MainWindow : Window
    {
        public void chara_instert()
        {
            
            Canvas canvas = new Canvas();
            canvas.Height = 45;
            //コンポーネントを削除するボタンを実装します。
            Button ins = insertionBtn();
            Button remBtn = removeButton(canvas,ins);
            Button helBtn = helpButton("キャラクター登場", helper_charainsert);
            TextBox maintex = componenttxBox(20);
            Label lb = label_title("キャラクター登場",2);

            canvas.Children.Add(lb);
            canvas.Children.Add(maintex);
            canvas.Children.Add(remBtn);
            canvas.Children.Add(helBtn);

            addToCanvas(canvas, ins);
        }
    }
}
