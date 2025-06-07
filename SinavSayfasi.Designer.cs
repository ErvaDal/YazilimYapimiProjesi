using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZueKelime
{
	partial class SinavSayfasi
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label lblKelime;
		private System.Windows.Forms.RadioButton rdbSecenek1;
		private System.Windows.Forms.RadioButton rdbSecenek2;
		private System.Windows.Forms.RadioButton rdbSecenek3;
		private System.Windows.Forms.Button btnSonraki;
		private System.Windows.Forms.Label lblDogruSayac;
		private System.Windows.Forms.PictureBox picLogo;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavSayfasi));
            this.lblKelime = new System.Windows.Forms.Label();
            this.rdbSecenek1 = new System.Windows.Forms.RadioButton();
            this.rdbSecenek2 = new System.Windows.Forms.RadioButton();
            this.rdbSecenek3 = new System.Windows.Forms.RadioButton();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.lblDogruSayac = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.BtnAyarlar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKelime
            // 
            this.lblKelime.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblKelime.Location = new System.Drawing.Point(174, 140);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(436, 56);
            this.lblKelime.TabIndex = 1;
            this.lblKelime.Text = "Kelime";
            this.lblKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbSecenek1
            // 
            this.rdbSecenek1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbSecenek1.Location = new System.Drawing.Point(134, 294);
            this.rdbSecenek1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSecenek1.Name = "rdbSecenek1";
            this.rdbSecenek1.Size = new System.Drawing.Size(444, 38);
            this.rdbSecenek1.TabIndex = 2;
            // 
            // rdbSecenek2
            // 
            this.rdbSecenek2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbSecenek2.Location = new System.Drawing.Point(134, 342);
            this.rdbSecenek2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSecenek2.Name = "rdbSecenek2";
            this.rdbSecenek2.Size = new System.Drawing.Size(444, 38);
            this.rdbSecenek2.TabIndex = 3;
            // 
            // rdbSecenek3
            // 
            this.rdbSecenek3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.rdbSecenek3.Location = new System.Drawing.Point(134, 390);
            this.rdbSecenek3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbSecenek3.Name = "rdbSecenek3";
            this.rdbSecenek3.Size = new System.Drawing.Size(444, 38);
            this.rdbSecenek3.TabIndex = 4;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSonraki.Location = new System.Drawing.Point(269, 458);
            this.btnSonraki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(160, 46);
            this.btnSonraki.TabIndex = 5;
            this.btnSonraki.Text = "Sonraki";
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // lblDogruSayac
            // 
            this.lblDogruSayac.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDogruSayac.Location = new System.Drawing.Point(12, 520);
            this.lblDogruSayac.Name = "lblDogruSayac";
            this.lblDogruSayac.Size = new System.Drawing.Size(684, 30);
            this.lblDogruSayac.TabIndex = 6;
            this.lblDogruSayac.Text = "Doğru Sayısı: 0";
            this.lblDogruSayac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(29, 77);
            this.picLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(233, 172);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnAyarlar.Location = new System.Drawing.Point(571, 77);
            this.BtnAyarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.Size = new System.Drawing.Size(100, 72);
            this.BtnAyarlar.TabIndex = 0;
            this.BtnAyarlar.Text = "Ayarlar";
            this.BtnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 590);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "İstatistik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(29, 24);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(30, 35);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "-";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(641, 24);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(30, 35);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "x";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // SinavSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(693, 696);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAyarlar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.rdbSecenek1);
            this.Controls.Add(this.rdbSecenek2);
            this.Controls.Add(this.rdbSecenek3);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.lblDogruSayac);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SinavSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Testi";
            this.Load += new System.EventHandler(this.SinavSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

		}
		private Button BtnAyarlar;
		private Button button1;
		private Button btnGeri;
		private Button btnCikis;
	}
}
