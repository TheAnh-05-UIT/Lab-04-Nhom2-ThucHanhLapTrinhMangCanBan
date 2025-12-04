using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.Text;
using System.Linq;



namespace Bai04_Lab04
{


    public partial class FormMain : Form
    {
        List<Phim> dsPhim = new List<Phim>();

        Dictionary<int, List<string>> gheDaBan = new Dictionary<int, List<string>>();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            gheDaBan.Add(1, new List<string>());
            gheDaBan.Add(2, new List<string>());
            gheDaBan.Add(3, new List<string>());

            prgTienDo.Minimum = 0;
            prgTienDo.Step = 1;

            if (File.Exists("data_phim.json"))
            {
                LoadJsonData();
            }
        }

        private void HienThiGiaoDien()
        {
            flpDanhSachPhim.Controls.Clear();

            cbPhim.DataSource = null;
            cbPhim.DataSource = dsPhim;
            cbPhim.DisplayMember = "TenPhim";
            cbPhim.SelectedIndex = -1;

            foreach (var phim in dsPhim)
            {

                Panel pnl = new Panel { Width = 140, Height = 220, Margin = new Padding(5) };

                PictureBox pic = new PictureBox
                {
                    Width = 130,
                    Height = 180,
                    Top = 5,
                    Left = 5,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand
                };
                try { pic.Load(phim.UrlHinhAnh); } catch { }

                pic.Click += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(phim.UrlChiTiet))
                        Process.Start(new ProcessStartInfo { FileName = phim.UrlChiTiet, UseShellExecute = true });
                };

                Label lbl = new Label
                {
                    Text = phim.TenPhim,
                    Top = 190,
                    Left = 5,
                    Width = 130,
                    Font = new Font("Arial", 8, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                pnl.Controls.Add(pic);
                pnl.Controls.Add(lbl);
                flpDanhSachPhim.Controls.Add(pnl);
            }
        }

        private void LoadJsonData()
        {
            try
            {
                string json = File.ReadAllText("data_phim.json");
                dsPhim = JsonConvert.DeserializeObject<List<Phim>>(json);
                HienThiGiaoDien();
            }
            catch { }
        }

        private async void btnLayDuLieu_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            if (string.IsNullOrEmpty(url)) return;

