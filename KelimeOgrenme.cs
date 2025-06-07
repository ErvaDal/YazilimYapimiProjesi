
using ImageMagick;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace ZueKelime

{

	public partial class KelimeOgrenme : Form
	{
		private List<KelimeSayfasi> sayfalar = new List<KelimeSayfasi>();
		private int aktifSayfa = 0;
		private Label lblSayfaSayisi = new Label();


		public KelimeOgrenme()
		{
			InitializeComponent();
			this.Load += KelimeOgrenme_Load;
			ileriButonu.Click += ileriButonu_Click;
			geriButonu.Click += geriButonu_Click;
		}

		public class KelimeSayfasi
		{
			public string ingKelime { get; set; }
			public string turKelime { get; set; }
			public string resimYolu { get; set; }
			public List<string> ingOrnekler { get; set; } = new List<string>();
			public List<string> turOrnekler { get; set; } = new List<string>();
		}


		//Form açıldığında oluşacak olaylar
		private void KelimeOgrenme_Load(object sender, EventArgs e)
		{
			VerileriYukle();
			SayfaGoster();
			lblSayfaSayisi.Font = new Font("Calibri", 12, FontStyle.Regular);
			lblSayfaSayisi.ForeColor = Color.Black;
			lblSayfaSayisi.AutoSize = true;
			lblSayfaSayisi.Location = new Point((this.ClientSize.Width - 100) / 2, this.ClientSize.Height - 50); // Alt ortada
			this.Controls.Add(lblSayfaSayisi);
			try
			{
				VerileriYukle();
				SayfaGoster();
			}
			catch (Exception ex)
			{
				MessageBox.Show("KelimeOgrenme_Load içinde hata: " + ex.Message);
			}
		}


		//Verilerimi veritabanından çektiğim kod bloğu
		private void VerileriYukle()
		{
			string connStr = "Server=LAPTOP-QCSD0KI9\\ZEREN;Database=ZueKelime;Trusted_Connection=True;";
			string query = @"
			SELECT 
			k.kelimeID, 
			k.ingKelime, 
			k.turKelime, 
			o.ingKelimeOrnegi, 
			o.turKelimeOrnegi, 
			r.yol
			FROM kelimeler k
			LEFT JOIN kelimeOrnekleri o ON k.kelimeID = o.kelimeID
			LEFT JOIN resim r ON k.resimID = r.resimID
            ORDER BY k.kelimeID;

			";

			using (SqlConnection conn = new SqlConnection(connStr))
			using (SqlCommand cmd = new SqlCommand(query, conn))
			{
				conn.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				Dictionary<string, KelimeSayfasi> kelimeDict = new Dictionary<string, KelimeSayfasi>();

				while (reader.Read())
				{
					string key = reader["ingKelime"]?.ToString(); // benzersiz anahtar olarak
					if (!kelimeDict.ContainsKey(key))
					{
						kelimeDict[key] = new KelimeSayfasi
						{
							ingKelime = reader["ingKelime"]?.ToString(),
							turKelime = reader["turKelime"]?.ToString(),
							resimYolu = reader["yol"]?.ToString()
						};
					}

					string ingOrnek = reader["ingKelimeOrnegi"]?.ToString();
					string turOrnek = reader["turKelimeOrnegi"]?.ToString();

					if (!string.IsNullOrEmpty(ingOrnek))
						kelimeDict[key].ingOrnekler.Add(ingOrnek);

					if (!string.IsNullOrEmpty(turOrnek))
						kelimeDict[key].turOrnekler.Add(turOrnek);
				}

				sayfalar = new List<KelimeSayfasi>(kelimeDict.Values);
			}
		}


		//İleri-geri butonlarıyla açılan yeni sayfların doğru şekilde gelmesini sağlayan kod bloğu
		private void SayfaGoster()
		{
			if (sayfalar.Count == 0) return;

			panel1.Controls.Clear();
			var kelime = sayfalar[aktifSayfa];

			//Yeni sayfa için kelimeleri açan kod bloğu
			Label lblKelime = new Label()
			{
				Text = $" {kelime.ingKelime} - {kelime.turKelime}",
				Font = new Font("Calibri", 28, FontStyle.Bold),
				ForeColor = Color.Maroon,
				AutoSize = true,
				//Location = new Point(70, 0)
			};

			this.Controls.Add(lblKelime);

			// Layout güncellenmeden genişlik doğru hesaplanmayabilir.
			this.PerformLayout();

			// Şimdi ortala
			lblKelime.Location = new Point((this.ClientSize.Width - lblKelime.Width) / 5, 0);

			// Form yeniden boyutlandığında da ortalansın
			this.Resize += (s, ev) =>
			{
				lblKelime.Location = new Point((this.ClientSize.Width - lblKelime.Width) / 5, 0);
			};

			//Yeni sayfa için örnek İngilizce Türkçe cümleleri açan kod bloğu
			string ornekText = "";
			for (int i = 0; i < kelime.ingOrnekler.Count; i++)
			{
				string ing = kelime.ingOrnekler[i];
				string tur = i < kelime.turOrnekler.Count ? kelime.turOrnekler[i] : "";
				ornekText += $"EN: {ing}\nTR: {tur}\n\n";
			}

			Label lblOrnek = new Label()
			{
				Text = ornekText.Trim(),
				Font = new Font("Calibri", 14),
				ForeColor = Color.Black,
				AutoSize = true,
				MaximumSize = new Size(400, 0),
				Location = new Point(5, 300)
			};

			resim1.Image = null; // Eski resmi temizle (isteğe bağlı)
			resim1.SizeMode = PictureBoxSizeMode.CenterImage;


			//Yeni sayfa için kullanılacak resmi açan kod bloğu
			if (!string.IsNullOrEmpty(kelime.resimYolu) && File.Exists(kelime.resimYolu))
			{
				try
				{
					using (var magickImage = new MagickImage(kelime.resimYolu))
					using (var ms = new MemoryStream())
					{
						magickImage.Format = MagickFormat.Bmp;
						magickImage.Write(ms);
						ms.Position = 0;

						using (Image originalImage = new Bitmap(ms))
						{

							resim1.Image = ResizeImageKeepingAspectRatio(originalImage, resim1.Width, resim1.Height);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Resim görüntülenirken hata oluştu: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Dosya bulunamadı: " + kelime.resimYolu);
			}


			panel1.Controls.Add(lblKelime);
			panel1.Controls.Add(lblOrnek);
			panel1.Controls.Add(resim1);

			lblSayfaSayisi.Text = $"Sayfa {aktifSayfa + 1} / {sayfalar.Count}";
			lblSayfaSayisi.Location = new Point((this.ClientSize.Width - lblSayfaSayisi.Width) / 2, this.ClientSize.Height - 50);
		}



		//Sayfa değiştirmek için kullandığım butonlar.
		private void ileriButonu_Click(object sender, EventArgs e)
		{
			if (aktifSayfa < sayfalar.Count - 1)
			{
				aktifSayfa++;
				SayfaGoster();
			}
		}

		private void geriButonu_Click(object sender, EventArgs e)
		{
			if (aktifSayfa > 0)
			{
				aktifSayfa--;
				SayfaGoster();
			}
		}

		//Bellek hatasını ortadan kaldırmak için kullandığım kod bloğu
		private Image ResizeImageKeepingAspectRatio(Image image, int maxWidth, int maxHeight)
		{

			int originalWidth = image.Width;
			int originalHeight = image.Height;

			float ratioX = (float)maxWidth / originalWidth;
			float ratioY = (float)maxHeight / originalHeight;
			float ratio = Math.Min(ratioX, ratioY);

			int newWidth = (int)(originalWidth * ratio);
			int newHeight = (int)(originalHeight * ratio);

			Bitmap newImage = new Bitmap(newWidth, newHeight);
			using (Graphics graphics = Graphics.FromImage(newImage))
			{


				graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
				graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

				graphics.DrawImage(image, 0, 0, newWidth, newHeight);
			}

			return newImage;
		}

		//Anasayfaya geri dönmeyi sağlar
		private void btnGeri_Click(object sender, EventArgs e)
		{

			AnaSayfa anasayfa = new AnaSayfa();
			anasayfa.Show();
			this.Close(); 
		}

		private void btnCikis_Click(object sender, EventArgs e)
		{

			Application.Exit(); // Uygulamayı tamamen kapat
		}

		private void ileriButonu_Click_1(object sender, EventArgs e)
		{

		}
	}
}
