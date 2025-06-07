using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace ZueKelime
{
	public partial class RaporYazdirma : Form
	{
		//kullanacagimiz veritabani baglantisi
		string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=ZueKelime;Integrated Security=True";

		//rapor yazdirmak icin nesne ve form goruntusunu tutması icin bitmap
		private PrintDocument printDocument = new PrintDocument();
		private Bitmap charBitmap;
		public RaporYazdirma()
		{
			InitializeComponent();

			//grafik olusturma metodlarini cagiriyorum
			cubukGrafik();
			daireGrafik();

			//yazdirma eventlerini ekliyorum yazdirabilmek icin
			printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
		}

		//yazdırma isleminde formun goruntusunu yazdirmak icin cagirilir
		private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			//formun goruntusunu yaziciya gonderir
			e.Graphics.DrawImage(charBitmap, e.MarginBounds);
		}

		//cubuk grafik olusturur. Bilme adımlarına gore kelime sayisini gosterir
		private void cubukGrafik()
		{
			try
			{
				//grafik ayarlarini sifirla
				grafikCubuk.Series.Clear();
				grafikCubuk.Titles.Clear();
				grafikCubuk.ChartAreas.Clear();

				//yeni grafik alani olusturur ve ekler
				ChartArea area = new ChartArea();
				grafikCubuk.ChartAreas.Add(area);

				//yeni veri kumesi olusturur
				Series seri = new Series("Bilinme Durumuna\n Göre Kelimle Sayısı")
				{
					ChartType = SeriesChartType.Bar, //grafik tipi
					IsValueShownAsLabel = true, //degeri grafik ustunde gosterir
				};

				//veritabanı baglantısını olusturur
				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open(); //baglantiyi acar

					//istenilen 6 li dongu icin dongu
					for (int adim = 0; adim <= 6; adim++)
					{
						int kelimeSayisi = 0;

						//adım icin kelime sayisini ceker
						string adimQuey = "SELECT COUNT(*) FROM KullaniciKelimeleri KK" +
							"				WHERE Adim = @adim AND kullaniciID = @kullaniciID";
						using (SqlCommand komut = new SqlCommand(adimQuey, baglanti))
						{
							//degerleri sorguya ekliyorum
							komut.Parameters.AddWithValue("@adim", adim);
							komut.Parameters.AddWithValue("@kullaniciID", OturumBilgisi.AktifKullaniciID);
							kelimeSayisi = (int)komut.ExecuteScalar();
						}

						//seriye veri noktası olarak ekliyorum
						seri.Points.AddXY($"{adim} kere bilinen", kelimeSayisi);
					}
				}

				//seriyi grafik olarak ekliyorum
				grafikCubuk.Series.Add(seri);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}

		//daire grafigi olusturur. Yuzdelik dagilimi verir
		private void daireGrafik()
		{
			try
			{
				// Var olan her şeyi temizle
				chartYuzdelik.Series.Clear();
				chartYuzdelik.Titles.Clear();
				chartYuzdelik.ChartAreas.Clear();

				// Grafik başlığı
				chartYuzdelik.Titles.Add("Bilme Durumuna Göre\nYüzdelik Dağılım");

				// Grafik alanı ayarı
				ChartArea area = new ChartArea();
				area.Position = new ElementPosition(0, 0, 100, 100);
				area.BackColor = Color.Transparent;
				chartYuzdelik.ChartAreas.Add(area);

				// Seri ayarı
				Series seri = new Series
				{
					ChartType = SeriesChartType.Pie,
					IsValueShownAsLabel = true,
					LabelForeColor = Color.Black,
					Font = new Font("Arial", 10, FontStyle.Bold),
					["PieLabelStyle"] = "Outside", // Etiketleri dışarı taşı
					["PieLineColor"] = "Black" // Etiketleri bağlayan çizgiler
				};

				int toplamKelime = 0;

				using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
				{
					baglanti.Open();

					string topKelimeQuery = "SELECT COUNT(*) FROM KullaniciKelimeleri WHERE kullaniciID = @kullaniciID";
					using (SqlCommand komut = new SqlCommand(topKelimeQuery, baglanti))
					{
						komut.Parameters.AddWithValue("@kullaniciID", OturumBilgisi.AktifKullaniciID);
						toplamKelime = (int)komut.ExecuteScalar();
					}

					if (toplamKelime == 0)
					{
						MessageBox.Show("Kelime yok.");
						return;
					}

					for (int adim = 0; adim <= 6; adim++)
					{
						int kelimeSayisi = 0;
						string adimQuery = "SELECT COUNT(*) FROM KullaniciKelimeleri WHERE Adim = @adim AND kullaniciID = @kullaniciID";
						using (SqlCommand komut = new SqlCommand(adimQuery, baglanti))
						{
							komut.Parameters.AddWithValue("@adim", adim);
							komut.Parameters.AddWithValue("@kullaniciID", OturumBilgisi.AktifKullaniciID);
							kelimeSayisi = (int)komut.ExecuteScalar();
						}

						if (kelimeSayisi > 0)
						{
							double yuzde = (double)kelimeSayisi / toplamKelime;
							DataPoint point = new DataPoint(0, kelimeSayisi)
							{
								Label = $"{adim} kere\n{yuzde:P1}",
								LegendText = $"{adim} kere bilinen"
							};
							seri.Points.Add(point);
						}
					}
				}

				// Seriyi ekle
				chartYuzdelik.Series.Add(seri);

				// Grafik boyutu ve konumu (isteğe göre ayarla)
				chartYuzdelik.Size = new Size(420, 300);
				//chartYuzdelik.Location = new Point450, 100); // Formda konum (örnek)
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu tekrar deneyiniz.", ex.Message);
			}
		}


		private void chartYuzdelik_Click(object sender, EventArgs e)
		{

		}

		//yazdir butonuna bastiginda formun goruntusunu alip yazdirir
		private void btnYazdir_Click(object sender, EventArgs e)
		{
			//formun tamaminin ekran goruntusunu alır
			charBitmap = new Bitmap(this.Width, this.Height);
			this.DrawToBitmap(charBitmap, new Rectangle(0, 0, this.Width, this.Height));

			//yazdirma iletisim kutusunu gosterir
			PrintDialog printDialog = new PrintDialog();
			printDialog.Document = printDocument;

			//kullanici yazdirmayi anaylarsa islemi baslatir
			if (printDialog.ShowDialog() == DialogResult.OK)
				printDocument.Print();
		}

		private void btnGeri_Click(object sender, EventArgs e)
		{
			AnaSayfa anasayfa = new AnaSayfa();
			anasayfa.Show();
			this.Close();
		}

		private void btnCikis_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void RaporYazdirma_Load(object sender, EventArgs e)
		{

		}

		private void grafikCubuk_Click(object sender, EventArgs e)
		{

		}
	}
}
