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
        void prj_loaded()
        {
            scene_list_reload();
            res_reload();
            ch_reload();
        }
        void scene_button_add(string button_text)
        {
            Button _scenebutton = new Button();
            _scenebutton.Content = button_text;
            _scenebutton.Click += _scenebutton_Click;
            _Scenario_stackpanel.Children.Add(_scenebutton);
        }

        private void _scenebutton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string scene_nam = ((Button)sender).Content.ToString();
            if (scene_nam != _currentscene)
            {
                _currentsceneselected = true;
                scene_change(scene_nam);
            }
        }

    }
}
