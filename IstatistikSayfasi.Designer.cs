
using System.Windows.Forms;


namespace ZueKelime
{
	partial class IstatistikSayfasi : Form	
	{
		private System.ComponentModel.IContainer components = null;


		private System.Windows.Forms.Label lblToplam;
		private System.Windows.Forms.Label lblOgrenilen;
		private System.Windows.Forms.Label lblAdim0;
		private System.Windows.Forms.Label lblAdim1;
		private System.Windows.Forms.Label lblAdim2;
		private System.Windows.Forms.Label lblAdim3;
		private System.Windows.Forms.Label lblAdim4;
		private System.Windows.Forms.Label lblAdim5;
		private System.Windows.Forms.Label lblAdim6;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}


		private void InitializeComponent()
		{
			this.lblToplam = new System.Windows.Forms.Label();
			this.lblOgrenilen = new System.Windows.Forms.Label();
			this.lblAdim0 = new System.Windows.Forms.Label();
			this.lblAdim1 = new System.Windows.Forms.Label();
			this.lblAdim2 = new System.Windows.Forms.Label();
			this.lblAdim3 = new System.Windows.Forms.Label();
			this.lblAdim4 = new System.Windows.Forms.Label();
			this.lblAdim5 = new System.Windows.Forms.Label();
			this.lblAdim6 = new System.Windows.Forms.Label();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblToplam
			// 
			this.lblToplam.AutoSize = true;
			this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lblToplam.Location = new System.Drawing.Point(180, 117);
			this.lblToplam.Name = "lblToplam";
			this.lblToplam.Size = new System.Drawing.Size(144, 28);
			this.lblToplam.TabIndex = 0;
			this.lblToplam.Text = "Toplam Kelime:";
			// 
			// lblOgrenilen
			// 
			this.lblOgrenilen.AutoSize = true;
			this.lblOgrenilen.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lblOgrenilen.Location = new System.Drawing.Point(169, 147);
			this.lblOgrenilen.Name = "lblOgrenilen";
			this.lblOgrenilen.Size = new System.Drawing.Size(166, 28);
			this.lblOgrenilen.TabIndex = 1;
			this.lblOgrenilen.Text = "Öğrenilen Kelime:";
			// 
			// lblAdim0
			// 
			this.lblAdim0.AutoSize = true;
			this.lblAdim0.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim0.Location = new System.Drawing.Point(219, 185);
			this.lblAdim0.Name = "lblAdim0";
			this.lblAdim0.Size = new System.Drawing.Size(68, 23);
			this.lblAdim0.TabIndex = 2;
			this.lblAdim0.Text = "Adım 0:";
			// 
			// lblAdim1
			// 
			this.lblAdim1.AutoSize = true;
			this.lblAdim1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim1.Location = new System.Drawing.Point(219, 215);
			this.lblAdim1.Name = "lblAdim1";
			this.lblAdim1.Size = new System.Drawing.Size(68, 23);
			this.lblAdim1.TabIndex = 3;
			this.lblAdim1.Text = "Adım 1:";
			// 
			// lblAdim2
			// 
			this.lblAdim2.AutoSize = true;
			this.lblAdim2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim2.Location = new System.Drawing.Point(219, 245);
			this.lblAdim2.Name = "lblAdim2";
			this.lblAdim2.Size = new System.Drawing.Size(68, 23);
			this.lblAdim2.TabIndex = 4;
			this.lblAdim2.Text = "Adım 2:";
			// 
			// lblAdim3
			// 
			this.lblAdim3.AutoSize = true;
			this.lblAdim3.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim3.Location = new System.Drawing.Point(219, 275);
			this.lblAdim3.Name = "lblAdim3";
			this.lblAdim3.Size = new System.Drawing.Size(68, 23);
			this.lblAdim3.TabIndex = 5;
			this.lblAdim3.Text = "Adım 3:";
			// 
			// lblAdim4
			// 
			this.lblAdim4.AutoSize = true;
			this.lblAdim4.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim4.Location = new System.Drawing.Point(219, 305);
			this.lblAdim4.Name = "lblAdim4";
			this.lblAdim4.Size = new System.Drawing.Size(68, 23);
			this.lblAdim4.TabIndex = 6;
			this.lblAdim4.Text = "Adım 4:";
			// 
			// lblAdim5
			// 
			this.lblAdim5.AutoSize = true;
			this.lblAdim5.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim5.Location = new System.Drawing.Point(219, 335);
			this.lblAdim5.Name = "lblAdim5";
			this.lblAdim5.Size = new System.Drawing.Size(68, 23);
			this.lblAdim5.TabIndex = 7;
			this.lblAdim5.Text = "Adım 5:";
			// 
			// lblAdim6
			// 
			this.lblAdim6.AutoSize = true;
			this.lblAdim6.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblAdim6.Location = new System.Drawing.Point(219, 365);
			this.lblAdim6.Name = "lblAdim6";
			this.lblAdim6.Size = new System.Drawing.Size(68, 23);
			this.lblAdim6.TabIndex = 8;
			this.lblAdim6.Text = "Adım 6:";
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(34, 32);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(30, 35);
			this.btnGeri.TabIndex = 9;
			this.btnGeri.Text = "-";
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(456, 32);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 10;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// IstatistikSayfasi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(519, 468);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.lblToplam);
			this.Controls.Add(this.lblOgrenilen);
			this.Controls.Add(this.lblAdim0);
			this.Controls.Add(this.lblAdim1);
			this.Controls.Add(this.lblAdim2);
			this.Controls.Add(this.lblAdim3);
			this.Controls.Add(this.lblAdim4);
			this.Controls.Add(this.lblAdim5);
			this.Controls.Add(this.lblAdim6);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "IstatistikSayfasi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "İstatistikler";
			this.Load += new System.EventHandler(this.IstatistikSayfasi_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private Button btnGeri;
		private Button btnCikis;
	}
}
