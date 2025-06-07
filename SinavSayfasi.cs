using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ZueKelime
{
    public partial class SinavSayfasi : Form
    {
        VeritabaniYardimci db = new VeritabaniYardimci(); // Veritabanı işlemleri için yardımcı sınıf
        DataRow guncelKelime; // Şu an gösterilen soru kelimesi
        string dogruSecenek; // Doğru Türkçe karşılık
        int dogruSayisi = 0; // Doğru sayısı
        int aktifKullaniciID; // Giriş yapan kullanıcının ID’si

        int toplamSoruSayisi = 10; // Kullanıcının seçtiği toplam soru sayısı
        int soruSayaci = 0; // Kaçıncı soruda olunduğu

        public SinavSayfasi()
        {
            InitializeComponent(); // Form bileşenlerini başlat
        }

        // Form yüklendiğinde çalışan olay
        private void SinavSayfasi_Load(object sender, EventArgs e)
        {
            try
            {
                aktifKullaniciID = OturumBilgisi.AktifKullaniciID; // Oturumdaki kullanıcıyı al
                SoruSayisiSor(); // Soru sayısını kullanıcıya sor
                YeniSoruYukle(); // İlk soruyu yükle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form yüklenirken hata oluştu:\n\n" + ex.Message);
            }
        }

        // Başlangıçta ya da ayarlardan kaç soru sorulacağını belirleyen fonksiyon
        private void SoruSayisiSor()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Kaç soru çözmek istersiniz? (5 - 20 arası)", "Soru Sayısı", "10");

            if (int.TryParse(input, out int secilen) && secilen >= 5 && secilen <= 20)
                toplamSoruSayisi = secilen;
            else
                MessageBox.Show("Geçersiz giriş! Varsayılan olarak 10 soru gösterilecek.");
        }

        // Ayarlar butonuna basıldığında çalışır – sınavı sıfırlar
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Kaç soru çözmek istersiniz? (5 - 20 arası)", "Soru Sayısı", toplamSoruSayisi.ToString());

            if (int.TryParse(input, out int secilen) && secilen >= 5 && secilen <= 20)
            {
                toplamSoruSayisi = secilen;
                soruSayaci = 0;
                dogruSayisi = 0;
                lblDogruSayac.Text = "Doğru Sayısı: 0";
                YeniSoruYukle(); // Yeni sınav başlatılır
            }
            else
            {
                MessageBox.Show("Geçersiz giriş. Mevcut soru sayısı geçerli kalacaktır.");
            }
        }

        // Yeni bir soru yükleyen fonksiyon
        private void YeniSoruYukle()
        {
            try
            {
                string sql = $@"
                SELECT k.kelimeID, k.ingKelime, k.turKelime, kk.Adim, kk.SonDogruTarihi
                FROM kelimeler k
                LEFT JOIN KullaniciKelimeleri kk
                    ON k.kelimeID = kk.kelimeID AND kk.kullaniciID = {aktifKullaniciID}";

                var kelimeler = db.VeriGetir(sql); // Kelime listesini getir

                if (kelimeler == null || kelimeler.Rows.Count == 0)
                {
                    MessageBox.Show("⚠️ Veritabanında hiç kelime bulunamadı.");
                    return;
                }

                // Spaced repetition sistemine göre adım süreleri (gün cinsinden)
                int[] sureler = { 1, 7, 30, 90, 180, 365 };
                List<DataRow> uygunlar = new List<DataRow>();

                // Tekrar edilmesi gereken kelimeleri bul
                foreach (DataRow kelime in kelimeler.Rows)
                {
                    int adim = kelime["Adim"] != DBNull.Value ? Convert.ToInt32(kelime["Adim"]) : 0;
                    if (adim >= sureler.Length) continue; // Zaten öğrenilmiş

                    DateTime? sonDogru = kelime["SonDogruTarihi"] != DBNull.Value
                        ? Convert.ToDateTime(kelime["SonDogruTarihi"])
                        : (DateTime?)null;

                    DateTime hedefTarih = sonDogru.HasValue
                        ? sonDogru.Value.AddDays(sureler[adim])
                        : DateTime.MinValue;

                    if (adim == 0 || DateTime.Now.Date >= hedefTarih)
                        uygunlar.Add(kelime);
                }

                if (uygunlar.Count == 0)
                {
                    MessageBox.Show("📘 Bugün tekrar edilecek kelime kalmadı.");
                    return;
                }

                // Rastgele bir uygun kelime seç
                var rnd = new Random();
                guncelKelime = uygunlar[rnd.Next(uygunlar.Count)];

                string ingilizce = guncelKelime["ingKelime"].ToString();
                dogruSecenek = guncelKelime["turKelime"].ToString();
                lblKelime.Text = ingilizce; // Soruyu göster

                // Doğru + 2 yanlış şık oluştur
                var secenekler = new List<string> { dogruSecenek };
                var yanlislar = db.VeriGetir($"SELECT TOP 2 turKelime FROM kelimeler WHERE turKelime != '{dogruSecenek}' ORDER BY NEWID()");
                foreach (DataRow satir in yanlislar.Rows)
                    secenekler.Add(satir["turKelime"].ToString());

                // Şıkları karıştır ve butonlara ata
                secenekler = secenekler.OrderBy(s => Guid.NewGuid()).ToList();
                rdbSecenek1.Text = secenekler[0];
                rdbSecenek2.Text = secenekler[1];
                rdbSecenek3.Text = secenekler[2];

                // Seçimler temizlenir
                rdbSecenek1.Checked = false;
                rdbSecenek2.Checked = false;
                rdbSecenek3.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Soru yüklenirken hata oluştu:\n\n" + ex.Message);
            }
        }

        // "Sonraki" butonuna basıldığında
        private void btnSonraki_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen şıkkı al
                string secilen = "";
                if (rdbSecenek1.Checked) secilen = rdbSecenek1.Text;
                else if (rdbSecenek2.Checked) secilen = rdbSecenek2.Text;
                else if (rdbSecenek3.Checked) secilen = rdbSecenek3.Text;

                if (string.IsNullOrEmpty(secilen))
                {
                    MessageBox.Show("Lütfen bir seçenek seçiniz.");
                    return;
                }

                bool dogruMu = (secilen == dogruSecenek);
                if (dogruMu)
                {
                    dogruSayisi++;
                    lblDogruSayac.Text = "Doğru Sayısı: " + dogruSayisi;
                }

                AdimGuncelle(dogruMu); // Kelimenin adımını güncelle
                soruSayaci++; // İlerle

                // Sınav bitti mi?
                if (soruSayaci >= toplamSoruSayisi)
                {
                    MessageBox.Show($"✅ Sınav tamamlandı!\nToplam doğru: {dogruSayisi} / {toplamSoruSayisi}");
                    this.Hide();
                    AnaSayfa anasayfa = new AnaSayfa();
                    anasayfa.Show();
                    return;
                }

                YeniSoruYukle(); // Yeni soruya geç
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cevap kontrolü sırasında hata oluştu:\n\n" + ex.Message);
            }
        }

        // Kelimenin adımını (tekrar seviyesini) güncelleyen metod
        private void AdimGuncelle(bool dogruBildimi)
        {
            try
            {
                int kelimeID = Convert.ToInt32(guncelKelime["kelimeID"]);
                string tarih = DateTime.Now.ToString("yyyy-MM-dd");

                // Önceden eklenmiş mi kontrol et
                string kontrolSorgu = $"SELECT * FROM KullaniciKelimeleri WHERE kullaniciID={aktifKullaniciID} AND kelimeID={kelimeID}";
                var sonuc = db.VeriGetir(kontrolSorgu);

                if (sonuc.Rows.Count == 0)
                {
                    // Yeni kayıt ekle
                    string ekle = $"INSERT INTO KullaniciKelimeleri (kullaniciID, kelimeID, Adim, SonDogruTarihi) VALUES ({aktifKullaniciID}, {kelimeID}, {(dogruBildimi ? 1 : 0)}, {(dogruBildimi ? $"'{tarih}'" : "NULL")})";
                    db.KomutCalistir(ekle);
                }
                else
                {
                    // Var olan kaydı güncelle
                    int mevcutAdim = Convert.ToInt32(sonuc.Rows[0]["Adim"]);
                    if (dogruBildimi)
                    {
                        mevcutAdim++;
                        if (mevcutAdim >= 7)
                        {
                            MessageBox.Show("🎉 Bu kelime 6. adımı da tamamladı. Öğrenildi!");
                            return;
                        }

                        string guncelle = $"UPDATE KullaniciKelimeleri SET Adim={mevcutAdim}, SonDogruTarihi='{tarih}' WHERE kullaniciID={aktifKullaniciID} AND kelimeID={kelimeID}";
                        db.KomutCalistir(guncelle);
                    }
                    else
                    {
                        // Hatalıysa adımı sıfırla
                        string sifirla = $"UPDATE KullaniciKelimeleri SET Adim=0, SonDogruTarihi=NULL WHERE kullaniciID={aktifKullaniciID} AND kelimeID={kelimeID}";
                        db.KomutCalistir(sifirla);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adım güncellenirken hata oluştu:\n\n" + ex.Message);
            }
        }

        // İstatistik sayfasını açar
        private void button1_Click(object sender, EventArgs e)
        {
            IstatistikSayfasi frm = new IstatistikSayfasi();
            frm.ShowDialog();
        }

        // Geri butonu – anasayfaya döner
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
        }

        // Uygulamayı kapatır
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
