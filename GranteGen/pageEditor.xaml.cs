using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GranteGen
{
    /// <summary>
    /// pageEditor.xaml の相互作用ロジック
    /// </summary>
    public partial class pageEditor : Window
    {
        public pageEditor()
        {
            InitializeComponent();
        }
        pageEditComponent pe = new pageEditComponent();
        private void mainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            pe.imageb.Click += (send, ev) =>
              {
                  Thumb tb = new Thumb();

              };
            pe.buttonb.Click += (send1, ev1) =>
              {
                  Thumb tb = new Thumb();
                  Button btn = new Button();
                  btn.Content = "Content";
                  
              };
            pe.Topmost = true;
            pe.Show();
        }
    }
}
