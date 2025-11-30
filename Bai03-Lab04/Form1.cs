using Microsoft.Web.WebView2.WinForms;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;


namespace Bai03_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri(txtURL.Text.Trim());
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webView21.Reload();
        }

        private void btnDownResources_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            string folder = "E:\\WebBrowser\\Images";
            Directory.CreateDirectory(folder);

            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            var imgList = doc.DocumentNode.SelectNodes("//img");

            if (imgList == null)
            {
                MessageBox.Show("Không có ảnh!");
                return;
            }

            int i = 1;
            foreach (var img in imgList)
            {
                string link = img.GetAttributeValue("src", "");

                if (!link.StartsWith("http"))
                    continue;

                string fileName = folder + "\\img" + i + ".jpg";
                client.DownloadFile(link, fileName);
                i++;
            }

            MessageBox.Show("Đã tải xong tài nguyên hình ảnh!");
        }

        private void btnDownFiles_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text.Trim();
            string folder = "E:\\WebBrowser";
            string filePath = folder + "\\page.html";

            Directory.CreateDirectory(folder);

            WebClient client = new WebClient();
            client.DownloadFile(url, filePath);

            MessageBox.Show("Đã tải HTML về: " + filePath);
        }
    }
}
