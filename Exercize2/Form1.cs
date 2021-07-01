using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercize2 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num;
            if(int.TryParse(inStrNum.Text,out num)) {
                outStrNum.Text = num.ToString("#,#");
            } else {
                outStrNum.Text = "数値文字列ではありません";
            }
        }
    }
}
