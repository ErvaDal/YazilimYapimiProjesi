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


ZueKelime Uygulaması - Formlar Açıklaması
Bu uygulama, kullanıcıların İngilizce kelimeleri öğrenmesini, test etmesini ve gelişimini görmesini sağlayan C# tabanlı bir eğitim platformudur.

1. İstatistikSayfasi.cs
Kullanıcının kelime öğrenme durumu adım adım gösterilir.
Toplam kelime sayısı ve öğrenilen kelime sayısı veritabanından çekilerek gösterilir.
Her bir "öğrenme adımı" için kaç kelimenin olduğu ayrı ayrı yazdırılır.

2. SinavSayfasi.cs
Kullanıcıya öğrenme durumu uygun olan kelimelerden rastgele test soruları yöneltilir.
3 şıklı çoktan seçmeli sistem kullanılır.
Cevap doğruysa kelimenin adımı artırılır, yanlışsa sıfırlanır.
Sınav sonunda kullanıcıya doğru cevap sayısı bildirilir.

3. Wordle.cs
5 harfli İngilizce kelimelerle oynanan mini bir Wordle oyunu sunar.
Kullanıcı her harf için 🟩 (doğru yerde), 🟨 (yanlış yerde), ⬜️ (hiç yok) renk kodlarıyla geribildirim alır.
6 tahmin hakkı ile doğru kelimeyi bulmaya çalışır.
Tamamlanmış kelimelerden seçilen rastgele hedef kelimeye göre oynanır.
