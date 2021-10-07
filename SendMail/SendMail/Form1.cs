using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class Form1 : Form {
        //設定画面
        private ConfigForm configForm = new ConfigForm();

        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1()
        {
            InitializeComponent();
            var filePath = @"./settings.xml";
            if (!File.Exists(filePath))
            {               
                 configForm.ShowDialog();
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);

                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }

                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;

                //smtpClient.Send(mailMessage);   //非同期でない場合

                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                //smtpClient.SendCompleted += new　SendCompletedEventHandler(SmtpClient_SendCompleted);　//古い書き方

                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //送信が完了すると呼ばれるコールバックメソッド
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
            }

        }

        private void btConfig_Click_1(object sender, EventArgs e)
        {
            configForm.ShowDialog();

        }
        private void Form1_Load(object sender,EventArgs e)
        {
            //XMLファイルを読み込み(逆シリアル化)
            using (var reader = XmlReader.Create("mailsetting.xml")) 
            {
                
                var serializer = new DataContractSerializer(typeof(Settings));
                var readSettings = serializer.ReadObject(reader) as Settings;

                settings.Host = readSettings.Host;
                settings.Port = readSettings.Port;
                settings.MailAddr = readSettings.MailAddr;
                settings.Pass = readSettings.Pass;
                settings.Ssl = readSettings.Ssl;
            }
        }
    }
}
