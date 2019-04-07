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
using System.IO;
namespace GranteGen
{
    /// <summary>
    /// CreateWizard.xaml の相互作用ロジック
    /// </summary>
    public partial class CreateWizard : Window
    {
        public CreateWizard()
        {
            InitializeComponent();
        }
        public string prjpath = "";
        public string title = "";
        public bool suc = false;
        private void titlet_GotFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void createb_Click(object sender, RoutedEventArgs e)
        {
            //判定
            if(titlet.Text!=""&&relt.Text!="")
            {
                try
                {
                    Directory.CreateDirectory(relt.Text + "\\"+titlet.Text);
                    prjpath = relt.Text + "\\"+titlet.Text;
                    title = titlet.Text;
                    suc = true;
                    this.Close();
                }
                catch(Exception)
                {
                    Error er = new Error();
                    er.errorText = "フォルダを正しく作成できませんでした。使用禁止文字がある可能性があります。";
                    er.Topmost = true;
                    er.Show();
                }
            }
            else
            {
                Error er = new Error();
                er.errorText = "タイトルとプロジェクトパスのだちらか、または両方が正しく入力されていません。";
                er.Topmost = true;
                er.Show();
            }
        }

        private void relb_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fda = new FolderBrowserDialog();
            if (fda.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                relt.Text = fda.SelectedPath;
            }
        }
    }
}
