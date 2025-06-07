using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace ZueKelime
{
    partial class Wordle
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBaslik;
        private TextBox txtTahmin;
        private Button btnTahmin;
        private ListBox lstSonuclar;
        private PictureBox picLogo;
        private Button btnSinaviYenidenBaslat;
        private Button btnGeri;
        private Button btnCikis;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lstSonuclar = new System.Windows.Forms.ListBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSinaviYenidenBaslat = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(242, 110);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(201, 37);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Wordle Oyunu";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTahmin.Location = new System.Drawing.Point(107, 167);
            this.txtTahmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTahmin.MaxLength = 5;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(228, 39);
            this.txtTahmin.TabIndex = 2;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTahmin.Location = new System.Drawing.Point(358, 164);
            this.btnTahmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(114, 34);
            this.btnTahmin.TabIndex = 3;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lstSonuclar
            // 
            this.lstSonuclar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstSonuclar.FormattingEnabled = true;
            this.lstSonuclar.ItemHeight = 28;
            this.lstSonuclar.Location = new System.Drawing.Point(107, 205);
            this.lstSonuclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSonuclar.Name = "lstSonuclar";
            this.lstSonuclar.Size = new System.Drawing.Size(365, 172);
            this.lstSonuclar.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(52, 66);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(171, 95);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnSinaviYenidenBaslat
            // 
            this.btnSinaviYenidenBaslat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSinaviYenidenBaslat.Location = new System.Drawing.Point(448, 63);
            this.btnSinaviYenidenBaslat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSinaviYenidenBaslat.Name = "btnSinaviYenidenBaslat";
            this.btnSinaviYenidenBaslat.Size = new System.Drawing.Size(90, 45);
            this.btnSinaviYenidenBaslat.TabIndex = 5;
            this.btnSinaviYenidenBaslat.Text = "Yeniden Başlat";
            this.btnSinaviYenidenBaslat.UseVisualStyleBackColor = true;
            this.btnSinaviYenidenBaslat.Click += new System.EventHandler(this.btnSinaviYenidenBaslat_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnGeri.Location = new System.Drawing.Point(28, 22);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(30, 35);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "-";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCikis.Location = new System.Drawing.Point(548, 22);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 35);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "x";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Wordle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 434);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnSinaviYenidenBaslat);
            this.Controls.Add(this.lstSonuclar);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.picLogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Wordle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wordle";
            this.Load += new System.EventHandler(this.Wordle_Load); // <-- EKLENDİ!
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
