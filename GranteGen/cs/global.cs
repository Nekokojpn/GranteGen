using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        //Initialize

        string path = "";
        string title = "";
        string _currentscenepath = "";
        string _currentscene = "";
        bool _currentsceneselected = false;
        string _currentscenefullpath = "";
        string data = "";
        string errdata = "";
        bool isInsertionMode = false;
        int insertionNum = 0;

        bool isSelectedResourceImage = false;
        bool isSelectedResourceCharacter = false;
        string selectedResourceImage = "";
        string selectedResourceCharacter = "";

        //Buf
        string buf;

        pages.NavigateExplain ne;
        pages.NavigateText nt;
        pages.NewScene ns;
        pages.insertionPage ip;
        pages.NavigatePreviewPic np;

        
    }
}
