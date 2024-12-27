using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_ForEach_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liste Elemanlarının Toplamını Hesaplama

            double[] sayilar = { 11, 14.5, 36.4, 39 };
            double toplam = 0;

            foreach(double sayı in sayilar)
            {
                toplam += sayı;
            }
            Console.WriteLine("Toplam: " + toplam);
        }
    }
}