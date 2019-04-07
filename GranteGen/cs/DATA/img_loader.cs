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
        void res_reload()
        {
            _Res_stackpanel.Children.Clear();
            // prg_show();
            string[] subfolders = Directory.GetDirectories(path+@"\imgs", "*", SearchOption.TopDirectoryOnly);
            foreach (string s in subfolders)
            {
                ListBox imagelist = new ListBox();
                imagelist.Name = Path.GetFileName(s);
                Label imla = new Label();
                imla.Content = Path.GetFileName(s);
                imla.FontSize = 10;



                _Res_stackpanel.Children.Add(imla);

                string[] subfiles = Directory.GetFiles(s + "\\", "*", SearchOption.TopDirectoryOnly);

                imagelist.Height = 250;
                imagelist.FontSize = 10;
                foreach (string ss in subfiles)
                {
                    imagelist.Items.Add(Path.GetFileName(ss));
                }
                imagelist.SelectionChanged += (send, ee) =>
                {
                    navigate_image(imagelist.SelectedItem.ToString(), s + @"\");
                    isSelectedResourceImage = true;
                    selectedResourceImage = imagelist.SelectedItem.ToString();
                    _selected_image_Label.Text = selectedResourceImage;
                };
                

                _Res_stackpanel.Children.Add(imagelist);


            }
            
        }
    }
}

