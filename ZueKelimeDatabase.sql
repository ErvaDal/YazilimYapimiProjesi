USE [ZueKelime]
GO
/****** Object:  Table [dbo].[kelimeler]    Script Date: 8.06.2025 22:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kelimeler](
	[kelimeID] [int] IDENTITY(1,1) NOT NULL,
	[ingKelime] [nvarchar](50) NULL,
	[turKelime] [nvarchar](50) NULL,
	[resimID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[kelimeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kelimeOrnekleri]    Script Date: 8.06.2025 22:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kelimeOrnekleri](
	[kelimeOrnegiID] [int] IDENTITY(1,1) NOT NULL,
	[kelimeID] [int] NULL,
	[ingKelimeOrnegi] [text] NULL,
	[turKelimeOrnegi] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[kelimeOrnegiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullaniciKelimeleri]    Script Date: 8.06.2025 22:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullaniciKelimeleri](
	[KullaniciKelimeleriID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciID] [int] NOT NULL,
	[kelimeID] [int] NOT NULL,
	[Adim] [int] NOT NULL,
	[SonDogruTarihi] [date] NULL,
 CONSTRAINT [PK__Kullanic__3214EC2730EF011E] PRIMARY KEY CLUSTERED 
(
	[KullaniciKelimeleriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[resim]    Script Date: 8.06.2025 22:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[resim](
	[resimID] [int] IDENTITY(1,1) NOT NULL,
	[ad] [nvarchar](255) NULL,
	[yol] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[resimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKullanici]    Script Date: 8.06.2025 22:11:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKullanici](
	[kullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[adSoyad] [nvarchar](50) NULL,
	[kullaniciAdi] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[sifre] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[kullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[kelimeler] ON 

INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (1, N'apple', N'elma', 1)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (2, N'shoe', N'ayakkabı', 2)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (3, N'yellow', N'sarı', 3)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (4, N'red', N'kırmızı', 4)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (5, N'plum', N'erik', 5)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (6, N'donkey', N'eşek', 6)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (7, N'cloud', N'bulut', 7)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (8, N'water', N'su', 8)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (9, N'strawberry', N'çilek', 9)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (10, N'museum', N'müze', 10)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (11, N'kitchen', N'mutfak', 11)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (12, N'teacher', N'öğretmen', 12)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (13, N'bed', N'yatak', 13)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (14, N'fish', N'balık', 14)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (15, N'breakfast', N'kahvaltı', 15)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (16, N'beard', N'sakal', 16)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (17, N'university', N'üniversite', 17)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (18, N'fruit', N'meyve', 18)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (19, N'dress', N'elbise', 19)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (20, N'sea', N'deniz', 20)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (21, N'bird', N'kuş', 21)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (22, N'friend', N'arkadaş', 22)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (23, N'hand', N'el', 23)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (24, N'woman', N'kadın', 24)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (25, N'bus', N'otobüs', 25)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (26, N'table', N'masa', 26)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (27, N'flag', N'bayrak', 27)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (28, N'window', N'pencere', 28)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (29, N'rain', N'yağmur', 29)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (30, N'tree', N'ağaç', 30)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (31, N'car', N'araba', 31)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (32, N'sheep', N'koyun', 32)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (33, N'home', N'ev', 33)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (34, N'computer', N'bilgisayar', 34)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (35, N'cat', N'kedi', 35)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (36, N'tea', N'çay', 36)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (37, N'child', N'çocuk', 37)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (38, N'cow', N'inek', 38)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (39, N'flower', N'çiçek', 39)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (40, N'school', N'okul', 40)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (41, N'happy', N'mutlu', 41)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (42, N'farm', N'çiftlik', 42)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (43, N'door', N'kapı', 43)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (44, N'dog', N'köpek', 44)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (45, N'girl', N'kız', 45)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (46, N'soup', N'çorba', 46)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (47, N'old', N'yaşlı', 47)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (48, N'tent', N'çadır', 48)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (49, N'moon', N'ay', 49)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (50, N'cup', N'fincan', 50)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (51, N'chair', N'sandalye', 51)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (52, N'coffee', N'kahve', 52)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (53, N'pencil', N'kalem', 53)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (54, N'bank', N'banka', 54)
INSERT [dbo].[kelimeler] ([kelimeID], [ingKelime], [turKelime], [resimID]) VALUES (55, N'ice cream', N'dondurma', 55)
SET IDENTITY_INSERT [dbo].[kelimeler] OFF
GO
SET IDENTITY_INSERT [dbo].[kelimeOrnekleri] ON 

INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (1, 1, N'I eat an apple every day.', N'Her gün bir elma yerim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (2, 1, N'This apple is green.', N'Bu elma yeşil.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (3, 2, N'I have a new shoe.', N'Bir yeni ayakkabım var.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (4, 2, N'These are my shoes.', N'Bunlar benim ayakkabılarım.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (5, 3, N'The sun is yellow.', N'Güneş sarıdır.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (6, 3, N'She has a yellow dress.', N'Onun sarı bir elbisesi var.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (7, 4, N'I like red flowers.', N'Kırmızı çiçekleri severim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (8, 4, N'He is wearing a red shirt.', N'O kırmızı bir gömlek giyiyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (9, 5, N'I ate a sweet plum.', N'Tatlı bir erik yedim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (10, 5, N'The plum tree is full of fruit.', N'Erik ağacı meyveyle dolu.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (11, 6, N'The donkey is eating grass.', N'Eşek ot yiyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (12, 6, N'I saw a donkey on the farm.', N'Çiftlikte bir eşek gördüm.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (13, 7, N'There is a cloud in the sky.', N'Gökyüzünde bir bulut var.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (14, 7, N'The cloud is very big.', N'Bulut çok büyük.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (15, 8, N'I drink water every day.', N'Her gün su içerim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (16, 8, N'The water is very cold.', N'Su çok soğuk.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (17, 9, N'I love eating strawberries.', N'Çilek yemeyi çok severim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (18, 9, N'She picked fresh strawberries from the garden.', N'O, bahçeden taze çilek topladı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (19, 10, N'I visited the museum yesterday.', N'Dün müzeyi ziyaret ettim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (20, 10, N'The museum has many interesting exhibits.', N'Müze çok ilginç sergilere sahip.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (21, 11, N'I am cooking in the kitchen.', N'Mutfakta yemek yapıyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (22, 11, N'The kitchen is very clean.', N'Mutfak çok temiz.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (23, 12, N'My teacher is very kind.', N'Öğretmenim çok nazik.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (24, 12, N'The teacher is explaining the lesson.', N'Öğretmen dersi anlatıyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (25, 13, N'I sleep in my bed every night.', N'Her gece yatağımda uyurum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (26, 13, N'The bed is very comfortable.', N'Yatak çok rahat.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (27, 14, N'I like to eat fish.', N'Balık yemeyi severim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (28, 14, N'The fish are swimming in the pond.', N'Balıklar gölette yüzüyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (29, 15, N'I eat breakfast at 7 a.m.', N'Kahvaltıyı sabah 7''de yerim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (30, 15, N'My favorite breakfast is eggs and toast.', N'En sevdiğim kahvaltı yumurta ve tost.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (31, 16, N'He has a big beard.', N'Onun büyük bir sakalı var.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (32, 16, N'I like the color of his beard.', N'Sakalının rengini beğeniyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (33, 17, N'She studies at a famous university.', N'O, ünlü bir üniversitede okuyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (34, 17, N'The university is located in the city center.', N'Üniversite şehir merkezinde yer alıyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (35, 18, N'I eat fruit every day.', N'Her gün meyve yerim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (36, 18, N'This fruit is very sweet.', N'Bu meyve çok tatlı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (37, 19, N'She is wearing a beautiful dress.', N'O, güzel bir elbise giyiyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (38, 19, N'I bought a new dress for the party.', N'Parti için yeni bir elbise aldım.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (39, 20, N'I love swimming in the sea.', N'Denizde yüzmeyi seviyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (40, 20, N'The sea is very calm today.', N'Bugün deniz çok sakin.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (41, 21, N'The bird is singing in the tree.', N'Kuş ağaçta şarkı söylüyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (42, 21, N'I saw a colorful bird in the garden.', N'Bahçede renkli bir kuş gördüm.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (43, 22, N'My friend is very kind.', N'Arkadaşım çok nazik.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (44, 22, N'I met a new friend at school.', N'Okulda yeni bir arkadaş edindim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (45, 23, N'She raised her hand to ask a question.', N'O, soru sormak için elini kaldırdı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (46, 23, N'I hurt my hand while playing soccer.', N'Futbol oynarken elimi incittim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (47, 24, N'The woman is reading a book.', N'Kadın bir kitap okuyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (48, 24, N'She is a strong and intelligent woman.', N'O, güçlü ve zeki bir kadındır.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (49, 25, N'I take the bus to work every day.', N'Her gün işe otobüsle giderim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (50, 25, N'The bus is late today.', N'Otobüs bugün geç kaldı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (51, 26, N'The book is on the table.', N'Kitap masanın üzerinde.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (52, 26, N'We are sitting at the table for dinner.', N'Akşam yemeği için masada oturuyoruz.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (53, 27, N'The flag is waving in the wind.', N'Bayrak rüzgarda dalgalanıyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (54, 27, N'They raised the flag at the ceremony.', N'Tören sırasında bayrağı kaldırdılar.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (55, 28, N'The window is open because it''s hot.', N'Pencere açık çünkü hava sıcak.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (56, 28, N'I can see the garden from my window.', N'Penceremden bahçeyi görebiliyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (57, 29, N'It is going to rain tomorrow.', N'Yarın yağmur yağacak.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (58, 29, N'I love to listen to the rain.', N'Yağmuru dinlemeyi seviyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (59, 30, N'The tree is very tall.', N'Ağaç çok uzun.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (60, 30, N'The leaves on the tree are turning yellow.', N'Ağaçtaki yapraklar sararmaya başlıyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (61, 31, N'I drive my car to work every day.', N'Her gün işe arabamla giderim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (62, 31, N'His car is very fast.', N'Onun arabası çok hızlı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (63, 32, N'The sheep are grazing in the field.', N'Koyunlar tarlada otluyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (64, 32, N'We saw a group of sheep on the farm.', N'Çiftlikte bir grup koyun gördük.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (65, 33, N'I am going home after work', N'İşten sonra eve gidiyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (66, 33, N'This is my home.', N'Burası benim evim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (67, 34, N'I use my computer to work from home.', N'Evden çalışmak için bilgisayarımı kullanıyorum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (68, 34, N'Computer is very fast.', N'Bilgisayar çok hızlı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (69, 35, N'My cat is sleeping on the sofa.', N'Kedim kanepede uyuyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (70, 35, N'The cat loves to play with toys.', N'Kedi oyuncaklarla oynamayı çok sever.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (71, 36, N'I drink tea every morning.', N'Her sabah çay içerim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (72, 36, N'She likes to have tea with her friends.', N'O, arkadaşlarıyla çay içmeyi sever.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (73, 37, N'The child is playing in the park.', N'Çocuk parkta oynuyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (74, 37, N'She is a kind child.', N'O, nazik bir çocuk.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (75, 38, N'I saw a cow on the farm.', N'Çiftlikte bir inek gördüm.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (76, 38, N'The cow gives us milk.', N'İnek bize süt verir.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (77, 39, N'The flower in the garden is very beautiful.', N'Bahçedeki çiçek çok güzel.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (78, 39, N'I picked flowers for my mother.', N'Annem için çiçek topladım.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (79, 40, N'I go to school every day.', N'Her gün okula giderim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (80, 40, N'The school is very big.', N'Okul çok büyük.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (81, 41, N'I am happy today.', N'Bugün mutluyum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (82, 41, N'She feels happy with her friends.', N'Arkadaşlarıyla mutlu hissediyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (83, 42, N'The farm has many cows.', N'Çiftlikte birçok inek var.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (84, 42, N'I help on the farm every weekend.', N'Her hafta sonu çiftlikte yardımcı olurum.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (85, 43, N'The door is open.', N'Kapı açık.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (86, 43, N'She knocked on the door.', N'O, kapıyı çaldı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (87, 44, N'The dog is barking loudly.', N'Köpek yüksek sesle havlıyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (88, 44, N'I have a dog at home.', N'Evde bir köpeğim var.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (89, 45, N'The girl is playing with a ball.', N'Kız top ile oynuyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (90, 45, N'She is a smart girl.', N'O, zeki bir kız.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (91, 46, N'I ate hot soup for lunch.', N'Öğle yemeğinde sıcak çorba içtim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (92, 46, N'This soup tastes very good.', N'Bu çorbanın tadı çok güzel.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (93, 47, N'My grandfather is old.', N'Büyükbabam yaşlıdır.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (94, 47, N'He is an old man.', N'O yaşlı bir adamdır.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (95, 48, N'We slept in a tent last night.', N'Dün gece bir çadırda uyuduk.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (96, 48, N'The tent is next to the trees.', N'Çadır ağaçların yanında.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (97, 49, N'The moon is very bright tonight.', N'Ay bu gece çok parlak.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (98, 49, N'The moon is mine, the night is yours.', N'Ay benim, gece senin.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (99, 50, N'I drank a cup of tea.', N'Bir fincan çay içtim.')
GO
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (100, 50, N'The cup is on the table.', N'Fincan masanın üzerinde.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (101, 51, N'This is my favorite chair.', N'Bu benim en sevdiğim sandalye.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (102, 51, N'She sat on the chair and started to read.', N'Sandaleye oturdu ve okumaya başladı.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (103, 52, N'I drink coffee every morning.', N'Her sabah kahve içerim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (104, 52, N'She likes her coffee with milk.', N'Kahvesini sütlü sever.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (105, 53, N'This is my pencil.', N'Bu benim kalemim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (106, 53, N'He draws a picture with his pencil.', N'Kalemiyle bir resim çiziyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (107, 54, N'I went to the bank yesterdey.', N'Dün bankaya gittim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (108, 54, N'She works at a bank.', N'O bir bankada çalışıyor.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (109, 55, N'I like chocolate ice cream.', N'Ben çikolatalı dondurmayı severim.')
INSERT [dbo].[kelimeOrnekleri] ([kelimeOrnegiID], [kelimeID], [ingKelimeOrnegi], [turKelimeOrnegi]) VALUES (110, 55, N'She is eating ice cream.', N'O dondurma yiyor.')
SET IDENTITY_INSERT [dbo].[kelimeOrnekleri] OFF
GO
SET IDENTITY_INSERT [dbo].[KullaniciKelimeleri] ON 

INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (2, 11, 101, 0, NULL)
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (3, 11, 102, 1, CAST(N'2024-01-05' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (4, 11, 103, 2, CAST(N'2024-02-10' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (5, 11, 104, 3, CAST(N'2024-02-15' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (6, 11, 105, 4, CAST(N'2024-03-20' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (7, 11, 106, 5, CAST(N'2024-04-01' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (8, 11, 107, 6, CAST(N'2024-04-15' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (9, 11, 13, 2, CAST(N'2024-03-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (10, 11, 14, 3, CAST(N'2024-03-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (11, 11, 15, 4, CAST(N'2024-04-24' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (12, 11, 16, 5, CAST(N'2024-05-04' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (13, 11, 17, 6, CAST(N'2024-06-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (14, 11, 113, 3, CAST(N'2024-03-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (15, 11, 114, 3, CAST(N'2024-03-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (16, 11, 115, 4, CAST(N'2024-04-24' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (17, 11, 116, 4, CAST(N'2024-05-04' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (18, 11, 117, 4, CAST(N'2024-06-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (19, 11, 123, 2, CAST(N'2024-03-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (20, 11, 124, 3, CAST(N'2024-03-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (21, 11, 125, 4, CAST(N'2024-04-24' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (22, 11, 126, 4, CAST(N'2024-05-04' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (23, 11, 127, 4, CAST(N'2024-06-14' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (24, 7, 45, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (25, 7, 50, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (26, 7, 32, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (27, 7, 43, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (28, 7, 33, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (29, 7, 25, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (30, 7, 6, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (31, 7, 52, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (32, 7, 11, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (33, 7, 1, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (34, 7, 47, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (35, 7, 36, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (36, 7, 48, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (37, 7, 27, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (38, 7, 7, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (39, 7, 16, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (40, 7, 29, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (41, 7, 17, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (42, 7, 13, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (43, 7, 35, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (44, 12, 40, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (45, 12, 19, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (46, 12, 16, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (47, 12, 29, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (48, 12, 34, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (49, 7, 39, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (50, 7, 44, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (51, 7, 34, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (52, 7, 46, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (53, 7, 40, 1, CAST(N'2025-06-06' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (54, 12, 47, 1, CAST(N'2025-06-07' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (55, 12, 2, 1, CAST(N'2025-06-07' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (56, 12, 12, 1, CAST(N'2025-06-08' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (57, 12, 52, 1, CAST(N'2025-06-08' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (58, 12, 51, 1, CAST(N'2025-06-08' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (59, 12, 6, 1, CAST(N'2025-06-08' AS Date))
INSERT [dbo].[KullaniciKelimeleri] ([KullaniciKelimeleriID], [kullaniciID], [kelimeID], [Adim], [SonDogruTarihi]) VALUES (60, 12, 43, 1, CAST(N'2025-06-08' AS Date))
SET IDENTITY_INSERT [dbo].[KullaniciKelimeleri] OFF
GO
SET IDENTITY_INSERT [dbo].[resim] ON 

INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (1, N'elma.png', N'C:\Users\USer\Desktop\resimler\elma.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (2, N'ayakkabı.jpg', N'C:\Users\USer\Desktop\resimler\ayakkabı.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (3, N'sarı.jpg', N'C:\Users\USer\Desktop\resimler\sarı.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (4, N'kırmızı.webp', N'C:\Users\USer\Desktop\resimler\kırmızı.webp')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (5, N'erik.jpg', N'C:\Users\USer\Desktop\resimler\erik.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (6, N'eşek.jpg', N'C:\Users\USer\Desktop\resimler\eşek.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (7, N'bulut.png', N'C:\Users\USer\Desktop\resimler\bulut.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (8, N'su.jpg', N'C:\Users\USer\Desktop\resimler\su.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (9, N'çilek.png', N'C:\Users\USer\Desktop\resimler\çilek.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (10, N'müze.webp', N'C:\Users\USer\Desktop\resimler\müze.webp')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (11, N'mutfak.jpg', N'C:\Users\USer\Desktop\resimler\mutfak.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (12, N'öğretmen.jpg', N'C:\Users\USer\Desktop\resimler\öğretmen.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (13, N'yatak.png', N'C:\Users\USer\Desktop\resimler\yatak.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (14, N'balık.png', N'C:\Users\USer\Desktop\resimler\balık.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (15, N'kahvaltı.jpg', N'C:\Users\USer\Desktop\resimler\kahvaltı.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (16, N'sakal.png', N'C:\Users\USer\Desktop\resimler\sakal.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (17, N'üniversite.jpg', N'C:\Users\USer\Desktop\resimler\üniversite.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (18, N'meyve.jpg', N'C:\Users\USer\Desktop\resimler\meyve.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (19, N'elbise.jpg', N'C:\Users\USer\Desktop\resimler\elbise.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (20, N'deniz.png', N'C:\Users\USer\Desktop\resimler\deniz.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (21, N'kuş.jpg', N'C:\Users\USer\Desktop\resimler\kuş.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (22, N'arkadaş.png', N'C:\Users\USer\Desktop\resimler\arkadaş.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (23, N'el.png', N'C:\Users\USer\Desktop\resimler\el.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (24, N'kadın.jpeg', N'C:\Users\USer\Desktop\resimler\kadın.jpeg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (25, N'otobüs.png', N'C:\Users\USer\Desktop\resimler\otobüs.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (26, N'masa.jpg', N'C:\Users\USer\Desktop\resimler\masa.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (27, N'bayrak.jpeg', N'C:\Users\USer\Desktop\resimler\bayrak.jpeg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (28, N'pencere.avif', N'C:\Users\USer\Desktop\resimler\pencere.avif')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (29, N'yağmur.jpg', N'C:\Users\USer\Desktop\resimler\yağmur.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (30, N'ağaç.png', N'C:\Users\USer\Desktop\resimler\ağaç.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (31, N'araba.webp', N'C:\Users\USer\Desktop\resimler\araba.webp')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (32, N'koyun.png', N'C:\Users\USer\Desktop\resimler\koyun.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (33, N'ev.jpg', N'C:\Users\USer\Desktop\resimler\ev.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (34, N'bilgisayar.png', N'C:\Users\USer\Desktop\resimler\bilgisayar.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (35, N'kedi.png', N'C:\Users\USer\Desktop\resimler\kedi.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (36, N'çay.jpg', N'C:\Users\USer\Desktop\resimler\çay.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (37, N'çocuk.png', N'C:\Users\USer\Desktop\resimler\çocuk.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (38, N'inek.webp', N'C:\Users\USer\Desktop\resimler\inek.webp')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (39, N'çiçek.png', N'C:\Users\USer\Desktop\resimler\çiçek.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (40, N'okul.jpg', N'C:\Users\USer\Desktop\resimler\okul.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (41, N'mutlu.jpg', N'C:\Users\USer\Desktop\resimler\mutlu.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (42, N'çiftlik.jpg', N'C:\Users\USer\Desktop\resimler\çiftlik.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (43, N'kapı.jpg', N'C:\Users\USer\Desktop\resimler\kapı.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (44, N'köpek.jpg', N'C:\Users\USer\Desktop\resimler\köpek.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (45, N'kız.jpg', N'C:\Users\USer\Desktop\resimler\kız.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (46, N'çorba.jpg', N'C:\Users\USer\Desktop\resimler\çorba.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (47, N'yaşlı.png', N'C:\Users\USer\Desktop\resimler\yaşlı.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (48, N'çadır.png', N'C:\Users\USer\Desktop\resimler\çadır.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (49, N'ay.jpg', N'C:\Users\USer\Desktop\resimler\ay.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (50, N'fincan.jpg', N'C:\Users\USer\Desktop\resimler\fincan.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (51, N'Ekran görüntüsü 2025-05-13 115433.png', N'C:\Users\USer\Pictures\Screenshots\Ekran görüntüsü 2025-05-13 115433.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (52, N'Ekran görüntüsü 2025-05-14 200146.png', N'C:\Users\USer\Pictures\Screenshots\Ekran görüntüsü 2025-05-14 200146.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (53, N'Ekran görüntüsü 2025-05-14 201219.png', N'C:\Users\USer\Pictures\Screenshots\Ekran görüntüsü 2025-05-14 201219.png')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (54, N'banka.jpg', N'C:\Users\USer\Desktop\banka.jpg')
INSERT [dbo].[resim] ([resimID], [ad], [yol]) VALUES (55, N'dondurma.jpg', N'C:\Users\USer\Desktop\dondurma.jpg')
SET IDENTITY_INSERT [dbo].[resim] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKullanici] ON 

INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (6, N'Erva', N'Eien', N'ervadal19@gmail.com', N'4eed628ce44598842ab84741d9a2d2adeefb94b0577a3c0b1d')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (7, N'Zeren Karakuş', N'cimbom_zeren', N'zerenk54@gmail.com', N'4b332ba8b2e97eda2d76f80bfbec916dbabc0a9c5397e43947')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (8, N'Melisa ÇAKICI', N'Melisackc', N'kinaymelisa36@gmail.com', N'5f395d07369071a505ef926527de2ac53e8c29e103dc633983')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (9, N'beyda c', N'beyda', N'elma15385@gmail.com', N'13da93d7570ba44546d2abcc4866480f51e77ac1b166509add')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (10, N'umut', N'umut', N'umut@', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e99')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (11, N'erva dal', N'eien123', N'eien123', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e99')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (12, N'Zeren Yargıcı', N'zeren', N'zeren_sumeyye@hotmail.com', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e99')
INSERT [dbo].[tblKullanici] ([kullaniciID], [adSoyad], [kullaniciAdi], [email], [sifre]) VALUES (13, N'Zeren Karakuşş', N'zerennn', N'zerenk68@gmail.com', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e99')
SET IDENTITY_INSERT [dbo].[tblKullanici] OFF
GO
ALTER TABLE [dbo].[kelimeler]  WITH CHECK ADD  CONSTRAINT [FK_kelimeler_resimID] FOREIGN KEY([resimID])
REFERENCES [dbo].[resim] ([resimID])
GO
ALTER TABLE [dbo].[kelimeler] CHECK CONSTRAINT [FK_kelimeler_resimID]
GO
ALTER TABLE [dbo].[kelimeOrnekleri]  WITH CHECK ADD  CONSTRAINT [FK_kelimeOrnekleri_kelimeID] FOREIGN KEY([kelimeID])
REFERENCES [dbo].[kelimeler] ([kelimeID])
GO
ALTER TABLE [dbo].[kelimeOrnekleri] CHECK CONSTRAINT [FK_kelimeOrnekleri_kelimeID]
GO
ALTER TABLE [dbo].[KullaniciKelimeleri]  WITH CHECK ADD  CONSTRAINT [FK__Kullanici__kulla__4BAC3F29] FOREIGN KEY([kullaniciID])
REFERENCES [dbo].[tblKullanici] ([kullaniciID])
GO
ALTER TABLE [dbo].[KullaniciKelimeleri] CHECK CONSTRAINT [FK__Kullanici__kulla__4BAC3F29]
GO
