# 🍴 Yummy Restaurant

> 🎓 Bu proje, **Murat Yücedağ** hocamızın hazırladığı Youtube'da bulunan 

> **"Api Proje Kampı"** eğitim serisi kapsamında geliştirilmiştir.

[📺 Eğitim serisine buradan ulaşabilirsiniz](https://youtube.com/playlist?list=PLKnjBHu2xXNOzMUJ4I57MgWUKCzyZMH03&si=7JpPw8-fdI8KKo7w)

---

## 📋 Proje Hakkında

Bu proje, ASP.NET Core 6.0 ve Entity Framework Core kullanılarak geliştirilmiş restoran yönetim sistemidir. Uygulama, Code First yaklaşımıyla tasarlanmış olup Microsoft SQL Server veritabanı üzerinde çalışmaktadır.

Yummy Restaurant Management System, hem müşteriler hem de yöneticiler için kapsamlı bir platform sunar. Müşteriler; rezervasyon yapma, menüyü görüntüleme, iletişim kurma ve yapay zeka destekli gerçek zamanlı sohbet özelliklerini kullanabilirken, yöneticiler admin paneli üzerinden tüm restoran süreçlerini merkezi bir yapıdan yönetebilmektedir.

Projenin en önemli özelliklerinden biri, SignalR entegrasyonu sayesinde gerçek zamanlı veri akışı sağlamasıdır. Rezervasyon, mesaj, bildirim veya istatistik gibi kritik aksiyonlar anında sisteme yansıtılır ve admin paneline bağlı tüm kullanıcılar için eş zamanlı olarak güncellenir. Bu sayede işletme sahipleri, restoranın anlık durumunu canlı olarak takip edebilir.

Sistem, OpenAI entegrasyonu ile yapay zeka destekli özellikler sunar. Müşteri mesajlarına otomatik cevap üretme, yemek tarifi önerileri ve günlük menü önerileri gibi AI destekli özellikler restoran yönetimini daha modern ve verimli hale getirmektedir. Ayrıca, Hugging Face API entegrasyonu ile mesajların toksiklik kontrolü yapılmakta ve zararlı içerikler otomatik olarak tespit edilmektedir.

Bu proje, ASP.NET Core, SignalR, OpenAI API ve Hugging Face API kullanılarak gerçek zamanlı sistemlerin nasıl geliştirilebileceğini gösteren, hem kullanıcı hem de admin tarafını kapsayan yapısıyla, gerçek hayatta karşılaşılabilecek senaryolara hazırlık sağlamak ve öğrenme amacıyla tasarlanmıştır.

---

## 🛠️ Kullanılan Teknolojiler

### 📌 Backend

- **ASP.NET Core 6.0**
- **ASP.NET Core Web API**
- **ASP.NET Core MVC**
- **Entity Framework Core** (Code First yaklaşımı)
- **MS SQL Server**
- **SignalR**
- **REST API**
- **AutoMapper**
- **FluentValidation**
- **Swagger**
- **OpenAI API** (Yapay zeka entegrasyonu - GPT-4o-mini, GPT-3.5-turbo)
- **Hugging Face API** (Çeviri ve toksiklik kontrolü)
- Helsinki-NLP/opus-mt-tr-en (Türkçe-İngilizce çeviri)
- unitary/toxic-bert (Toksiklik tespiti)
- **Dependency Injection**

### 📌 Frontend

- **HTML5**
- **CSS3**
- **JavaScript**
- **Bootstrap**
- **jQuery**
- **SignalR JavaScript Client**
- **Chart.js**

---

## 📌 Katmanlar

- **Web API Layer** - RESTful API servisleri
- **Web UI Layer** - MVC tabanlı admin ve kullanıcı arayüzü
- **Entity Layer** - Veritabanı entity'leri
- **Dto Layer** - Data Transfer Objects

## 📌 Öne Çıkan Özellikler

### 🤖 Yapay Zeka Özellikleri

- ✅ **OpenAI Entegrasyonu**
  - SignalR streaming ile gerçek zamanlı AI sohbeti (GPT-4o-mini)
  - Müşteri mesajlarına otomatik cevap üretme (GPT-3.5-turbo)
  - Günlük menü önerileri (4 farklı dünya mutfağından)
  - Yemek tarifi önerileri (malzemelere göre)

- ✅ **Hugging Face Entegrasyonu**
  - Otomatik mesaj çevirisi (Türkçe → İngilizce)
  - Toksiklik kontrolü (Toxic-BERT modeli)
  - Zararlı içerik tespiti ve otomatik filtreleme

### 🚀 SignalR Özellikleri

- ✅ Gerçek zamanlı bildirimler ve mesajlaşma
- ✅ SignalR streaming ile token bazlı AI yanıtları
- ✅ Anlık istatistiklerin görüntülenmesi
- ✅ Rezervasyon durumu değişikliklerinin anlık güncellenmesi

### 📊 İstatistik ve Raporlama

- ✅ Anlık istatistikler (Ürün, Rezervasyon, Şef, Misafir sayıları)
- ✅ Rezervasyon istatistikleri ve aylık grafikler

---

## 🖼️ Ekran Görüntüleri

### 🏠 Ana Sayfa

<div align="center">
  <img src="ApiProje/Images/AnaSayfa-1.png" alt="Ana Sayfa-1" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Anasayfa-2.png" alt="Ana Sayfa-2" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-3.png" alt="Ana Sayfa-3" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-4.png" alt="Ana Sayfa-4" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-5.png" alt="Ana Sayfa-5" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-6.png" alt="Ana Sayfa-6" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-7.png" alt="Ana Sayfa-7" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-8.png" alt="Ana Sayfa-8" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/AnaSayfa-9.png" alt="Ana Sayfa-9" width="800" style="margin: 10px;">

</div>

### 🔐 Admin Paneli

<div align="center">
  <img src="ApiProje/Images/Dashboard-1.png" alt="Admin Paneli-1" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-2.png" alt="Admin Paneli-2" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-3-AIDailyMenu.png" alt="Admin Paneli-3" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-4.png" alt="Admin Paneli-4" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-5.png" alt="Admin Paneli-5" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-6.png" alt="Admin Paneli-6" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-7.png" alt="Admin Paneli-7" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-8.png" alt="Admin Paneli-8" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-9.png" alt="Admin Paneli-9" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-10.png" alt="Admin Paneli-10" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-11.png" alt="Admin Paneli-11" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-12.png" alt="Admin Paneli-12" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-13.png" alt="Admin Paneli-13" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-14.png" alt="Admin Paneli-14" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-15.png" alt="Admin Paneli-15" width="800" style="margin: 10px;">
  <img src="ApiProje/Images/Dashboard-16-OpenAI.png" alt="Admin Paneli-16" width="800" style="margin: 10px;">
</div>

### 🗄️ Database Diyagram

<div align="center">
  <img src="ApiProje/Images/DatabaseDiagram.png" alt="Database Diyagram" width="1000" style="margin: 10px;">
</div>
