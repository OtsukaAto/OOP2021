using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace RssReader {
    public partial class Form1 : Form {
        List<string> rink = new List<string>();
        List<string> label = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            SetRssTitle(tbUrl.Text);
        }
        //リセットボックスへセット
        private void SetRssTitle(string uri)
        {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var url = new Uri(uri);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");

                foreach (var node in nodes) {
                    lbTitles.Items.Add((node.Value));
                    rink.Add(node.Element("link").Value);
                    label.Add(node.Element("description").Value);
                }
            }
        }
        //ブラウザーコントロールに表示
        private void lbTitles_Click(object sender, EventArgs e)
        {
            var num = lbTitles.SelectedIndex;
            wbBrowser.Url = new Uri(rink[num]);
            label2.Text = (label[num]);
        }
        private void tbUrl_TextChanged(object sender, EventArgs e)
        {



        }
    }
}