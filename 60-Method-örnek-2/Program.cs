using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60_Method_örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Büyük olan Sayıyı Ekrana Yazdırma

            Console.WriteLine("Sayı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            kontrol(sayi1, sayi2);
            Console.ReadLine();
        }

        static void kontrol(int a, int b)
        {
            if(a > b)
            {
                Console.WriteLine("1. Sayı 2. Sayı'dan Büyüktür.");
            }
            else if(a == b)
            {
                Console.WriteLine("İki sayı'da Eşittir");
            }
            else
            {
                Console.WriteLine("1.Sayı 2. Sayı'dan Küçüktür.");
            }
        }
    }
}