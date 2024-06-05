# Kargo Takip Uygulaması

## Giriş
Bu rapor, Kargo Takip Uygulaması'nın özelliklerini ve kullanımını detaylı bir şekilde açıklamaktadır. Uygulama, kullanıcıların kargolarını takip etmelerini, yönetmelerini ve güncellemelerini sağlar. Ayrıca admin kullanıcılar, tüm kargoları görüntüleyebilir ve yönetebilirler.

## Kullanıcı Rolleri ve Yetkiler

### 1. Standart Kullanıcı
- **Kayıt Olma ve Giriş Yapma**
  - Kullanıcılar uygulamaya kaydolabilir ve giriş yapabilirler.
- **Kargo Takibi**
  - Kargo ID'si ile kargo durumunu sorgulayabilirler.
- **Kargo Geçmişi**
  - Gönderdikleri ve aldıkları kargoları görüntüleyebilirler.
- **Hesap Yönetimi**
  - Kendi hesap bilgilerini güncelleyebilirler.

### 2. Admin Kullanıcı
- **Kargo Yönetimi**
  - Tüm kargoları görüntüleyebilir, düzenleyebilir ve silebilirler.
- **Kargo Durumu Güncelleme**
  - Kargo durumlarını güncelleyebilirler: "Onay Bekliyor", "Onaylandı", "Yola Çıktı", "Dağıtımda", "Ulaştı".
- **Kargo Konumu Yönetimi**
  - Kargo konumlarını Google Maps üzerinden güncelleyebilirler.

## Uygulama Özellikleri

### 1. Kargo Takip Sistemi
- **Kargo Durumu Sorgulama**
  - Kullanıcılar, ana sayfadaki kargo takip formunu kullanarak kargo ID'si ile kargo durumunu sorgulayabilirler.

### 2. Kargo Geçmişi
- **Gönderilen ve Alınan Kargoların Görüntülenmesi**
  - Kullanıcılar, gönderilen ve alınan kargoları geçmiş bölümünden görüntüleyebilirler.
  - Kargolar, gönderim tarihine göre sıralanır ve detaylı bilgileri içerir.

### 3. Admin Paneli
- **Kargo Listesi**
  - Admin kullanıcılar, tüm kargoların listesini görüntüleyebilirler.
  - Kargo ID, durum, gönderim tarihi, alıcı adı, alıcı soyadı, alıcı kimlik numarası, adres ve gönderen bilgilerini içerir.
- **Kargo Düzenleme ve Silme**
  - Admin kullanıcılar, kargoları düzenleyebilir veya silebilirler.
  - Kargo silindiğinde durumu "İptal Edildi" olarak güncellenir.
- **Kargo Durumu Filtreleme**
  - Admin kullanıcılar, kargoları durumlarına göre filtreleyebilirler.

### 4. Google Maps Entegrasyonu
- **Kargo Konumlarının Gösterimi**
  - Kullanıcılar ve adminler, kargo konumlarını harita üzerinde görüntüleyebilirler.
  - Admin kullanıcılar, kargo konumlarını güncelleyebilirler.

## Kullanım Adımları

### 1. Kayıt Olma ve Giriş Yapma
- **Kayıt Olma**
  - Ana sayfadan "Kayıt Ol" butonuna tıklayın ve gerekli bilgileri doldurarak kayıt olun.
- **Giriş Yapma**
  - Kayıt olduktan sonra "Giriş Yap" butonuna tıklayın ve kullanıcı bilgilerinizi girerek giriş yapın.

### 2. Kargo Takibi
- **Ana Sayfadan Kargo Sorgulama**
  - Ana sayfada bulunan "Kargo Takip Kodu ile Sorgula" kartına kargo ID'sini girin ve "Sorgula" butonuna tıklayın.
  - Kargo durumu ekranda gösterilecektir.

### 3. Kargo Geçmişi
- **Geçmişi Görüntüleme**
  - Kullanıcı menüsünden "Kargo Geçmişi" butonuna tıklayın.
  - Gönderilen ve alınan kargoların listesi ekranda görüntülenecektir.

### 4. Admin Paneli
- **Kargoları Yönetme**
  - Admin olarak giriş yaptıktan sonra menüden "Admin Paneli" butonuna tıklayın.
  - Tüm kargoların listesi ekranda görüntülenecektir.
- **Kargo Durumu Güncelleme**
  - Listede düzenlemek istediğiniz kargonun yanında bulunan "Düzenle" butonuna tıklayın.
  - Kargo bilgilerini güncelleyip "Kaydet" butonuna tıklayın.
- **Kargo Silme**
  - Listede silmek istediğiniz kargonun yanında bulunan "Sil" butonuna tıklayın.
  - Kargo silindiğinde durumu "İptal Edildi" olarak güncellenir.
- **Kargo Durumu Filtreleme**
  - Kargo durumuna göre listeyi filtrelemek için arama alanını kullanın.

## Sonuç
Kargo Takip Uygulaması, kullanıcıların kargolarını etkili bir şekilde takip edebilmeleri ve yönetebilmeleri için kapsamlı bir çözüm sunmaktadır. Kullanıcı dostu arayüzü, Google Maps entegrasyonu ve admin paneli ile güçlü bir işlevsellik sağlamaktadır. Bu proje, modern web teknolojileri kullanılarak geliştirilmiş olup, kullanıcıların ihtiyaçlarını karşılamak için tasarlanmıştır.

Proje hakkında daha fazla bilgi ve ayrıntı için proje dosyalarını ve kodları inceleyebilirsiniz. Teşekkürler!

## Ekran Alıntıları

![Screenshot_1](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/941d9ed2-5f9f-48db-9f40-870136be8532)
![Screenshot_2](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/449eb91a-5d40-4c5b-85b3-866deba62b33)
![Screenshot_3](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/ffd503ef-b6d9-4f6c-9368-2ebd16853829)
![Screenshot_4](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/ab1b7d1e-5fb2-46ab-9a86-f0601bc0ab65)
![Screenshot_5](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/1111e354-e58d-4105-96e0-6f1db6e2239f)
![Screenshot_6](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/adc0c624-7e38-4b27-89ff-9ec204fd701d)
![Screenshot_7](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/2fea1cbe-bbe4-4e16-b71a-0254d74f79cc)
![Screenshot_8](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/808f633c-b8dc-4245-8820-106b792c4473)
![Screenshot_9](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/c48c38b4-6393-406d-a37a-2b9c044b8824)
![Screenshot_10](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/c8085185-702f-4ea8-9870-623cf4f57798)
![Screenshot_11](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/2a78ed4f-5df8-457d-bcda-6e06316a32da)
![Screenshot_12](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/b0cab7a8-bf0e-461b-9588-dbce9e98ff7c)
![Screenshot_13](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/8abb1fe9-5373-4c45-a4e7-d23a49a026b6)
![Screenshot_14](https://github.com/ikliasaraya/BitirmeProjesi-KargoTakipUygulamas-ASPNET/assets/65564309/105f23ab-d099-4aca-8f62-0cb916446e5b)




