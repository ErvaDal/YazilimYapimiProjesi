using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZueKelime
{
	public partial class KelimeEkleme : Form
	{
		//Veritabanı bağlantısını bir değişkene atadım
		string connectionString = "Server = LAPTOP-QCSD0KI9\\ZEREN; Database = ZueKelime; Trusted_Connection = True;";
		string secilenResimYolu = "";

		public KelimeEkleme()
		{
			InitializeComponent();
		}

		private void KelimeEkleme_Load(object sender, EventArgs e)
		{
			// Form yüklendiğinde yapılacak işlemler
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

		//Eklenecek yeni kelimenin görselini bilgisayardaki dosyalardan çeken kod bloğu
		private void btnResimSec_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.webp;*.avif";


			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				secilenResimYolu = openFileDialog.FileName;

				try
				{
					using (var magickImage = new MagickImage(secilenResimYolu))
					using (var ms = new MemoryStream())
					{
						magickImage.Format = MagickFormat.Bmp;
						magickImage.Write(ms);
						ms.Position = 0;

						using (Image originalImage = Image.FromStream(ms))
						{
							pictureBoxResim.Image = ResizeImageKeepingAspectRatio(originalImage, pictureBoxResim.Width, pictureBoxResim.Height);
							pictureBoxResim.SizeMode = PictureBoxSizeMode.CenterImage;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Resim yüklenirken hata oluştu: " + ex.Message);
				}
			}
		}


		//Kelime ve cümleler yazıldıktan sonra veritabanına kaydedecek kod bloğu.
		private void btnEkle_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtIngilizce.Text) || string.IsNullOrWhiteSpace(txtTurkce.Text))
			{
				MessageBox.Show("Lütfen İngilizce ve Türkçe kelimeleri giriniz.");
				return;
			}

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					conn.Open();

					// 1. Resmi ekle (varsa)
					int resimID = -1;
					if (!string.IsNullOrEmpty(secilenResimYolu))
					{
						string resimQuery = "INSERT INTO resim (ad, yol) OUTPUT INSERTED.resimID VALUES (@ad, @yol)";
						using (SqlCommand cmdResim = new SqlCommand(resimQuery, conn))
						{
							cmdResim.Parameters.AddWithValue("@ad", Path.GetFileName(secilenResimYolu));
							cmdResim.Parameters.AddWithValue("@yol", secilenResimYolu);
							resimID = Convert.ToInt32(cmdResim.ExecuteScalar());
						}
					}

					// 2. Kelimeyi ekle
					string kelimeQuery = "INSERT INTO kelimeler (ingKelime, turKelime, resimID) OUTPUT INSERTED.kelimeID VALUES (@ing, @tur, @resim)";
					int kelimeID = -1;
					using (SqlCommand cmdKelime = new SqlCommand(kelimeQuery, conn))
					{
						cmdKelime.Parameters.AddWithValue("@ing", txtIngilizce.Text);
						cmdKelime.Parameters.AddWithValue("@tur", txtTurkce.Text);
						cmdKelime.Parameters.AddWithValue("@resim", resimID == -1 ? DBNull.Value : (object)resimID);
						kelimeID = Convert.ToInt32(cmdKelime.ExecuteScalar());
					}

					// 3. Örnek cümleleri ekle (doluysa)
					void EkleOrnek(string ing, string tur)
					{
						if (!string.IsNullOrWhiteSpace(ing) && !string.IsNullOrWhiteSpace(tur))
						{
							string ornekQuery = "INSERT INTO kelimeOrnekleri (kelimeID, ingKelimeOrnegi, turKelimeOrnegi) VALUES (@kid, @ing, @tur)";
							using (SqlCommand cmdOrnek = new SqlCommand(ornekQuery, conn))
							{
								cmdOrnek.Parameters.AddWithValue("@kid", kelimeID);
								cmdOrnek.Parameters.AddWithValue("@ing", ing);
								cmdOrnek.Parameters.AddWithValue("@tur", tur);
								cmdOrnek.ExecuteNonQuery();
							}
						}
					}

					EkleOrnek(txtIngOrnek1.Text, txtTurOrnek1.Text);
					EkleOrnek(txtIngOrnek2.Text, txtTurOrnek2.Text);

					MessageBox.Show("✅ Kelime ve örnek cümle(ler) başarıyla eklendi.");

					// Temizleme işlemi
					txtIngilizce.Clear();
					txtTurkce.Clear();
					txtIngOrnek1.Clear();
					txtTurOrnek1.Clear();
					txtIngOrnek2.Clear();
					txtTurOrnek2.Clear();
					pictureBoxResim.Image = null;
					secilenResimYolu = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show("❌ Hata oluştu: " + ex.Message);
				}
			}
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
	}
}


