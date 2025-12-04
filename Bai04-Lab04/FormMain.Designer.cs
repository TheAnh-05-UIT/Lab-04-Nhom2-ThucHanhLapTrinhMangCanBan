namespace Bai04_Lab04
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnLayDuLieu = new System.Windows.Forms.Button();
            this.prgTienDo = new System.Windows.Forms.ProgressBar();
            this.flpDanhSachPhim = new System.Windows.Forms.FlowLayoutPanel();
            this.clbChoNgoi = new System.Windows.Forms.GroupBox();
            this.clbGhe = new System.Windows.Forms.CheckedListBox();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.cbPhim = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbChoNgoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(68, 41);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(372, 30);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "https://betacinemas.vn/phim.htm";
            // 
            // btnLayDuLieu
            // 
            this.btnLayDuLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDuLieu.Location = new System.Drawing.Point(68, 159);
            this.btnLayDuLieu.Name = "btnLayDuLieu";
            this.btnLayDuLieu.Size = new System.Drawing.Size(222, 47);
            this.btnLayDuLieu.TabIndex = 1;
            this.btnLayDuLieu.Text = "Cập nhật dữ liệu Phim";
            this.btnLayDuLieu.UseVisualStyleBackColor = true;
            this.btnLayDuLieu.Click += new System.EventHandler(this.btnLayDuLieu_Click);
            // 
            // prgTienDo
            // 
            this.prgTienDo.Location = new System.Drawing.Point(68, 95);
            this.prgTienDo.Name = "prgTienDo";
            this.prgTienDo.Size = new System.Drawing.Size(372, 16);
            this.prgTienDo.TabIndex = 2;
            // 
            // flpDanhSachPhim
            // 
            this.flpDanhSachPhim.AutoScroll = true;
            this.flpDanhSachPhim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDanhSachPhim.Location = new System.Drawing.Point(607, 41);
            this.flpDanhSachPhim.Name = "flpDanhSachPhim";
            this.flpDanhSachPhim.Size = new System.Drawing.Size(357, 270);
            this.flpDanhSachPhim.TabIndex = 3;
            // 
            // clbChoNgoi
            // 
            this.clbChoNgoi.Controls.Add(this.clbGhe);
            this.clbChoNgoi.Controls.Add(this.rtbKetQua);
            this.clbChoNgoi.Controls.Add(this.btnDatVe);
            this.clbChoNgoi.Controls.Add(this.cbPhong);
            this.clbChoNgoi.Controls.Add(this.cbPhim);
            this.clbChoNgoi.Controls.Add(this.txtHoTen);
            this.clbChoNgoi.Controls.Add(this.label4);
            this.clbChoNgoi.Controls.Add(this.label3);
            this.clbChoNgoi.Controls.Add(this.label2);
            this.clbChoNgoi.Controls.Add(this.label1);
            this.clbChoNgoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbChoNgoi.Location = new System.Drawing.Point(0, 343);
            this.clbChoNgoi.Name = "clbChoNgoi";
            this.clbChoNgoi.Size = new System.Drawing.Size(996, 396);
            this.clbChoNgoi.TabIndex = 4;
            this.clbChoNgoi.TabStop = false;
            this.clbChoNgoi.Text = "Thông tin đặt vé";
            // 
            // clbGhe
            // 
            this.clbGhe.FormattingEnabled = true;
            this.clbGhe.Location = new System.Drawing.Point(184, 192);
            this.clbGhe.Name = "clbGhe";
            this.clbGhe.Size = new System.Drawing.Size(256, 96);
            this.clbGhe.TabIndex = 10;
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(556, 35);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.ReadOnly = true;
            this.rtbKetQua.Size = new System.Drawing.Size(385, 295);
            this.rtbKetQua.TabIndex = 9;
            this.rtbKetQua.Text = "";
            // 
            // btnDatVe
            // 
            this.btnDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Location = new System.Drawing.Point(95, 319);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(154, 52);
            this.btnDatVe.TabIndex = 8;
            this.btnDatVe.Text = "Thanh toán";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // cbPhong
            // 
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(184, 133);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(256, 28);
            this.cbPhong.TabIndex = 6;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // cbPhim
            // 
            this.cbPhim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhim.FormattingEnabled = true;
            this.cbPhim.Location = new System.Drawing.Point(184, 77);
            this.cbPhim.Name = "cbPhim";
            this.cbPhim.Size = new System.Drawing.Size(256, 28);
            this.cbPhim.TabIndex = 5;
            this.cbPhim.SelectedIndexChanged += new System.EventHandler(this.cbPhim_SelectedIndexChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(184, 34);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(256, 26);
            this.txtHoTen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghế";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 739);
            this.Controls.Add(this.clbChoNgoi);
            this.Controls.Add(this.flpDanhSachPhim);
            this.Controls.Add(this.prgTienDo);
            this.Controls.Add(this.btnLayDuLieu);
            this.Controls.Add(this.txtUrl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng vé";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.clbChoNgoi.ResumeLayout(false);
            this.clbChoNgoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnLayDuLieu;
        private System.Windows.Forms.ProgressBar prgTienDo;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachPhim;
        private System.Windows.Forms.GroupBox clbChoNgoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.ComboBox cbPhim;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.CheckedListBox clbGhe;
    }
}

