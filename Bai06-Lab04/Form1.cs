using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06_Lab04
{
    public partial class Form1 : Form
    {
        private string tokenType;
        private string accessToken;

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

                        tokenType = null;
                        accessToken = null;
                        return;
                    }
                    tokenType = responseObject["token_type"]?.ToString();
                    accessToken = responseObject["access_token"]?.ToString();

                    responseBox.Text = "Đăng nhập thành công!\r\n"
                                     + $"{tokenType} {accessToken}";
                }
                catch (Exception ex)
                {
                    responseBox.Text = "Lỗi khi gọi API:\r\n" + ex.Message;
                }
            }
        }
        private async void userinfoButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tokenType) || string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("Bạn cần đăng nhập trước.");
                return;
            }

            string getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(tokenType, accessToken);

                try
                {
                    var response = await client.GetAsync(getUserUrl);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        responseBox.Text = "Không lấy được thông tin user.\r\n"
                                         + "Phản hồi từ server:\r\n"
                                         + responseString;
                        return;
                    }

                    responseBox.Text = "Thông tin user hiện tại:\r\n"
                                     + responseString;

                }
                catch (Exception ex)
                {
                    responseBox.Text = "Lỗi khi gọi API (Bài 6):\r\n" + ex.Message;
                }
            }
        }
    }
}
