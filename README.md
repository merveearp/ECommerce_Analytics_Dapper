# 🚀 E-Commerce Big Data Analytics Dashboard

<p align="center">
  <b>📊 Big Data • ⚡ High Performance • 🌍 Advanced Analytics</b>
</p>

---

## 🧾 📌 Proje Hakkında

Bu proje, **yüksek hacimli (~3M kayıt)** e-ticaret verileri üzerinde çalışan, performans odaklı bir **analitik dashboard** uygulamasıdır.  

💡 ASP.NET Core **.NET 8** + Dapper kullanılarak geliştirilmiş olup, büyük veri setleri üzerinde:

- ⚡ Hızlı veri erişimi  
- 📊 Gerçekçi analiz  
- 📈 Gelişmiş görselleştirme  

sağlanmıştır.

---

## 🖼️ 📊 Dashboard Görselleri

### 📌 Genel Dashboard (Overview)
<img width="1920" height="4500" alt="fullscreen-home" src="https://github.com/user-attachments/assets/39290c74-ee3d-4ac7-a03a-4bd14175882b" />


### 📈 Satış & Ciro Analizi Dashboard

<img width="1920" height="5626" alt="fullscreen-dashboard1" src="https://github.com/user-attachments/assets/fb440e9e-edbd-48f3-917d-7d4d5759e1c4" />

### 🌍 Global Ülke & Müşteri Analizi Dashboard
<img width="1920" height="4086" alt="fullscreen-dashboard2" src="https://github.com/user-attachments/assets/dc1698bc-a882-425f-9400-b703fef404db" />


## 🧠 📦 Veri Seti (Big Data)

Bu projede kullanılan veri seti:

- 🤖 **Tamamen yapay zeka ile üretilmiştir**
- 🚫 **Hiçbir dış kaynak kullanılmamıştır**
- 🎯 **Gerçek e-ticaret senaryolarına göre modellenmiştir**

---

## 📊 📊 Veri Hacmi

| 📌 Tablo | 📈 Kayıt Sayısı |
|---------|---------------|
| 🌍 Countries | 10 |
| 🏙️ Cities | 32 |
| 🧩 Categories | 16 |
| 📦 OrderStatuses | 5 |
| 💳 PaymentTypes | 4 |
| 🛍️ Products | **51.000** |
| 👥 Customers | **300.000** |
| 📑 Orders | **900.050** |
| 📄 OrderDetails | **1.720.000** |
| 🚀 **Toplam Veri** | **~3.000.000+ kayıt** |

---
![query](https://github.com/user-attachments/assets/22d86cbf-fa42-49da-b877-32a461384b9f)


## 📈 📉 Veri Modeli Özellikleri

- 📅 2025 → Günümüz zaman dağılımı  
- 📊 Mevsimsellik & kampanya etkisi  
- 🛒 Gerçekçi sipariş akışı  

### 💳 Ödeme Tipleri
- 💳 Kredi Kartı  
- 💳 Banka Kartı  
- 💵 Nakit  
- 🏦 Havale / EFT  

### 📦 Sipariş Durumları
- ⏳ Beklemede  
- ✅ Onaylandı  
- 🚚 Kargoya Verildi  
- 📬 Teslim Edildi  
- ❌ İptal Edildi  

---

## ⚡ 🛠️ Kullanılan Teknolojiler

- 🧱 ASP.NET Core **.NET 8**
- ⚡ Dapper (High Performance ORM)
- 🗄️ SQL Server
- 📊 Chart.js
- 📉 Plotly.js
- 🌍 jsVectorMap

---

## 🚀 ⚙️ Performans Optimizasyonu

### ⚡ Dapper Kullanımı
- ORM yerine ultra hızlı veri erişimi  
- Minimum resource kullanımı  

### 🧠 SQL Optimizasyonları
- Optimize edilmiş JOIN’ler  
- Aggregation query tuning  
- Gereksiz veri çekiminin kaldırılması  

### 📌 Index Kullanımı

```sql
CREATE INDEX IX_Orders_OrderDate ON Orders(OrderDate);
CREATE INDEX IX_OrderDetails_OrderId ON OrderDetails(OrderId);
CREATE INDEX IX_Customers_CityId ON Customers(CityId);
CREATE INDEX IX_Products_CategoryId ON Products(CategoryId);
```

---

## 📊 📊 Dashboard Özellikleri

### 📌 Genel Dashboard
- 👥 Toplam müşteri  
- 📦 Sipariş sayısı  
- 🛍️ Ürün sayısı  
- 📊 Sipariş durum dağılımı  
- 📈 Trend analizleri  
- 💰 Kar marjı  

---

### 📈 Satış & Ciro Analizi
- 📅 2024 vs 2025 karşılaştırma  
- 💰 Aylık ciro analizi  
- 💳 Ödeme tipine göre dağılım  
- 🧩 Kategori bazlı satış  
- 🏆 En çok satan ürünler  

---

### 🌍 Global Analiz Dashboard
- 🌎 Ülke bazlı sipariş dağılımı  
- 🗺️ Dünya haritası analizleri  
- 🏙️ Şehir bazlı müşteri yoğunluğu  
- 💰 Ülke bazlı ciro  

---

## 📊 📉 Veri Görselleştirme

- 📈 Line Charts  
- 🍩 Doughnut Charts  
- 📊 Bar Charts  
- 🌍 Map Visualizations  

---

## 🤖 🧠 Yapay Zeka ile Veri Üretimi

✔ Rastgele veri değil  
✔ Senaryolu veri üretimi  
✔ Gerçekçi ticaret davranışı  

### İçerdiği dinamikler:

- 🎯 Kampanya etkileri  
- 📉 Sezonluk değişimler  
- 📦 Stok dalgalanmaları  
- 🌍 Ülke bazlı alışkanlık farkları  

---

## 🧩 🏗️ Mimari Yapı

- 🧱 Repository Pattern  
- ⚡ Dapper Query Layer  
- 📦 DTO yapıları  
- 🧩 Modüler dashboard bileşenleri  

---

## 🎯 🚀 Proje Amacı

- 📊 Big Data deneyimi kazanmak  
- ⚡ Performanslı veri işlemek  
- 📈 Gerçekçi dashboard geliştirmek  
- 💼 Data Analyst / BI Developer portföyü oluşturmak  

---

## 👩‍💻 Geliştirici

**Merve Arpacıoğlu Türk**  
💻 Full Stack .NET Developer  

---

## ⭐ Not

> Bu proje, klasik CRUD uygulamalarından farklı olarak  
> **gerçek veri analizi ve büyük veri performansı üzerine odaklanmıştır.**
