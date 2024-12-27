using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte sayi1 = 10;
            byte sayi2 = 20;
            
            byte minDeger = byte.MinValue;
            byte maxDeger = byte.MaxValue;

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
            Console.WriteLine(minDeger);
            Console.WriteLine(maxDeger);
            Console.ReadLine();
        }
    }
}