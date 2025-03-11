# Kütüphane Otomasyon Sistemi
![image](https://github.com/user-attachments/assets/93057c74-c3da-4c82-8800-7606a6e9c5ee)

Bu proje, C# programlama dili kullanılarak geliştirilmiş, nesne yönelimli programlama (OOP) prensiplerini uygulayan bir kütüphane otomasyon sistemidir. Sistem, kitapların ödünç alınması ve iade edilmesi işlemlerini yönetmek için tasarlanmıştır.

## Özellikler

- Farklı türde kitapların (Bilim, Roman, Tarih) yönetimi
- Üye kaydı ve yönetimi
- Kitap ödünç alma/iade etme işlemleri
- Kitap ve üye listeleme
- Ödünç durumu takibi

## Sistem Mimarisi

Proje aşağıdaki ana bileşenlerden oluşmaktadır:

1. **Kitap (Abstract Class)**: Tüm kitap türleri için temel sınıf
2. **Durum (Enum)**: Kitapların durumunu belirten enum (FitForBorrowing, OutOfStock)
3. **KitapBilim, KitapRoman, KitapTarih (Sub Class)**: Kitap türleri
4. **IUye (Interface)**: Üye sınıfı için arayüz
5. **Uye (Class)**: IUye arayüzünü uygulayan sınıf
6. **Kutuphane (Class)**: Kitap ve üye yönetimini sağlayan ana sınıf

## Kurulum

### Gereksinimler

- .NET 8.0 SDK veya daha yeni bir sürüm
- Visual Studio 2022 veya başka bir C# IDE'si (isteğe bağlı)

### Projeyi Çalıştırma

#### Doğrudan .NET CLI Kullanarak:

1. Repo'yu klonlayın:
   ```
   git clone https://github.com/huseyinTalo/LibraryAutomation.git
   cd LibraryAutomation
   ```

2. Uygulamayı derleyin:
   ```
   dotnet build
   ```

3. Uygulamayı çalıştırın:
   ```
   dotnet run --project LibraryAutomation.CLI
   ```

#### Visual Studio Kullanarak:

1. `LibraryAutomation.sln` dosyasını Visual Studio'da açın
2. F5 tuşuna basarak projeyi derleyin ve çalıştırın

### Docker Kullanarak:

Projeyi Docker ile çalıştırmak için:

1. Docker'ı yükleyin (https://www.docker.com/products/docker-desktop)
2. Repo'yu klonlayın
3. Terminal veya komut istemcisinde aşağıdaki komutu çalıştırın:
   ```
   docker-compose run -it --rm library-automation
   ```

## Kullanım

Program başlatıldığında, aşağıdaki menü seçenekleri görüntülenir:

1. **Yeni Kitap Ekle**: Farklı türlerde (Tarih, Roman, Bilim) kitap ekleyebilirsiniz
2. **Yeni Üye Ekle**: Kütüphaneye yeni bir üye kaydı yapabilirsiniz
3. **Kitap Listesini Görüntüle**: Kütüphanedeki tüm kitapları listeler
4. **Üye Listesini Görüntüle**: Kayıtlı tüm üyeleri listeler
5. **Kitap Ödünç Al**: Üyeler için kitap ödünç alma işlemi
6. **Kitap İade Et**: Ödünç alınan kitapları iade etme işlemi
7. **Çıkış**: Programdan çıkış

Her menü seçeneği için detaylı talimatlar program içinde verilmektedir.

## Proje Yapısı

```
LibraryAutomation/
├── LibraryAutomation.Base/         # Temel sınıflar ve mantık
│   ├── Entities/
│   │   ├── Abstract/               # Soyut sınıflar ve arayüzler
│   │   │   ├── Book.cs             # Kitap soyut sınıfı
│   │   │   └── IMember.cs          # Üye arayüzü
│   │   └── Concrete/               # Somut sınıf uygulamaları
│   │       ├── BookHistory.cs      # Tarih kitabı sınıfı
│   │       ├── BookNovel.cs        # Roman kitabı sınıfı
│   │       ├── BookScience.cs      # Bilim kitabı sınıfı
│   │       ├── Library.cs          # Kütüphane sınıfı
│   │       └── Member.cs           # Üye sınıfı
│   └── Utilities/
│       └── Status.cs               # Durum enum'u
└── LibraryAutomation.CLI/          # Konsol uygulaması
    ├── Docker/                     # Docker yapılandırması
    │   └── Dockerfile
    └── Program.cs                  # Ana program
```

## Teknik Detaylar

- **Guid Kullanımı**: Her kitap ve üye için benzersiz kimlikler
- **Veri Doğrulama**: Giriş doğrulama kontrolleri (ör. ISBN, stok miktarı)
- **String Biçimlendirme**: Ad ve başlıklar için otomatik biçimlendirme
- **Durum Kontrolü**: Kitap ödünç verilebilirlik durumu yönetimi
- **Stok Takibi**: Kitap stok miktarı otomatik azaltma/artırma
