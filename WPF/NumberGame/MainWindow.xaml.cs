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
using System.Windows.Threading;
using System.Security.Cryptography;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();      // Randomオブジェクトを作成

            int seikai = rnd.Next(1, 25);        // 1から25までの値をランダムに取得

            Console.WriteLine(seikai.ToString());
            if (seikai == ) {
                Console.WriteLine("そうだよ");
            } else {
                Console.WriteLine("ちがいます");
            }
            Console.ReadLine();
        }
    }
}
