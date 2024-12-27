using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59_Method_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method'lar ile Sayı Tek mi Çift mi Bulma
            Console.Write("Sayı Girin: ");
            int sayideger = int.Parse(Console.ReadLine());
            TekCift(sayideger);
            Console.ReadLine();
        }

        static void TekCift(int sayi)
        {
            if(sayi %2 == 0)
            {
                Console.WriteLine("Sayı Çifftir");
            }
            else
            {
                Console.WriteLine("Sayı Tektir");
            }
        }

    }
}