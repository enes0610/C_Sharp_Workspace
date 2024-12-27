using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10 arası sayıları do while döngüsü ile yazdırma
            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
            Console.ReadLine();
        }
    }
}