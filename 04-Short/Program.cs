using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short sayi1 = 25;
            short sayi2 = 75;

            short minDeger = short.MinValue;
            short maxDeger = short.MaxValue;

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(minDeger);
            Console.WriteLine(maxDeger);
            Console.ReadLine();
        }
    }
}