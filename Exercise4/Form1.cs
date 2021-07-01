using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで一回だけ実行される
        private void Form1_Load(object sender, EventArgs e)
        {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            inputStr.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void Button5_3_1_Click(object sender, EventArgs e)
        {
            var count = inputStrText.Text.Count(n => n == ' ');
            TextBoxSpaceCount.Text += count.ToString();
        }

        private void Button5_3_2_Click(object sender, EventArgs e)
        {
            var replaced = inputStrText.Text.Replace("big", "small");
            TextBoxWoldChange.Text += replaced.ToString();
        }

        private void Button5_3_3_Click(object sender, EventArgs e)
        {
            var word = inputStrText.Text.Split(' ').Count();
            TextBoxWordCount.Text += word;
        }

        private void Button5_3_4_Click(object sender, EventArgs e)
        {
            var word = inputStrText.Text.Split(' ').Where(n => n.Length <= 4);
            foreach (var item in word) {
                TextBox4Count.Text += item + ",";
            }

        }

        private void Button5_3_5_Click(object sender, EventArgs e)
        {
            var array = inputStrText.Text.Split(' ').ToArray();
            var concat = new StringBuilder();
            foreach (var word in array) {
                concat.Append(word + ' ');
            }
            textBoxTitle.Text += concat.ToString().Trim();
        }

        private void button5_4_Click(object sender, EventArgs e)
        {
            foreach(var pair in inputStr.Text.Split(';')) {
                var array = pair.Split('=');
                outputStr.Text += ToJapanese(array[0]) + ":" + array[1] + "\n"; //\n 改行
            }
        }

        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家";

                case "BestWork":
                    return "代表作";

                case "Born":
                    return "誕生年";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
