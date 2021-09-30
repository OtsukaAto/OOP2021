using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SendMail {
    public partial class ConfigForm : Form {
        Form1 f1;
        public Settings Settings = new Settings();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            tbHost.Text = settings.sHost();
            tbUserName.Text = settings.sMailAddr();
            tbPort.Text = settings.sPort();
            tbPass.Text = settings.sPass();
        }
        private void ConfigForm_Load(object sender, EventArgs e)
        {
            f1 = new Form1();
        }
        //OK
        private void btOk_Click(object sender, EventArgs e)
        {
            SettingsRegist();
            this.Close();
        }


        private void SettingsRegist()
        {
            Settings.Host = tbHost.Text;
            Settings.Port = int.Parse(tbPort.Text);
            Settings.MailAddr = tbUserName.Text;
            Settings.Pass = tbPass.Text;
            Settings.Ssl = cbSsl.Checked;
        }

        //適用
        private void btApply_Click(object sender, EventArgs e)
        {
            SettingsRegist(); //送信データ登録
        }

        //キャンセル
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
