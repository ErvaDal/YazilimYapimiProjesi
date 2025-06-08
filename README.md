ZueKelime - İngilizce Kelime Öğrenme Uygulaması

Bu Windows Forms uygulaması, kullanıcıların İngilizce kelimeleri Türkçe karşılıkları ve görselleri ile öğrenmelerini ve yeni kelimeler eklemelerini sağlar. Kullanıcı dostu arayüzüyle hem kelime öğrenme hem de sınav ve raporlama imkanı sunar.

🚀 Özellikler
Kelime Öğrenme: Veritabanından gelen kelimeler, örnek cümleler ve görsellerle desteklenmiş bir şekilde görüntülenir.
Kelime Ekleme: Kullanıcılar yeni kelime, örnek cümle ve görsel ekleyebilir.
Ana Sayfa: Kelime öğrenme, ekleme, sınav, rapor ve Wordle gibi modüllere geçiş sağlar.
Veritabanı Bağlantısı: SQL Server kullanılarak kelimeler, örnek cümleler ve resimler saklanır.
Resim Desteği: ImageMagick kütüphanesi kullanılarak görseller yeniden boyutlandırılır.

🛠 Gereksinimler
.NET Framework 4.7.2 veya üzeri
SQL Server (örnekteki bağlantı: ZueKelime veritabanı)
Magick.NET (ImageMagick .NET Wrapper)

📁 Proje Yapısı
AnaSayfa.cs: Ana menü arayüzü ve diğer sayfalara geçiş.
KelimeOgrenme.cs: Veritabanından kelimeleri çekerek öğrenme sayfasında gösterir.
KelimeEkleme.cs: Yeni kelime ve örnek cümle eklemek için form.

🔧 Kurulum
Projeyi Visual Studio ile açın.
Gerekli NuGet paketlerini yükleyin (Magick.NET).
SQL Server’da ZueKelime adlı veritabanını oluşturun ve gerekli tabloları kurun.
App.config veya kod içerisindeki bağlantı stringini kendi sisteminize göre düzenleyin.




🧩 ZueKelime Uygulaması - Formlara Genel Bakış
ZueKelime, kullanıcıların İngilizce kelimeleri adım adım öğrenmelerini, gelişimlerini izlemelerini ve oyunlaştırılmış testlerle pekiştirmelerini amaçlayan bir dil öğrenme platformudur. Uygulama, Windows Forms teknolojisiyle geliştirilmiş olup veritabanı destekli çalışmaktadır.

1. İstatistikSayfasi.cs – Öğrenme İlerlemesini Görüntüleme
Kullanıcının öğrenme sürecinde geçtiği tüm adımlar (0’dan 6’ya kadar) ayrı ayrı analiz edilir.
Toplam sistemde bulunan kelime sayısı ile kullanıcının başarıyla tamamladığı kelime sayısı gösterilir.
Hangi adımda kaç kelime olduğu kullanıcıya etiketler aracılığıyla net biçimde sunulur.
Bu sayfa sayesinde kullanıcı, hangi seviyede ne kadar ilerlediğini somut verilerle görebilir.

2. SinavSayfasi.cs – Akıllı Tekrar ve Test Modülü
Uygulama, tekrar edilmesi gereken kelimeleri SM-2 algoritmasına benzer bir zamanlama ile belirler.
Sistem, öğrenme seviyesine (Adım) göre hangi kelimenin sorulması gerektiğine karar verir.
3 seçenekli çoktan seçmeli testler kullanıcıya rastgele olarak sunulur.
Cevap doğruysa kelimenin seviyesi artırılır, yanlışsa sıfırlanır.
Sınav tamamlandığında kullanıcıya doğru cevap sayısı ve performansı raporlanır.

3. Wordle.cs – 5 Harfli Kelimelerle Eğlenceli Tahmin Oyunu
Kullanıcının daha önce tamamladığı (öğrenme adımı 6) kelimelerden rastgele bir kelime seçilir.
Kullanıcı bu kelimeyi 6 tahmin hakkıyla bulmaya çalışır.
Her harf için renk kodlarıyla geri bildirim verilir:
🟩: Doğru harf, doğru yerde
🟨: Doğru harf, yanlış yerde
⬜️: Harf kelimede yok
Eğlenceli ve öğretici bu modül, kelimeyi tanıma ve hatırlama becerisini güçlendirir.
