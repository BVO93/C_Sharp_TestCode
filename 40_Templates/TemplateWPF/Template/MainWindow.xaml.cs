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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Template
{
    /// <summary>
    ///
    ///         This file contains a state machine to set the visual properties at the interface as required.
    /// 
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ClickSum(object sender, RoutedEventArgs e)
        {
            button.Background = System.Windows.Media.Brushes.DarkOliveGreen;

        }

    }
}
