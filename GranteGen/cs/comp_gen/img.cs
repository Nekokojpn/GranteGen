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
        public void img()
        {
            Canvas canvas = new Canvas();
            canvas.Height = 45;
            //コンポーネントを削除するボタンを実装します。
            Button ins = insertionBtn();
            Button remBtn = removeButton(canvas,ins);
            Button helBtn = helpButton("背景", helper_img);
            TextBox maintex = componenttxBox(20);
            Label lb = label_title("背景",3);
            
            canvas.Children.Add(lb);
            canvas.Children.Add(maintex);
            canvas.Children.Add(remBtn);
            canvas.Children.Add(helBtn);


            addToCanvas(canvas, ins);
        }
    }
}
