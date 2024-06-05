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
  - Hassas bilgiler sansürlenmiş olarak gösterilir (örneğin, alıcı adı: "Al**", soyadı: "Sar****").

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
