# hastane-otomasyonu-csharp

2019-2020 Bahar Yarıyılı Görsel Programlama Dersi Proje Kuralları
1- Kullanılması zorunlu yapılar:
- Temel yapılar (label, button, textbox vs.)
- DataGridView
- MenuStrip
- OpenFileDialog
- PictureBox
- Timer
- DateTimePicker
- Veri tabanı
Not: Yukarıda sayılan yapılar kullanılması zorunlu olanlar. Ancak bunlara ek olarak projenizde ihtiyaç duyduğunuz farklı yapılar da kullanabilirsiniz.
2- Eklenmesi Zorunlu Durumlar
- Veri tabanı için Ekleme/Silme/Güncelleme/Veri listeleme gibi tüm işlemlerin yapılabiliyor olması gerekir.
- Uygulamalarınız bir kullanıcı giriş (Login) sayfası ile başlamalıdır.
- Kullanıcılarınızın rolleri (standart kullanıcı, admin, yönetici vs) olmalıdır. En az 2 rol olmalıdır.
- Veri tabanı tablolarınıza veri eklemek için Yönetim paneli sayfası olmalıdır ve bu sayfaya sadece yetkili kullanıcılar (yönetici, admin vs) erişebilmelidir.
- Veri tabanına ekleme işlemlerinde bir ürün/kullanıcı vs girilirken her bir bilgi textbox ve diğer yapılar yardımı ile alınarak veri tabanına eklenecek. Ancak yönetim panelinde kullanıcıya toplu veri ekleme seçeneği de sunulacaktır. Herhangi bir .txt veya başka bir dosyada saklanan veriler OpenFileDialog yapısı da kullanılarak veri tabanına toplu da aktarılabilmelidir.
- Sayfalar arası geçişler MenuStrip ile gerçekleştirilmelidir.
- Bir işlem yapıldığı zaman başarılı/başarısız olma durumları kullanıcıya bildirilmelidir.
- Kod blokları try/catch ile çevrelenip, hatalar alındığında kontrol edilmeli ve kullanıcıya gerekli mesajlar verilmelidir.
- Tarih şeklinde girilen veriler DateTimePicker yapısından yararlanılarak textbox’a aktarılacaktır.
- Uygulamanızın ana formunda sol üst tarafta [Öğrenci Numaranız Adınız Soyadınız] yazılmalıdır. Ayrıca sistem saati [SS:DD:ss] şeklinde formunuzun sağ alt tarafında görünecek şekilde eklenmelidir. Saniye sürekli değişmelidir.
3- Önemli Notlar:
- Kodlarınızda ihtiyaç duyulan yerlere yorum satırı (yorum mektubu değil, fazla uzatmadan) ekleyebilirsiniz.
- Kodlarınızı fonksiyonel yazarsanız okunabilirliği ve anlaşılabilirliği yüksek olacağından puanlanması daha rahat olacaktır.
- Başkasına yaptırılan projeler değerlendirilmeye alınmayacaktır. Aynı grupta olan arkadaşlar da projelerini ayrı ayrı yapacak ve sunacaktır.
- Projeniz hem vizenizi hem de final notunuzu oluşturacağından vizede ayrı, finalde ayrı değerlendirilecektir. Vizeye kadar projenizin (tüm sayfalar için) tasarımı bitmiş olmalıdır ve En azından 1 sayfa için veri tabanına ekleme yapabilecek seviye gelmelidir.
- Veri tabanı için herhangi bir kısıtlama olmayacaktır. Dilediğiniz veri tabanını kullanabilirsiniz.
- Final haftasına kadar projenizin tamamının bitmiş olması gerekiyor.
- Vize ve final/bütünleme kontrol gün ve saatleri sınav haftaları yaklaştığında bildirilecektir.
- Projelerinizi kendi kişisel bilgisayarlarınızda sunacaksınız. Sunum günü saatinde oluşabilecek son dakika arıza(!)larından öğrenci sorumludur. Düne kadar çalışıyordu, servise verdim silinmiş, su dökülmüş vs gibi durumlar puan getirmeyecektir.
