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

            Random rnd = new Random();      // Randomオブジェクトを作成
            seikai = rnd.Next(1, 26);        // 1から25までの値をランダムに取得
            InitializeComponent();
        }
        private int seikai;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var buttons = (Button)sender;
            int button = int.Parse(buttons.Content.ToString());
           

            Console.WriteLine(seikai.ToString());
            if (seikai ==  button) {
                text.Text = "あってる";
                buttons.Background = new SolidColorBrush(Colors.DeepPink);
                return;
            }
            if(button > seikai) {
                text.Text = "答えは小さいです";
            } else {
                text.Text = "答えはもっと大きいです";
            }
            buttons.Background = new SolidColorBrush(Colors.HotPink);
        }
    }
}
