using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZueKelime
{
    public partial class KullaniciGiris : Form
    {

        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void KullaniciGiris_Load(object sender, EventArgs e)
        {

        }


        //giris butonuna bastiginda calisir
        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciVeyaMail = txtKullaniciVeyaMail.Text.Trim();
                string sifre = txtSifre.Text.Trim();

                if (string.IsNullOrEmpty(kullaniciVeyaMail) || string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Lütfen E-mail/kullanıcı adı ve şifreyi giriniz!");
                    return;
                }

                int kullaniciID = giris(kullaniciVeyaMail, sifre);

                if (kullaniciID > 0)
                {
                    OturumBilgisi.AktifKullaniciID = kullaniciID;
                    MessageBox.Show("Giriş başarılı.");
                    this.Hide();
                    //AnaSayfa anasayfa = new AnaSayfa();
                    //anasayfa.Show();
                }
                else
                {
                    MessageBox.Show("E-mail/ kullanıcı adı veya şifre hatalı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
            }
        }


        //giris dogrulamasını yapar
        private int giris(string kullaniciVeyaMail, string sifre)
        {
            string baglantiMetni = "Data Source=LAPTOP-1V27LL1R;Initial Catalog=ZueDil;Integrated Security=True";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    string query = @"
				SELECT kullaniciID 
				FROM tblKullanici 
				WHERE (kullaniciAdi = @kullaniciVeyaMail OR email = @kullaniciVeyaMail) 
				AND sifre = @sifre";

                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        komut.Parameters.Add("@kullaniciVeyaMail", SqlDbType.NVarChar, 50).Value = kullaniciVeyaMail;
                        komut.Parameters.Add("@sifre", SqlDbType.NVarChar, 50).Value = SifreHelper.sifreHash(sifre);

                        object sonuc = komut.ExecuteScalar();

                        if (sonuc != null && sonuc != DBNull.Value)
                            return Convert.ToInt32(sonuc);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken hata oluştu:\n" + ex.Message);
            }

            return -1;
        }


        //kayit butonuna bastiginda calisir
        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); //ana formu gizliyor

                using (KayitOl kayıtOl = new KayitOl()) //kayit formu acıyor
                    kayıtOl.ShowDialog();//actigi formu gosteriyor

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
            }
        }

        //sifremi unuttuma bastigimda calisir
        private void lnkSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide(); //ana formu gizliyor

                using (SifremiUnuttum sifremiUnuttum = new SifremiUnuttum())//sifremi unuttum formunu aciyor
                    sifremiUnuttum.ShowDialog();//actigi formu gosteriyor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
            }
        }
    }

    public static class OturumBilgisi
    {
        public static int AktifKullaniciID { get; set; }
    }
}

