using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Eşit_Değil_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi0 = 3;
            int sayi1 = 8;
            bool kontrol = sayi0 != sayi1;

            int sayi2 = 5;
            int sayi3 = 5;
            bool sonuc = sayi2 != sayi3;

            Console.WriteLine(kontrol);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}