using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZueKelime;

namespace ZueKelime
{

    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        //yeni sifreyi olusturacak islemleri yapar
        private string yeniSifreOlustur(int uzunluk = 8)
        {
            try
            {
                const string harfler = "abcçdefgğhıijklmnoöprsştuüyzABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜYZ0123456789";
                Random random = new Random();//ustteki harflerden rastgele secim yapabilmek icin random fonksiyonunu kullanacagiz

                char[] kelime = new char[uzunluk]; //sifreyi depolayacagim dizi

                //for dongusu ile istenilen uzunlukta kelime(sifre) olusturma
                for (int baslangic = 0; baslangic < uzunluk; baslangic++)
                    kelime[baslangic] = harfler[random.Next(harfler.Length)];

                return new string(kelime); //dizideki her bir karakteri birlestirip yeni bir string olusturur
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
                return null;
            }
        }

        private bool sifreGuncelle(string eMail, string hashliYeniSifre)
        {
            //kullanacagimiz veritabani baglantisi
            string baglantiMetni = "Data Source=LAPTOP-1V27LL1R;Initial Catalog=ZueDil;Integrated Security=True";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    string query = "UPDATE tblKullanici SET sifre = @sifre WHERE email = @email"; //yeni sifreyi guncelliyoruz

                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        //degerleri sorguya ekliyorum
                        komut.Parameters.Add("@sifre", SqlDbType.NVarChar, 50).Value = hashliYeniSifre;
                        komut.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = eMail;

                        int eklenenSatir = komut.ExecuteNonQuery(); //eslesen kayıt sayısını buluyor

                        return eklenenSatir > 0; //eslesen kayıt sayısı 0 dan buyukse true donduruyor degilse false
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
                return false;
            }
        }

        private bool eMailKayitliMi(string eMail)
        {
            //kullanacagimiz veritabani baglantisi
            string baglantiMetni = "Data Source=LAPTOP-1V27LL1R;Initial Catalog=ZueDil;Integrated Security=True";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
                {
                    baglanti.Open();

                    //eslesme kontorolunu yapiyor
                    string query = "SELECT COUNT(*) FROM tblKullanici WHERE email = @email";

                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        //degerlerimi sorguya ekliyorum
                        komut.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = eMail;

                        int kullanici = (int)komut.ExecuteScalar(); //eslesen kayit sayisini buluyor

                        return kullanici > 0; //eslesen kayit sayisina gore true/false donduruyor
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
                return false;
            }
        }

        private bool mailGonderme(string yeniSifre, string email)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587; //port numaramız
                string smtpUser = "zueproje@gmail.com"; //mesaji gonderecek eMail
                string smtpPass = "ehws knlc mobj zbka";

                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient(); //smtp basit mail gonderici aciyoruz

                mail.From = new MailAddress(smtpUser); //mailin kimden gelecegini alir
                mail.To.Add(txtEmail.Text); //mail kime gidecek
                mail.Subject = "Yeni sifreniz"; //konusu
                mail.Body = $"Kullanabileceginiz yeni gecici sifreniz: {yeniSifre}\n Güvenliginiz için şifrenizi kimseyle paylaşmayınız"; //mesaj içerigi

                smtpClient.Host = smtpServer;
                smtpClient.Port = smtpPort;
                smtpClient.Credentials = new NetworkCredential(smtpUser, smtpPass); //kimlik dogrulama yapar
                smtpClient.EnableSsl = true; //guvenlik sertifikasını istiyor ssl kullaniyoruz

                smtpClient.Send(mail); //mail gonderir
                MessageBox.Show("E-Mailinize yeni şifreniz gönderildi.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu tekrar deneyiniz!", ex.Message);
                return false;
            }
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            try
            {
                string eMail = txtEmail.Text.Trim();

                //girilen mailin bos veya null olup olmadigini kontrol ediyor
                if (string.IsNullOrEmpty(eMail))
                {
                    MessageBox.Show("E-Mail kısımını boş bırakmayınız!");
                    return;
                }

                //mail kayitli mi kontrol eder
                if (!eMailKayitliMi(eMail))
                {
                    MessageBox.Show("Bu E-Mail adresi kayıtlı değildir!");
                    return;
                }

                string yeniSifre = yeniSifreOlustur(); //yeni sifreyi olusturur
                string hasliYeniSifre = SifreHelper.sifreHash(yeniSifre); //yeni sifreyi hashler
                bool islemBasarili = sifreGuncelle(eMail, hasliYeniSifre); //islemi basarili mi kontrol eder ve deger dondurur

                //islemin basarili olup olmamasına gore baska islemler gerceklestirir
                if (islemBasarili)
                {
                    bool mailGonderildi = mailGonderme(yeniSifre, eMail); //islem basariliysa mail gonderir

                    if (mailGonderildi)
                        MessageBox.Show("Yani şifreniz E-Mail adresinize gönderildi.");
                    else
                        MessageBox.Show("Mail gönderilemedi.");
                }
                else
                    MessageBox.Show("Şifre güncellenemedi tekrar deneyiniz.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluşru tekrar deneyiniz!", ex.Message);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            KullaniciGiris giris = new KullaniciGiris();
            giris.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}