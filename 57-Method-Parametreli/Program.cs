using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_Method_Parametreli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre Alır Geriye Değer Döndürmez
            Toplama(5,15);
        }
        
        static void Toplama(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayıların Toplamı: " + (sayi1 + sayi2));
            Console.ReadLine();
        }
    }
}