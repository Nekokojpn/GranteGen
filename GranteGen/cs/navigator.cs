using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GranteGen
{
    public partial class MainWindow : Window
    {
        void Navigate_Error(string text)
        {
            Error er = new Error();
            er.ErrorText.Text = text;
            er.Topmost = true;
            er.Show();
        }
        void navigate_Explain(string title,string text)
        {
            _selectedcontents_label.Content = title;
            ne.explaintext.Text = text;
            _selectedcontents_frame.Navigate(ne);
        }
        /// <summary>
        /// 指定されたクラスPageにナビゲートします。
        /// </summary>
        /// <param name="title">表示されるタイトル。</param>
        /// <param name="p">ナビゲート先のPage。</param>
        void navigate_page(string title,Page p)
        {
            _selectedcontents_label.Content = title;
            _selectedcontents_frame.Navigate(p);
        }
        void navigate_null()
        {
            _selectedcontents_frame.Navigate(null);
        }
        void navigate_image(string filename,string absolutepath="")
        {
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            if(absolutepath=="")
                bmp.UriSource = new Uri(path + @"\imgs\" + filename);
            else
                bmp.UriSource = new Uri(absolutepath + filename);
            bmp.EndInit();
            np.img.Source = bmp;
            np.imgpath.Text = path + @"\imgs\" + filename;
            _selectedcontents_frame.Navigate(np);
        }
    }
}