            try
            {
                HtmlWeb web = new HtmlWeb();

                var doc = await web.LoadFromWebAsync(url);

                var nodes = doc.DocumentNode.SelectNodes("//div[@id='tab-1']//div[contains(@class,'row')]/div");

                if (nodes == null || nodes.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu! Có thể cấu trúc web đã đổi.");
                    return;
                }

                dsPhim.Clear();
                prgTienDo.Value = 0;
                prgTienDo.Maximum = nodes.Count;

                foreach (var node in nodes)
                {
                    Phim p = new Phim();

                    var linkNode = node.SelectSingleNode(".//h3/a");
                    if (linkNode != null)
                    {
                        p.TenPhim = linkNode.InnerText.Trim();
                        string href = linkNode.GetAttributeValue("href", "");
                        p.UrlChiTiet = href.StartsWith("http") ? href : "https://betacinemas.vn" + href;
                    }
                    else
                    {
                        continue;
                    }

                    var imgNode = node.SelectSingleNode(".//img");
                    if (imgNode != null)
                    {
                        string src = imgNode.GetAttributeValue("src", "");
                        p.UrlHinhAnh = src.StartsWith("http") ? src : "https://betacinemas.vn" + src;
                    }

                    bool daTonTai = dsPhim.Any(x => x.TenPhim == p.TenPhim);

                    if (!daTonTai)
                    {
                        dsPhim.Add(p);
                    }
                    prgTienDo.PerformStep();

                    p.GiaVeChuan = 50000 + (new Random().Next(0, 4) * 10000);
                }

                prgTienDo.Value = prgTienDo.Maximum;

                if (prgTienDo.Value > 0)
                {
                    prgTienDo.Value = prgTienDo.Value - 1;
                    prgTienDo.Value = prgTienDo.Maximum;
                }

                string json = JsonConvert.SerializeObject(dsPhim, Formatting.Indented);
                File.WriteAllText("data_phim.json", json);

                HienThiGiaoDien();
                MessageBox.Show($"Đã cập nhật thành công {dsPhim.Count} bộ phim!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadGhe(int phong)
        {
            clbGhe.Items.Clear();
            List<string> daBan = gheDaBan[phong];
            if (gheDaBan.ContainsKey(phong))
            {
                daBan = gheDaBan[phong];
            }
            string[] hang = { "A", "B", "C" };

            foreach (var h in hang)
            {
                for (int i = 1; i <= 5; i++)
                {
                    string ghe = h + i;
                    if (daBan.Contains(ghe))
                        clbGhe.Items.Add(ghe + " (Đã bán)", CheckState.Unchecked);
                    else
                        clbGhe.Items.Add(ghe, CheckState.Unchecked);
                }
            }
        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhim.SelectedItem is Phim p)
            {
                cbPhong.DataSource = null;

                cbPhong.DataSource = p.PhongChieu;

                clbGhe.Items.Clear();
            }
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhong.SelectedItem == null) return;
            int phong = (int)cbPhong.SelectedItem;
            LoadGhe(phong);
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)) { MessageBox.Show("Chưa nhập tên khách!"); return; }
            if (cbPhim.SelectedItem == null || cbPhong.SelectedItem == null) { MessageBox.Show("Chưa chọn phim/phòng!"); return; }
            if (clbGhe.CheckedItems.Count == 0) { MessageBox.Show("Chưa chọn ghế!"); return; }

            Phim phim = cbPhim.SelectedItem as Phim;
            int phong = (int)cbPhong.SelectedItem;

            foreach (var item in clbGhe.CheckedItems)
            {
                string s = item.ToString();

                string tenGheCheck = s.Split('(')[0].Trim();

                if (s.Contains("(Đã bán)"))
                {
                    MessageBox.Show($"Ghế {s} đã bán, vui lòng bỏ chọn!");
                    return;
                }

                if (gheDaBan.ContainsKey(phong) && gheDaBan[phong].Contains(tenGheCheck))
                {
                    MessageBox.Show($"Ghế {tenGheCheck} vừa có người khác mua xong! Vui lòng chọn ghế khác.");
                    LoadGhe(phong);
                    return;
                }
            }

            double tongTien = 0;
            List<string> gheInHoaDon = new List<string>();
            List<string> gheCanLuu = new List<string>();

            foreach (var item in clbGhe.CheckedItems)
            {
                string tenGhe = item.ToString();

                double giaGheNay = TinhTien(tenGhe, phim.GiaVeChuan);

                tongTien += giaGheNay;

                gheInHoaDon.Add($"{tenGhe} ({giaGheNay:N0})");

                gheCanLuu.Add(tenGhe);
            }

            if (gheDaBan.ContainsKey(phong))
            {
                gheDaBan[phong].AddRange(gheCanLuu);
            }

            rtbKetQua.Text = "";
            rtbKetQua.AppendText("           HÓA ĐƠN THANH TOÁN         \n");
            rtbKetQua.AppendText("--------------------------------\n");
            rtbKetQua.AppendText($"Khách hàng: {txtHoTen.Text}\n");
            rtbKetQua.AppendText($"Phim: {phim.TenPhim}\n");
            rtbKetQua.AppendText($"Phòng: {phong}\n");

            rtbKetQua.AppendText("Chi tiết ghế:\n");
            foreach (var g in gheInHoaDon)
            {
                rtbKetQua.AppendText($"  + {g} VNĐ\n");
            }

            rtbKetQua.AppendText("--------------------------------\n");
            rtbKetQua.AppendText($"TỔNG TIỀN: {tongTien:N0} VNĐ\n");
            rtbKetQua.AppendText("================================\n");

            MessageBox.Show("Đặt vé thành công!");

            LoadGhe(phong);
        }

        private double TinhTien(string ghe, double giaChuan)
        {
            if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5")
                return giaChuan * 0.25;

            if (ghe == "B2" || ghe == "B3" || ghe == "B4")
                return giaChuan * 2.0;

            return giaChuan;
        }

        private void clbGhe_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string gheDangChon = clbGhe.Items[e.Index].ToString();

            if (gheDangChon.Contains("(Đã bán)") && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Ghế này đã bán, bạn không thể chọn!", "Thông báo");

                e.NewValue = e.CurrentValue;
            }
        }
    }
}


public class Phim
{
    public string TenPhim { get; set; }
    public string UrlHinhAnh { get; set; }
    public string UrlChiTiet { get; set; }
    public double GiaVeChuan { get; set; }
    public List<int> PhongChieu { get; set; }

    public Phim()
    {
        PhongChieu = new List<int> { 1, 2, 3 };
    }
}
