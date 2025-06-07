namespace ZueKelime
{
	partial class AnaSayfa
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
			this.resim1 = new System.Windows.Forms.PictureBox();
			this.giris = new System.Windows.Forms.Label();
			this.kelimeOgren = new System.Windows.Forms.Button();
			this.kelimeEkle = new System.Windows.Forms.Button();
			this.sinav = new System.Windows.Forms.Button();
			this.rapor = new System.Windows.Forms.Button();
			this.wordle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.resim1)).BeginInit();
			this.SuspendLayout();
			// 
			// resim1
			// 
			this.resim1.Location = new System.Drawing.Point(196, 37);
			this.resim1.Name = "resim1";
			this.resim1.Size = new System.Drawing.Size(286, 209);
			this.resim1.TabIndex = 0;
			this.resim1.TabStop = false;
			// 
			// giris
			// 
			this.giris.AutoSize = true;
			this.giris.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.giris.ForeColor = System.Drawing.Color.Indigo;
			this.giris.Location = new System.Drawing.Point(145, 274);
			this.giris.Name = "giris";
			this.giris.Size = new System.Drawing.Size(392, 58);
			this.giris.TabIndex = 1;
			this.giris.Text = "ZUE\'ye Hoşgeldiniz";
			// 
			// kelimeOgren
			// 
			this.kelimeOgren.BackColor = System.Drawing.Color.GhostWhite;
			this.kelimeOgren.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kelimeOgren.ForeColor = System.Drawing.Color.SlateBlue;
			this.kelimeOgren.Location = new System.Drawing.Point(244, 369);
			this.kelimeOgren.Name = "kelimeOgren";
			this.kelimeOgren.Size = new System.Drawing.Size(205, 55);
			this.kelimeOgren.TabIndex = 2;
			this.kelimeOgren.Text = "Kelime Öğren";
			this.kelimeOgren.UseVisualStyleBackColor = false;
			this.kelimeOgren.Click += new System.EventHandler(this.kelimeOgren_Click);
			// 
			// kelimeEkle
			// 
			this.kelimeEkle.BackColor = System.Drawing.Color.GhostWhite;
			this.kelimeEkle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.kelimeEkle.ForeColor = System.Drawing.Color.SlateBlue;
			this.kelimeEkle.Location = new System.Drawing.Point(244, 445);
			this.kelimeEkle.Name = "kelimeEkle";
			this.kelimeEkle.Size = new System.Drawing.Size(205, 55);
			this.kelimeEkle.TabIndex = 3;
			this.kelimeEkle.Text = "Kelime Ekle";
			this.kelimeEkle.UseVisualStyleBackColor = false;
			this.kelimeEkle.Click += new System.EventHandler(this.kelimeEkle_Click);
			// 
			// sinav
			// 
			this.sinav.BackColor = System.Drawing.Color.GhostWhite;
			this.sinav.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.sinav.ForeColor = System.Drawing.Color.SlateBlue;
			this.sinav.Location = new System.Drawing.Point(244, 525);
			this.sinav.Name = "sinav";
			this.sinav.Size = new System.Drawing.Size(205, 55);
			this.sinav.TabIndex = 4;
			this.sinav.Text = "Sınav Ol";
			this.sinav.UseVisualStyleBackColor = false;
			this.sinav.Click += new System.EventHandler(this.sinav_Click);
			// 
			// rapor
			// 
			this.rapor.BackColor = System.Drawing.Color.GhostWhite;
			this.rapor.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rapor.ForeColor = System.Drawing.Color.SlateBlue;
			this.rapor.Location = new System.Drawing.Point(244, 676);
			this.rapor.Name = "rapor";
			this.rapor.Size = new System.Drawing.Size(205, 55);
			this.rapor.TabIndex = 5;
			this.rapor.Text = "Raporunu Gör";
			this.rapor.UseVisualStyleBackColor = false;
			this.rapor.Click += new System.EventHandler(this.rapor_Click);
			// 
			// wordle
			// 
			this.wordle.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.wordle.ForeColor = System.Drawing.Color.SlateBlue;
			this.wordle.Location = new System.Drawing.Point(244, 602);
			this.wordle.Name = "wordle";
			this.wordle.Size = new System.Drawing.Size(205, 55);
			this.wordle.TabIndex = 6;
			this.wordle.Text = "Wordle";
			this.wordle.UseVisualStyleBackColor = true;
			this.wordle.Click += new System.EventHandler(this.wordle_Click);
			// 
			// AnaSayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(692, 753);
			this.Controls.Add(this.wordle);
			this.Controls.Add(this.rapor);
			this.Controls.Add(this.sinav);
			this.Controls.Add(this.kelimeEkle);
			this.Controls.Add(this.kelimeOgren);
			this.Controls.Add(this.giris);
			this.Controls.Add(this.resim1);
			this.Name = "AnaSayfa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.AnaSayfa_Load);
			((System.ComponentModel.ISupportInitialize)(this.resim1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox resim1;
		private System.Windows.Forms.Label giris;
		private System.Windows.Forms.Button kelimeOgren;
		private System.Windows.Forms.Button kelimeEkle;
		private System.Windows.Forms.Button sinav;
		private System.Windows.Forms.Button rapor;
		private System.Windows.Forms.Button wordle;
	}
}

