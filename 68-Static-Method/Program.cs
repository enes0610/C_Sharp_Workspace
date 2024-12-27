using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_Static_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Ad ad = new Ad();
            Ad.sayiXazdir(5);

            Ad.adYazdir();
            Console.ReadLine();
        }
    }
}