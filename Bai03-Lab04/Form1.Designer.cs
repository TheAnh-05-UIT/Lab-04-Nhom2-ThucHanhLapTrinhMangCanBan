namespace Bai03_Lab04
{
    partial class Form1
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDownResources = new System.Windows.Forms.Button();
            this.btnDownFiles = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(12, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(753, 50);
            this.txtURL.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(789, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(168, 50);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(789, 79);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(168, 54);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDownResources
            // 
            this.btnDownResources.Location = new System.Drawing.Point(548, 79);
            this.btnDownResources.Name = "btnDownResources";
            this.btnDownResources.Size = new System.Drawing.Size(217, 54);
            this.btnDownResources.TabIndex = 3;
            this.btnDownResources.Text = "Down Resources";
            this.btnDownResources.UseVisualStyleBackColor = true;
            this.btnDownResources.Click += new System.EventHandler(this.btnDownResources_Click);
            // 
            // btnDownFiles
            // 
            this.btnDownFiles.Location = new System.Drawing.Point(357, 79);
            this.btnDownFiles.Name = "btnDownFiles";
            this.btnDownFiles.Size = new System.Drawing.Size(164, 54);
            this.btnDownFiles.TabIndex = 4;
            this.btnDownFiles.Text = "Down Files";
            this.btnDownFiles.UseVisualStyleBackColor = true;
            this.btnDownFiles.Click += new System.EventHandler(this.btnDownFiles_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 145);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(945, 510);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 667);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btnDownFiles);
            this.Controls.Add(this.btnDownResources);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDownResources;
        private System.Windows.Forms.Button btnDownFiles;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}

