using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int harf1 = 'A';
            int harf2 = 'A';

            int sayi1 = 99;
            int sayi2 = 11;

            bool kontrol = harf1 == harf2;
            bool sonuc = sayi1 == sayi2;

            Console.WriteLine(kontrol);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}