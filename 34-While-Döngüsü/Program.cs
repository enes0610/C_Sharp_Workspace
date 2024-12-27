using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10 arası sayıları yazdırma

            int x = 1;
            while(x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.ReadLine();
        }
    }
}