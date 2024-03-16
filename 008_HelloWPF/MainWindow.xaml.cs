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

namespace _008_HelloWPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtHello_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("TextBlock Clicked", "String Msg");
            if (grid1.Background == Brushes.Orange)  //색깔은 Brushes를 사용한다
            {
                grid1.Background = Brushes.Aqua;
                txtHello.Foreground = Brushes.Blue;
            }
            else
            {
                grid1.Background = Brushes.Orange;
                txtHello.Foreground = Brushes.Red;
            }
        }
    }
}
       
    
