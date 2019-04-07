﻿using System;
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
    /// Error.xaml の相互作用ロジック
    /// </summary>
   
    public partial class Error : Window
    {
        public Error()
        {
            InitializeComponent();
            this.DataContext = errorText;
        }
        public string errorText = "";

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ErrorText.Text = errorText;
        }
    }
}
