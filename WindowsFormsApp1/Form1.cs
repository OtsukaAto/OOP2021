using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            
            DayOfWeek dayOfWeek = today.DayOfWeek;
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    tbOutput.Text = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    tbOutput.Text = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    tbOutput.Text = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    tbOutput.Text = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    tbOutput.Text = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    tbOutput.Text = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    tbOutput.Text = "今日は土曜日です";
                    break;
                default:
                    break;
            }
        }
    }
}
