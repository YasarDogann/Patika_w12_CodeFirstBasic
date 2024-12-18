# Pratik - Code First Basic
Merhaba,
Bu proje C# ile Patika+ 12.hafta CodeFirstBasic MVC uygulaması için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- MVC Yapısını kullanmak ve anlamak
- ASP.NET Core Kullanmak
- Entity Framework Kullanmak

 
## İstenilen Görev: 
Code First Yaklaşımı ile Veri Tabanı Oluşturma

Entity Framework Core kullanarak Code First yaklaşımıyla bir veri tabanı oluşturmanız gerekiyor. Bu veri tabanında, aşağıdaki iki bağımsız veri tablosu bulunmalıdır:

   1. Movie Tablosu:

        - `Id`: int, birincil anahtar ve otomatik artan.

        - `Title`: string, filmin başlığı.

        - `Genre`: string, filmin türü (örneğin: "Action", "Comedy", "Drama").

        - `ReleaseYear`: int, filmin çıkış yılı.

   2. Game Tablosu:

        - `Id`: int, birincil anahtar ve otomatik artan.

        - `Name`: string, oyunun adı.

        - `Platform`: string, oyunun oynandığı platform (örneğin: "PC", "PlayStation", "Xbox").

        - `Rating`: decimal, oyunun puanı (0 ile 10 arasında).

Context sınıfımızın ismi PatikaFirstDbContext olsun.
Veritabanı ismi PatikaCodeFirstDb1 olsun.
Veritabanında tablolar Movies ve Games olsun.
