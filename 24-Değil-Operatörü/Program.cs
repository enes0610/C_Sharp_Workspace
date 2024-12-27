using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Değil_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TRUE olan değeri FALSE yapar.
            // FALSE olan değeri TRUE yapar.

            bool a = true;
            bool b = false;

            Console.WriteLine(!a);
            Console.WriteLine(!b);
            Console.ReadLine();
        }
    }
}