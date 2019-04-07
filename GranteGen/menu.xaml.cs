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
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GranteGen
{
    /// <summary>
    /// menu.xaml の相互作用ロジック
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }
        public string title="";
        public string prjpath = "";
        bool isRefOk = false;
        private void createWizardb_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CreateWizard cw = new CreateWizard();
            cw.Topmost = true;
            cw.Closing += (senn, eee) =>
              {
                  if(cw.suc==true)
                  {
                      title = cw.title;
                      prjpath = cw.prjpath;
                      this.Close();
                  }
              };
            cw.Closed += (sen, ee) =>
              {
                  if (cw.suc != true)
                  {
                      this.Show();
                  }
              };
            cw.Show();
        }

        private void refb_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.Show();
                refl.Text = fbd.SelectedPath;
                isRefOk = true;
            }
            else
            {
                this.Show();
            }
        }

        private void refokb_Click(object sender, RoutedEventArgs e)
        {
            if(isRefOk==true)
            {
                //ディレクトリの最後のところを取得する--title
                MatchCollection m = Regex.Matches(refl.Text+@"\esc", @"\\(.+?)\\esc", RegexOptions.RightToLeft);
                title = m[m.Count - 1].ToString().Replace(@"\esc", "").Replace(@"\","");
                prjpath = refl.Text;
                this.Close();
            }
            else
            {
                Error er = new Error();
                er.errorText = "選択されていません。参照ボタンから選択してください。";
                er.Topmost = true;
                er.Show();
            }
        }

        private void Deb_Click(object sender, RoutedEventArgs e)
        {
            //ディレクトリの最後のところを取得する--title
            MatchCollection m = Regex.Matches(@"C:\Resources\Grante\test\esc", @"\\(.+?)\\esc",RegexOptions.RightToLeft);
            title = m[m.Count - 1].ToString().Replace(@"\esc","").Replace(@"\", "");
            prjpath = @"C:\Resources\Grante\test";
            this.Close();
        }
    }
}
