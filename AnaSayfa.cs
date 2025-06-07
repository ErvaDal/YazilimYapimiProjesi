using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZueKelime
{
	public partial class AnaSayfa : Form
	{
		private object eklemeFormu;

		public AnaSayfa()
		{
			InitializeComponent();
		}

		private void AnaSayfa_Load(object sender, EventArgs e)
		{

			//Resmin dosya yolu
			string resimYolu = @"C:\Users\USer\Pictures\Screenshots\Ekran görüntüsü 2025-05-15 110328.png";
			resim1.Image = Image.FromFile(resimYolu);
			resim1.SizeMode = PictureBoxSizeMode.StretchImage; // Resmi kutuya sığdırmak için
		}


		//Kelime Öğrenme sayfasını açan buton
		private void kelimeOgren_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide(); // AnaSayfa formu gizlenir
				KelimeOgrenme ogrenmeFormu = new KelimeOgrenme();
				ogrenmeFormu.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
			}
		}

		//Kelime Ekleme sayfasını açan buton
		private void kelimeEkle_Click(object sender, EventArgs e)
		{
			try
			{
				this.Hide(); // Form1'i gizle
				KelimeEkleme eklemeFormu = new KelimeEkleme();
				eklemeFormu.Show();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata oluştu: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
			}
		}

		//Sınav savfasını açan buton
		private void sinav_Click(object sender, EventArgs e)
		{
			this.Hide();
			SinavSayfasi sinav = new SinavSayfasi();
			sinav.Show();
			
		}

		//Rapor sayfasını açan buton
		private void rapor_Click(object sender, EventArgs e)
		{
			this.Hide();
			RaporYazdirma rapor = new RaporYazdirma();
			rapor.Show();
		}

		//Wordle sayfasını açan buton
		private void wordle_Click(object sender, EventArgs e)
		{
			this.Hide();
			Wordle wordle = new Wordle();
			wordle.Show();
		}
	}
}
