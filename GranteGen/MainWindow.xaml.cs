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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GranteGen
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //グローバル変数とかはglobal.csを参照
        //ComponentObject cp;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            #region スタート処理
            Initilize();
            loadedProcess();
            showMenu();
            //showLogo();
            
            #endregion
        }


        private void _close_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void comp_textb_Click(object sender, RoutedEventArgs e)
        {
            text();
        }

        private void comp_imgb_Click(object sender, RoutedEventArgs e)
        {
            img();
        }

        private void comp_charainsertb_Click(object sender, RoutedEventArgs e)
        {
            chara_instert();
        }

        private void comp_pageb_Click(object sender, RoutedEventArgs e)
        {

        }

        private void pageEditb_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void save_Click(object sender, RoutedEventArgs e)
        {
            await Save();
        }

        private void _newadder_button_Click(object sender, RoutedEventArgs e)
        {
            ns.scenetext.Text = "";
            navigate_page("新規作成", ns);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i<100;i++)
            {
                text();
            }
        }

        private void Im_transf_Click(object sender, RoutedEventArgs e)
        {
            openImageResourcebyExplorer();
        }

        private void Ch_transf_Click(object sender, RoutedEventArgs e)
        {
            openCharacterResourcebyExplorer();
        }

        private void Ch_resload_Click(object sender, RoutedEventArgs e)
        {
            ch_reload();
        }

        private void Im_resload_Click(object sender, RoutedEventArgs e)
        {
            res_reload();
        }

        private void _resource_imageshow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(path + @"\img\" + selectedResourceImage);
            }
            catch (Exception) { }
        }

        private void _chara_imageshow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(path + @"\character\" + selectedResourceCharacter);
            }
            catch (Exception) { }
        }
    }
}
