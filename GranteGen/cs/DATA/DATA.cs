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
       
          string helper_text = "メッセージキャンバスにテキストを描画します。基本的にキャラクターのテキストや、主人公のテキストとして使用してください。#を使用してキャラクター名を指定できます。#を使用した行はすべてキャラクタ名となります。#でテキストを区切ります。テキストの初めには、キャラクター名がなくても#が必要です。例を示します。\r\n#Grante        //Granteという名前を指定しています\r\n[src=1.mp3]\r\n「今日はとってもいい天気だ。」     //テキストに表示されます。\r\n#      //空白を入れずに#のみを指定することでキャラクタ名をリセットできます。\r\nそう俺は思った。   //キャラクタ名はなしでテキストが表示されます。";
        string helper_img = "背景キャンバスに画像を描画します。基本的な.png、.jpgなどをサポートしています。動画ファイルはサポートされていません。(.gifを含む。)\r\nリソースから画像を選択すると、ウィンドウ右下の画像が選択状態になります。この状態で、背景テキストエリアをクリックすると自動的にファイルパスが指定されます。";
        string helper_charainsert = "キャラクターを登場させます。透過処理が施されている画像を指定します。位置設定が可能です。しかしながら、一貫性がなくなる場合があるので、テンプレート(スタイル)を使用してください。";
    }
}

