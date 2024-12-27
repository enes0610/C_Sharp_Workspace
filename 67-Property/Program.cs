using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi();

            kisi.kilo = 42;
            kisi.kilo1 = 75;

            Console.WriteLine("Property Kilo: " + kisi.kilo);
            Console.WriteLine("Değişken Kilo: " + kisi.kilo1);
            Console.ReadLine();
        }
    }
}