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
        void scene_list_reload()
        {
            //シーンファイルを読み込みます
            _currentscenepath = path + @"\scene\";
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(_currentscenepath);
            System.IO.FileInfo[] files =
                di.GetFiles("*.sc", System.IO.SearchOption.AllDirectories);


            foreach (System.IO.FileInfo f in files)
            {
                scene_button_add(Path.GetFileNameWithoutExtension(f.FullName));

            }
            
        }
    }
}

