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
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Sample1 {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public string Message { get; set; }
        public string TextMessage { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Message);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Message = "testmessage";
            MessageBox.Show(TextMessage);
        }

        public class ChangeText : INotifyPropertyChanged {
            private string TextValue = String.Empty;

            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null) {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            private ChangeText()
            {
                TextValue = "testmessage";
            }

            public string TextMessage {
                get {
                    return this.TextValue;
                }

                set {
                    if (value != this.TextValue) {
                        this.TextValue = value;
                        NotifyPropertyChanged();
                    }
                }
            }

        }
    }
}