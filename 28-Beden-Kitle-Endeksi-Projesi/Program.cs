using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Beden_Kitle_Endeksi_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden Kitle İndeksi Hesaplama Programı");

            // Kullanıcıdan boy bilgisini al
            Console.Write("Boyunuzu metre cinsinden girin (örnek: 1,75): ");
            double boy = Convert.ToDouble(Console.ReadLine());

            // Kullanıcıdan kilo bilgisini al
            Console.Write("Kilonuzu kilogram cinsinden girin (örnek: 70): ");
            double kilo = Convert.ToDouble(Console.ReadLine());

            // BKİ hesaplama formülü: kilo / (boy * boy)
            double bki = kilo / (boy * boy);

            Console.WriteLine($"\nBeden Kitle İndeksiniz: {bki:F2}");

            // BKİ'ye göre sonuç analizi
            if (bki < 18.5)
            {
                Console.WriteLine("Sonuç: Zayıf");
            }
            else if (bki >= 18.5 && bki < 24.9)
            {
                Console.WriteLine("Sonuç: Normal kilolu");
            }
            else if (bki >= 25 && bki < 29.9)
            {
                Console.WriteLine("Sonuç: Fazla kilolu");
            }
            else
            {
                Console.WriteLine("Sonuç: Obez");
            }

            // Program sonlanmasın diye bekleme
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}