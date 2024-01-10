using JsonReceiptExtractor.Models;
using System.Text;
using System.Text.Json;

namespace JsonParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proje dizini ve JSON dosya bilgilerini alırız.
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonFileName = "response.json";
            string jsonFile = "ResponseJsonFiles";
            string jsonFilePath = Path.Combine(projectDirectory, jsonFile, jsonFileName);

            //dosya belirtilen yerde mevcut mu bakılır.
            if (File.Exists(jsonFilePath))
            {
                //JSON dosyası okunur.
                string jsonResponse;
                using (StreamReader reader = new StreamReader(jsonFilePath, Encoding.UTF8))
                {
                    jsonResponse = reader.ReadToEnd();
                }

                //JSON verisi kullanılabilir hale getirilir.
                var jsonObj = JsonSerializer.Deserialize<JsonModel>(jsonResponse);

                //Çıktı için modelden okuma yapılır.
                Console.WriteLine("line | text");
                for (int i = 0; i < jsonObj.lines.Count; i++)
                {
                    Console.WriteLine($"{i + 1} | {jsonObj.lines[i].description}");
                }
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı.");
            }
        }
    }

}
