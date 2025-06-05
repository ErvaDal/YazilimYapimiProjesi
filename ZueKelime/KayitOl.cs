using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;



namespace ZueKelime
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }



        //kayit ol butonuna bastigimda calisir
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //kullanacagimiz veritabani baglantisi
            string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=ZueKelime;Integrated Security=True";

            try
            {
                if (kutuBoşMu() || sifreKontrol() || kullaniciMailKontrol()) //kutular bos mu degil mi bakiyor
                    MessageBox.Show("Geçerli şartları sağlamıyor! Kontrol edip tekrar deneyiniz.");
                else
                {
                    using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
                    {
                        baglanti.Open();

                        //yeni kayit ekleme komutları
                        string query = "INSERT INTO tblKullanici (adSoyad, kullaniciAdi, email, sifre) VALUES (@adSoyad, @kullaniciAdi, @email, @sifre)";

                        using (SqlCommand komut = new SqlCommand(query, baglanti))
                        {

                            //degerlerimi sorguya ekliyorum
                            komut.Parameters.Add("@adSoyad", SqlDbType.NVarChar, 50).Value = txtAdSoyad.Text.Trim();
                            komut.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar, 50).Value = txtKullaniciAdi.Text.Trim();
                            komut.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txtEMail.Text.Trim();
                            komut.Parameters.Add("@sifre", SqlDbType.NVarChar, 50).Value = SifreHelper.sifreHash(txtSifre.Text.Trim());

                            int eklenenSatir = komut.ExecuteNonQuery(); //eslesen kayıt sayısını buluyor

                            //eslesen kayit sayisi durumuna gore islem yapiyor
                            if (eklenenSatir > 0)
                                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Kayıt işlemi başarısız oldu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
            }
        }





        //kutunun bos olup olmadıgini kontrol eder
        private bool kutuBoşMu()
        {
            try
            {
                if (txtAdSoyad.Text == "" || txtKullaniciAdi.Text == "" || txtEMail.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
                {
                    MessageBox.Show("Bütün kutuları doldurunuz!");
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu! Tekrar deneyiniz.", ex.Message);
                return true;
            }
        }

        //sifre girme durumunun kosulalrini kontrol eder
        private bool sifreKontrol()
        {
            try
            {
                if (!(txtSifre.Text.Equals(txtSifreTekrar.Text))) //sifre ve sifre tekrarin ayni olup olmadıgini kontrol eder
                {
                    MessageBox.Show("Şifreler aynı değil!");
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu! Tekrar deneyiniz.", ex.Message);
                return true;
            }
        }

        private bool kullaniciMailKontrol() //kullanici adi ve e-mailin onceden var olup olmadigini kontrol ediyor
        {
            //kullanacagimiz veritabani baglantisi
            string baglantiMetni = "Data Source=LAPTOP-QCSD0KI9\\ZEREN;Initial Catalog=ZueKelime;Integrated Security=True";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    //sorgulama islemini yapiyor
                    string query = "SELECT kullaniciAdi, email FROM tblKullanici WHERE kullaniciAdi=@kullaniciAdi OR email=@email";

                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        //degerleri sorguya ekliyor
                        komut.Parameters.Add("@kullaniciAdi", SqlDbType.NVarChar).Value = txtKullaniciAdi.Text;
                        komut.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEMail.Text;

                        //aynı e-mail veya kullanici var mi kontrol eder
                        using (SqlDataReader okuyucu = komut.ExecuteReader())
                        {
                            while (okuyucu.Read())//satirlari okur
                            {
                                string dbKullaniciAdi = okuyucu["kullaniciAdi"]?.ToString();
                                string dbEmail = okuyucu["email"]?.ToString();

                                if (dbKullaniciAdi.Equals(txtKullaniciAdi.Text))//girdigimiz kullanici adi degeriyle veritabanini karsilastirir 
                                    MessageBox.Show("Bu kullanici adı zaten kayıtlı! Lütfen farklı bir kullanıcı adı giriniz.");

                                if (dbEmail.Equals(txtEMail.Text)) //girdigimiz emailin degeriyle veritabanini karsilastirir
                                    MessageBox.Show("Bu E-Mail zaten kayıtlı! Lütfen farklı bir E-Mail giriniz.");

                                return true;
                            }
                        }
                    }
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu! Tekrar deneyiniz.", ex.Message);
                return false;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            KullaniciGiris giris = new KullaniciGiris();
            giris.Show();
            this.Close();
        }


    }

    //sifreleri guvenli hale getirebilmek icin hash sinifi kullanarak hashlerim
    public static class SifreHelper
    {
        public static string sifreHash(string sifre)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(sifre));  //hashi hesaplar ve sifreyi byte dizisine donusturur 
                StringBuilder builder = new StringBuilder();//sonucu icin stringbuilder olusturur

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));//her byt i 2 karakterlik onaltilik formata cevirir

                return builder.ToString();
            }
        }
    }
}