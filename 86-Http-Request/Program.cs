using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // HttpClient nesnesi oluştur
        HttpClient client = new HttpClient();

        // İstek yapılacak URL
        string url = "https://jsonplaceholder.typicode.com/posts/1";

        try
        {
            // HTTP GET isteği gönder
            HttpResponseMessage response = await client.GetAsync(url);

            // Yanıtın başarılı olup olmadığını kontrol et
            if (response.IsSuccessStatusCode)
            {
                // Yanıt içeriğini oku
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Yanıt:");
                Console.WriteLine(responseBody);
            }
            else
            {
                Console.WriteLine($"Hata: {response.StatusCode}");
            }
        }
        catch (Exception ex)
        {
            // Hata durumlarını yakala
            Console.WriteLine($"Bir hata oluştu: {ex.Message}");
        }
    }
}
