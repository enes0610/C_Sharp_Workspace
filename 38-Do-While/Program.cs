using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1- 100 arası sayıları do while ile toplama işlemi
            int z = 1;
            int toplam = 0;

            do
            {
                toplam += z;
                z++;
            } while (z <= 100);
            Console.WriteLine("SAYILARIN TOPLAMI: " + toplam);
            Console.ReadLine();
        }
    }
}