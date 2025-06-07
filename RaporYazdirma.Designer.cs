namespace ZueKelime
{
	partial class RaporYazdirma
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.grafikCubuk = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartYuzdelik = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnYazdir = new System.Windows.Forms.Button();
			this.btnGeri = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grafikCubuk)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartYuzdelik)).BeginInit();
			this.SuspendLayout();
			// 
			// grafikCubuk
			// 
			chartArea1.Name = "ChartArea1";
			this.grafikCubuk.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.grafikCubuk.Legends.Add(legend1);
			this.grafikCubuk.Location = new System.Drawing.Point(46, 80);
			this.grafikCubuk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.grafikCubuk.Name = "grafikCubuk";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series1.Legend = "Legend1";
			series1.Name = "Adım Oranı";
			this.grafikCubuk.Series.Add(series1);
			this.grafikCubuk.Size = new System.Drawing.Size(553, 276);
			this.grafikCubuk.TabIndex = 1;
			this.grafikCubuk.Text = "chart1";
			this.grafikCubuk.Click += new System.EventHandler(this.grafikCubuk_Click);
			// 
			// chartYuzdelik
			// 
			chartArea2.Name = "ChartArea1";
			this.chartYuzdelik.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartYuzdelik.Legends.Add(legend2);
			this.chartYuzdelik.Location = new System.Drawing.Point(46, 360);
			this.chartYuzdelik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chartYuzdelik.Name = "chartYuzdelik";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartYuzdelik.Series.Add(series2);
			this.chartYuzdelik.Size = new System.Drawing.Size(616, 224);
			this.chartYuzdelik.TabIndex = 2;
			this.chartYuzdelik.Text = "chart1";
			this.chartYuzdelik.Click += new System.EventHandler(this.chartYuzdelik_Click);
			// 
			// btnYazdir
			// 
			this.btnYazdir.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnYazdir.Font = new System.Drawing.Font("Sans Serif Collection", 7.999999F, System.Drawing.FontStyle.Bold);
			this.btnYazdir.Location = new System.Drawing.Point(26, 716);
			this.btnYazdir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnYazdir.Name = "btnYazdir";
			this.btnYazdir.Size = new System.Drawing.Size(636, 50);
			this.btnYazdir.TabIndex = 3;
			this.btnYazdir.Text = "YAZDIR";
			this.btnYazdir.UseVisualStyleBackColor = false;
			this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
			// 
			// btnGeri
			// 
			this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGeri.Location = new System.Drawing.Point(34, 28);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(30, 35);
			this.btnGeri.TabIndex = 4;
			this.btnGeri.Text = "-";
			this.btnGeri.UseVisualStyleBackColor = true;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCikis.Location = new System.Drawing.Point(613, 28);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(30, 35);
			this.btnCikis.TabIndex = 5;
			this.btnCikis.Text = "x";
			this.btnCikis.UseVisualStyleBackColor = true;
			this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
			// 
			// RaporYazdirma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(674, 796);
			this.Controls.Add(this.btnCikis);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.btnYazdir);
			this.Controls.Add(this.chartYuzdelik);
			this.Controls.Add(this.grafikCubuk);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "RaporYazdirma";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rapor";
			this.Load += new System.EventHandler(this.RaporYazdirma_Load);
			((System.ComponentModel.ISupportInitialize)(this.grafikCubuk)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartYuzdelik)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataVisualization.Charting.Chart grafikCubuk;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartYuzdelik;
		private System.Windows.Forms.Button btnYazdir;
		private System.Windows.Forms.Button btnGeri;
		private System.Windows.Forms.Button btnCikis;
	}
}