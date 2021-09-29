using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise11 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e)
        {
            if(ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                using (var reader = new StreamReader(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"))) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        if (line.Contains(tbKeyword.Text))
                            count++;
                    }
                    tbOutput.Text = "キーワード" + tbKeyword.Text + "含まれているのは" + count.ToString() + "行です";
                }
            }
        }

        private void btReadLine_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadAllLines(ofdOpenFile.FileName, Encoding.GetEncoding("shift_jis"));

                foreach(var item in lines) {
                    if (lines.Contains(tbKeyword.Text))
                        count++;
                }
                 tbOutput.Text = "キーワード" + tbKeyword.Text + "含まれているのは" + count.ToString() + "行です"; 
            }
        }
    }
}
