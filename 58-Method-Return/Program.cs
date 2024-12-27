using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_Method_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deger = AdSoyad("ENES", "OĞUZ");
            Console.WriteLine("Ad Soyad: " + deger);
            Console.ReadLine();
        }

        static string AdSoyad(string isim, string soyad)
        {
            return isim + " " + soyad;
        }

    }
}