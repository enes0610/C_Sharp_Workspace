using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();

            araba.arabaMarka = "SEAT";
            araba.arabaModel = "LEON";
            araba.arabaRenk = "Beyaz";
            araba.kapiSayisi = 4;

            araba.motorCalistir();
            araba.kapıKilit();

            Console.WriteLine("Araba Markası: " + araba.arabaMarka);
            Console.WriteLine("Araba Modeli: " + araba.arabaModel);
            Console.WriteLine("Araba Rengi: " + araba.arabaRenk);
            Console.WriteLine("Araba Kapı Sayısı: " + araba.kapiSayisi);
        }
    }
}