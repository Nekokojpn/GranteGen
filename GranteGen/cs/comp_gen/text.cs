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
    /// <summary>
    /// 各コンポーネントにGUIを提供するメソッドです。基本的にCanvasを返します。
    /// </summary>
    public partial class MainWindow : Window
    {
        public void text()
        {
            
            Canvas canvas = new Canvas();
            canvas.Height = 125;
            //コンポーネントを削除するボタンを実装します。
            Button ins = insertionBtn();
            Button remBtn = removeButton(canvas,ins);
            Button helBtn = helpButton("テキスト", helper_text);
            TextBox maintex = componenttxBox(100);
            maintex.Text = "#unko\r\nうんこおお";
            Label lb = label_title("テキスト",1);
            canvas.Children.Add(lb);
            canvas.Children.Add(maintex);
            canvas.Children.Add(remBtn);
            canvas.Children.Add(helBtn);

            addToCanvas(canvas, ins);
        }
    }
}
