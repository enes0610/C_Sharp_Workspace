using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_ForEach_örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sesli Harf Sayısı Bulma

            char[] harfler = { 'a', 'd', 'e', 'b', 'i', 'z', 'ö', 's' }; // 4 adet sesli harf
            int sesliHarf = 0;

            foreach(char harf in harfler)
            {
                if("aeiö".Contains(harf))
                {
                    sesliHarf++;
                }
            }
            Console.WriteLine("Harf Sayısı: " + sesliHarf++);
            Console.ReadLine();
        }
    }
}