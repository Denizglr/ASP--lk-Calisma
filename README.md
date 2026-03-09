# 🛒 ASP.NET Core MVC - Stok Takip Sistemi

Bu proje, ASP.NET Core MVC mimarisi kullanılarak geliştirilmiş, dinamik bir ürün yönetimi ve stok takip uygulamasıdır. Kullanıcıların kategorilere göre ürün eklemesine, mevcut ürünleri modern bir arayüzle listelemesine ve yönetim paneli üzerinden verileri kontrol etmesine olanak tanır.

## 🚀 Proje Özellikleri
* **Ürün Listeleme:** Kayıtlı ürünler, Bootstrap 5 kart yapısı kullanılarak ana sayfada şık bir şekilde listelenir.
* **Yeni Ürün Girişi:** Ürün adı, kategori, fiyat ve açıklama bilgilerini içeren dinamik form yapısı.
* **Yönetim Paneli (CRUD):** Ürünlerin tablo formatında detaylı görünümü, silme ve düzenleme işlemlerinin yönetildiği alan.
* **Detay Sayfası:** Her ürüne özel, ayrıntılı bilgi sunan sayfa yapısı.

## 📸 Ekran Görüntüleri

### 1. Ürün Listeleme (Kullanıcı Arayüzü)
![Ürün Listeleme Paneli](https://github.com/user-attachments/assets/da0adbf6-b038-43db-aed0-0fdb2930bb56)

### 2. Yeni Ürün Ekleme Sayfası
![Ürün Ekleme Sayfası](https://github.com/user-attachments/assets/2ec63783-bd66-4ad4-ad49-68f106ac8bf7)

### 3. Ürün Yönetimi (Düzenle / Sil Paneli)
![Ürün Yönetimi Tablosu](https://github.com/user-attachments/assets/e7fa5f06-013d-406e-b436-d29640538647)

## 🛠 Kullanılan Teknolojiler
* **Backend:** C# / ASP.NET Core 8.0 (MVC)
* **Frontend:** HTML5, CSS3, Bootstrap 5
* **Veri Yönetimi:** Bellek içi (Static List) veri yapısı

## 📂 Klasör Yapısı
* **Controllers:** Uygulama mantığını yöneten `ProductController` sınıfı.
* **Models:** Veri şablonunu belirleyen `Product.cs` sınıfı.
* **Views:** Kullanıcıya sunulan `.cshtml` arayüz dosyaları.

## ⚙️ Kurulum ve Çalıştırma
1. Bu depoyu klonlayın: `git clone https://github.com/Denizglr/ASP--lk-Calisma.git`
2. Visual Studio ile açın ve bağımlılıkların yüklenmesini bekleyin.
3. `F5` tuşuna basarak uygulamayı yerel sunucunuzda çalıştırın.
