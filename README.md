# JsonReceiptExtractor

Bu proje, C# dilinde yazılmıştır ve bir JSON dosyasındaki verileri okuma ve işleme sürecini göstermektedir. Newtonsoft.Json kütüphanesi kullanılarak JSON verileri C# nesnelerine dönüştürülmektedir.

## Kullanım

1. Projeyi bilgisayarınıza indirin.
2. İşlem yapmak istediğiniz JSON dosyasını `ResponseJsonFiles` klasörüne ekleyin. Dosya adını "response.json" olarak belirtmelisiniz.
3. Proje dosyalarınızın bulunduğu dizinde terminal veya komut istemcisini açın.
4. `dotnet run` komutunu kullanarak programı çalıştırın.
5. Program, JSON dosyasındaki verileri okuyacak ve ekrana yazdıracaktır.

## Önemli Notlar

- JSON dosyasının adı "response.json" olmalıdır.
- JSON veri yapısı, `JsonModel` sınıfına uygun olmalıdır.
- Koordinat verileri, `int[]` tipinde olmalı ve dört index içermelidir.

## Proje Yapısı

- **Program.cs**: JSON verilerini okuyan ve işleyen ana uygulama dosyası.
- **JsonModel.cs**: JSON verilerinin deserialize edilmesi için kullanılan sınıf.

## Gereksinimler

- [.NET SDK](https://dotnet.microsoft.com/download) (Sürüm: 6.0 veya üstü)
- [Newtonsoft.Json](https://www.newtonsoft.com/json) (Kurulum: `dotnet add package Newtonsoft.Json`)
