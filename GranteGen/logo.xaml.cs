using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GranteGen
{
    /// <summary>
    /// logo.xaml の相互作用ロジック
    /// </summary>
    public partial class logo : Window
    {
        public logo()
        {
            InitializeComponent();
        }

        private async void Storyboard_Completed(object sender, EventArgs e)
        {
            await Task.Delay(300);
            this.Close();
        }
    }
}
