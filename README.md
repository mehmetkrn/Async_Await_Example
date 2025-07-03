# ☕️🍵 Async Await Örneği – Çay & Kahve Hazırlama Simülasyonu 🍵☕️

Bu Windows Forms uygulaması, **C# async/await** yapısını kullanarak **çay ve kahve hazırlama** işlemlerini **eşzamanlı ve asenkron** şekilde simüle eder.  
Amacımız, gerçek hayattan bir örnekle **asenkron programlamanın gücünü göstermek!**

---

## 🚀 Projenin Öne Çıkan Özellikleri

- 🟠 **Çay ve Kahve işlemleri paralel** olarak başlar ve farklı adımlarla devam eder.  
- ⏳ Her adımda 2 saniyelik gecikme ile gerçek zamanlı işlem simülasyonu yapılır.  
- 🎨 Buton renkleri ile işlem durumu görselleştirilir:  
  - Turuncu = İşlem başladı  
  - Yeşil = İşlem bitti  
- 📜 İşlem adımları **log olarak ListBox**'a anlık eklenir.  
- ⏱️ Toplam işlem süresi hesaplanır ve kullanıcıya gösterilir.

---

## 🔍 Proje Detayları

### 🫖 Çay Hazırlama Adımları
1. Su koyuldu  
2. Su kaynadı  
3. Çay koyuldu  
4. Kaynar su eklendi  
5. Çay demlendi  

### ☕ Kahve Hazırlama Adımları
1. Su koyuldu  
2. Kahve koyuldu  
3. Karıştırıldı  
4. Kaynatıldı  

### 🍽️ Servis
- Çay ve kahve hazırlandıktan sonra servis edilir.

---

## ⚙️ Nasıl Çalışır?

1. **`BtnHazirla`** butonuna tıklayın.  
2. Çay ve kahve işlemleri eş zamanlı başlar ve kendi adımlarını yürütür.  
3. Adım adım loglar ListBox'ta görünür.  
4. İşlemler tamamlandığında buton renkleri yeşile döner ve toplam süre loglanır.

---

## 🛠️ Teknolojiler & Metodlar

- **C#** (.NET Framework)  
- **Windows Forms** UI  
- **Async / Await** ile asenkron programlama  
- **Task.Delay** ile işlem simülasyonu  

---
 
 
