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
        void ch_reload()
        {
            _chara_Stack.Children.Clear();
            string[] subfolders = Directory.GetDirectories(path + @"\character\", "*", SearchOption.TopDirectoryOnly);
            foreach (string s in subfolders)
            {
                ListBox charalist = new ListBox();
                charalist.Name = Path.GetFileName(s);
                Label chla = new Label();
                chla.Content = Path.GetFileName(s);
                chla.FontSize = 10;



                _chara_Stack.Children.Add(chla);

                string[] subfiles = Directory.GetFiles(s + "\\", "*", SearchOption.TopDirectoryOnly);

                charalist.Height = 250;
                charalist.FontSize = 10;
                foreach (string ss in subfiles)
                {
                    charalist.Items.Add(Path.GetFileName(ss));
                }
                charalist.SelectionChanged += (send, ee) =>
                {
                    navigate_image(charalist.SelectedItem.ToString(), s + @"\");
                    isSelectedResourceCharacter = true;
                    selectedResourceCharacter = charalist.SelectedItem.ToString();
                    _selected_Chara_Label.Text = selectedResourceCharacter;
                };

                _chara_Stack.Children.Add(charalist);
            }
        }
    }
}

