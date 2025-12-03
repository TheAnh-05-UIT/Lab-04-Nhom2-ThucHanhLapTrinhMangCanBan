using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai05_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            urlBox.Text = "https://nt106.uitiot.vn/auth/token";
        }
        private async void loginButton_Click(object sender, EventArgs e)
        {
            string url = urlBox.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                url = "https://nt106.uitiot.vn/auth/token";
            }
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Username và Password.");
                return;
            }
            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                try
                {
                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    var responseObject = JObject.Parse(responseString);
                    if (!response.IsSuccessStatusCode)
                    {
                        var detail = responseObject["detail"]?.ToString();
                        responseBox.Text = "Đăng nhập không thành công.\r\n"
                                         + "Detail: " + detail;
                        return;
                    }
                    var tokenType = responseObject["token_type"]?.ToString();
                    var accessToken = responseObject["access_token"]?.ToString();
                    responseBox.Text = "Đăng nhập thành công!\r\n" + $"{tokenType} {accessToken}";
                }
                catch (Exception ex)
                {
                    responseBox.Text = "Lỗi khi gọi API:\r\n" + ex.Message;
                }
            }
        }
    }
}
