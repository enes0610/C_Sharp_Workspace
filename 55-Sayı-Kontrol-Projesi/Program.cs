using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55-Sayı-Kontrol-Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi içinde Sayı Kontrol Uygulaması

            int[] sayilar = { 0, 0, 5, 10, 10, 25, 50, 75, 100, 100, 10, 25, 50 };

            int adet = 0;
            int sayi;

            Console.WriteLine("Lütfen Sayı Giriniz: ");

            sayi = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++)
            {
                if(sayi == sayilar[i])
                {
                    adet++;
                }
            }
            if(adet == 0)
            {
                Console.WriteLine("Hatalı Sayı Girdiniz...");
            }
            else
            {
                Console.WriteLine("Sayı Dizide Vardır...");
                Console.WriteLine("Adet: " + adet);
            }
            Console.ReadLine();
        }
    }
}