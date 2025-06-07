using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ZueKelime
{
    public partial class Wordle : Form
    {
        private string hedefKelime; // Tahmin edilmesi gereken kelime
        private int tahminHakki = 6; // Toplam tahmin hakkı
        private VeritabaniYardimci db = new VeritabaniYardimci(); // Veritabanı işlemleri için yardımcı sınıf
        private HashSet<string> girilenKelimeler = new HashSet<string>(); // Daha önce girilen kelimeleri tutar
        private int aktifKullaniciID; // Şu anki oturum açmış kullanıcının ID’si

        public Wordle()
        {
            InitializeComponent(); // Form bileşenlerini başlatır
        }
        // Form yüklendiğinde çalışır
        private void Wordle_Load(object sender, EventArgs e)
        {
            try
            {
                aktifKullaniciID = OturumBilgisi.AktifKullaniciID;

                if (aktifKullaniciID <= 0)
                {
                    MessageBox.Show("Oturum geçerli değil. Ana sayfaya yönlendiriliyorsunuz.");
                    this.Close();
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    return;
                }

                btnSinaviYenidenBaslat.PerformClick(); // FORM AÇILINCA YENİDEN BAŞLAT OTOMATİK TIKLANIR
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        // Tahmin butonuna basıldığında çalışır
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(hedefKelime)) return; // Kelime boşsa işlemi iptal et

            string girilen = txtTahmin.Text.Trim().ToUpper(); // Kullanıcının girdiği kelime

            if (girilen.Length != 5)
            {
                MessageBox.Show("Lütfen 5 harfli bir kelime giriniz.");
                return;
            }

            if (girilenKelimeler.Contains(girilen))
            {
                MessageBox.Show("Bu kelimeyi daha önce denediniz.");
                return;
            }

            if (tahminHakki <= 0)
            {
                MessageBox.Show($"Tahmin hakkınız bitti.\nDoğru kelime: {hedefKelime}");
                return;
            }

            girilenKelimeler.Add(girilen); // Girilen kelimeyi listeye ekle

            // Hedef kelimedeki harf sayılarını say
            Dictionary<char, int> harfSayisi = new Dictionary<char, int>();
            foreach (char h in hedefKelime)
            {
                if (!harfSayisi.ContainsKey(h))
                    harfSayisi[h] = 0;
                harfSayisi[h]++;
            }

            string[] sonuc = new string[5]; // Renkli simgelerle geri bildirim
            bool[] yerindeMi = new bool[5]; // Harfin doğru pozisyonda olup olmadığını kontrol eder

            // İlk olarak doğru pozisyondaki harfleri kontrol et (yeşil)
            for (int i = 0; i < 5; i++)
            {
                if (girilen[i] == hedefKelime[i])
                {
                    sonuc[i] = $"🟩{girilen[i]}";
                    yerindeMi[i] = true;
                    harfSayisi[girilen[i]]--;
                }
            }

            // Sonra sarı ve beyaz kontrolü yap
            for (int i = 0; i < 5; i++)
            {
                if (!yerindeMi[i])
                {
                    if (harfSayisi.ContainsKey(girilen[i]) && harfSayisi[girilen[i]] > 0)
                    {
                        sonuc[i] = $"🟨{girilen[i]}"; // Yanlış yerde ama doğru harf
                        harfSayisi[girilen[i]]--;
                    }
                    else
                    {
                        sonuc[i] = $"⬜️{girilen[i]}"; // Hiç olmayan harf
                    }
                }
            }

            lstSonuclar.Items.Add(string.Join(" ", sonuc)); // Sonucu listeye ekle
            tahminHakki--; // Tahmin hakkını azalt

            // Oyun sonucu kontrol
            if (girilen == hedefKelime)
            {
                MessageBox.Show("🎉 Tebrikler! Doğru tahmin ettiniz.");
                btnTahmin.Enabled = false;
            }
            else if (tahminHakki == 0)
            {
                MessageBox.Show($"😞 Tahmin hakkınız bitti. Doğru kelime: {hedefKelime}");
                btnTahmin.Enabled = false;
            }
        }

        // "Sınavı Yeniden Başlat" butonuna basıldığında
        private void btnSinaviYenidenBaslat_Click(object sender, EventArgs e)
        {
            KelimeyiYukle(); // Yeni kelime yükle
            tahminHakki = 6; // Hakları sıfırla
            lstSonuclar.Items.Clear(); // Önceki sonuçları temizle
            txtTahmin.Clear(); // Tahmin kutusunu temizle
            btnTahmin.Enabled = true; // Butonu yeniden aktif et
            girilenKelimeler.Clear(); // Girilen kelimeleri temizle
            MessageBox.Show("Sınav yeniden başlatıldı!");
        }

        // Veritabanından kelimeyi yükler
        private void KelimeyiYukle()
        {
            try
            {
                string sql = @"
					SELECT LTRIM(RTRIM(UPPER(k.ingKelime))) AS ingKelime
					FROM kelimeler k
					JOIN KullaniciKelimeleri kk ON k.kelimeID = kk.kelimeID
					WHERE LEN(k.ingKelime) = 5 
					AND kk.kullaniciID = @kID 
					AND kk.Adim = 6";

                Dictionary<string, object> parametreler = new Dictionary<string, object>
                {
                    { "@kID", aktifKullaniciID }
                };

                DataTable dt = db.VeriGetir(sql, parametreler); // Verileri çek

                if (dt != null && dt.Rows.Count > 0)
                {
                    Random rnd = new Random();
                    int index = rnd.Next(0, dt.Rows.Count);
                    hedefKelime = dt.Rows[index]["ingKelime"].ToString(); // Rastgele bir kelime seç
                    btnTahmin.Enabled = true;
                }
                else
                {
                    hedefKelime = null;
                    btnTahmin.Enabled = false;
                    MessageBox.Show("Bu kullanıcıya ait 5 harfli ve 6. adıma ulaşmış kelime bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                hedefKelime = null;
                btnTahmin.Enabled = false;
                MessageBox.Show("Kelime yüklenirken hata oluştu:\n" + ex.Message);
            }
        }

        // Geri butonuna basıldığında ana sayfaya dön
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }

        // Çıkış butonuna basıldığında uygulamadan çık
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
