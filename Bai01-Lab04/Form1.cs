using System;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace Bai01_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getHTML(string szUrl)
        {
            try
            {
                // Tạo WebRequest tới URL
                WebRequest request = WebRequest.Create(szUrl);

                // Nhận phản hồi từ server
                WebResponse response = request.GetResponse();

                // Lấy luồng dữ liệu trả về
                Stream dataStream = response.GetResponseStream();

                // Đọc dữ liệu từ luồng
                StreamReader reader = new StreamReader(dataStream);

                // Đọc toàn bộ nội dung HTML
                string responseFromServer = reader.ReadToEnd();

                // Đóng tài nguyên
                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text.Trim();

            if (url == "")
            {
                MessageBox.Show("Vui lòng nhập URL!");
                return;
            }

            string html = getHTML(url);

            richTextBox1.Text = html;
        }
    }
}
