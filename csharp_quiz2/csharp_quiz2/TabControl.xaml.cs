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

namespace csharp_quiz2
{
    /// <summary>
    /// Interaction logic for TabControl.xaml
    /// </summary>
    public partial class TabControl : Window
    {
        public TabControl()
        {
            InitializeComponent();
        }

        private void chbTab_Checked(object sender, RoutedEventArgs e)
        {
            tabItem2.Visibility = Visibility.Visible;
        }

        private void chbTab_Unchecked(object sender, RoutedEventArgs e)
        {
            tabItem2.Visibility = Visibility.Hidden;
        }
    }
}
