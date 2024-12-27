using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Veya_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Her iki koşuldan biri TRUE ise sonuç TRUE olur.
            // Eğer iki koşuldan biri TRUE birisi FALSE ise sonuç FALSE olur.

            int sayi = 2;
            int sayi2 = 2;
            int sayi3 = 6;

            bool sonuc = sayi == sayi2 || sayi > sayi3;

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}