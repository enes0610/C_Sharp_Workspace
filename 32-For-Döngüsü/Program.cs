using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_For_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10 arası sayı yazdırma
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("| ---------- |");
            // 0 - 10 arası sayıları 2'şer artırarak yazdır.
            for(int a = 0; a <= 10; a+=2)
            {
                Console.WriteLine(a);
            }
        }
    }
}