using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Bai02_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string url = txtURL.Text.Trim();
            string filePath = txtFilePath.Text.Trim();

            if (url == "" || filePath == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ URL và đường dẫn lưu file!");
                return;
            }

            try
            {
                // ✅ TỰ TẠO THƯ MỤC NẾU CHƯA TỒN TẠI
                string folder = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                WebClient myClient = new WebClient();
                myClient.DownloadFile(url, filePath);

                string htmlContent = File.ReadAllText(filePath, Encoding.UTF8);
                richTextBox1.Text = htmlContent;

                MessageBox.Show("Download thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
