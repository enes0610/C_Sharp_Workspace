using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_While_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 100 - 0 arasındaki sayıları yazdırma
            int a = 100;

            while(a >= 0)
            {
                Console.WriteLine(a);
                a -= 2;
            }
            Console.ReadLine();
        }
    }
}