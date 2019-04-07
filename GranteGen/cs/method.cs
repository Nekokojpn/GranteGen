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
        void openImageResourcebyExplorer()
        {
            System.Diagnostics.Process.Start(path+@"\imgs\");
        }
        void openCharacterResourcebyExplorer()
        {
            System.Diagnostics.Process.Start(path + @"\character\");
        }
    }
}
