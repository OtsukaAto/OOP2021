﻿using System.Windows;
namespace TestWpf03 {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public void InitializeComponent()
        {
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ボタンがクリックされました。");
        }
    }
}