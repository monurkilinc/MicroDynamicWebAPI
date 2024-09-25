# MicroDynamic Web API

MicroDynamic Web API, mikroservis mimarisi kullanılarak geliştirilmiş, .NET 8 tabanlı bir web API projesidir. Bu proje, modern web uygulamaları için ölçeklenebilir ve sürdürülebilir bir backend altyapısı sunmayı amaçlamaktadır.

## Özellikler

- .NET 8 framework kullanımı
- Mikroservis mimarisi
- Entity Framework Core ile veritabanı işlemleri
- Swagger UI ile API dokümantasyonu
- Docker desteği

## Başlangıç

Bu bölümde, projeyi yerel makinenizde nasıl çalıştıracağınıza dair adımlar bulunmaktadır.

### Gereksinimler

- .NET 8 SDK
- Docker (opsiyonel)
- SQL Server veya PostgreSQL

### Kurulum

1. Repoyu klonlayın:
   ```
   git clone https://github.com/monurkilinc/MicroDynamicWebAPI.git
   ```

2. Proje dizinine gidin:
   ```
   cd MicroDynamicWebAPI
   ```

3. Bağımlılıkları yükleyin:
   ```
   dotnet restore
   ```

4. Veritabanını oluşturun:
   ```
   dotnet ef database update
   ```

5. Projeyi çalıştırın:
   ```
   dotnet run
   ```

## Kullanım

API'yi çalıştırdıktan sonra, `https://localhost:5001/swagger` adresinden Swagger UI'a erişebilir ve API endpoint'lerini test edebilirsiniz.

## Katkıda Bulunma

1. Bu repoyu fork edin
2. Feature branch'i oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Bir Pull Request oluşturun

## İletişim

M.Onur Kılınç 
https://github.com/monurkilinc
https://www.linkedin.com/in/monurkilinc00

Proje Linki
[https://github.com/monurkilinc/MicroDynamicWebAPI]
