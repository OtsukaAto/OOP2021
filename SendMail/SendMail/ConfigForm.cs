using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace SendMail {
    public partial class ConfigForm : Form {
        private Settings settings = Settings.getInstance();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e)
        {
            tbHost.Text = settings.sHost(); //ホスト名
            tbPort.Text = settings.sPort(); //ポート番号
            tbUserName.Text = settings.sMailAddr(); //ユーザー名
            tbPass.Text = settings.sPass(); //パスワード
            cbSsl.Checked = settings.bSsl();    //SSL
            tbSender.Text = settings.sMailAddr();   //送信元
        }
        //OKボタン
        private void btOk_Click(object sender, EventArgs e)
        {
            SettingRegist();

            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e)
        {
            SettingRegist();//送信データ登録
        }

        //送信データ登録
        private void SettingRegist()
        {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;

            //XMLファイルへ書き出し(シリアル化)
            var settingXml = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("settings.xml", settingXml)) {
                var serializer = new DataContractSerializer(settingXml.GetType());
                serializer.WriteObject(writer, settings);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }
    }
}