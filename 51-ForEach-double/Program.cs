using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_ForEach_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = { 5.55, 3.77, 6.48, 9.11 };

            foreach(double sayi in sayilar)
            {
                Console.WriteLine("Sayılar: " + sayi);
            }
            Console.ReadLine();
        }
    }
}