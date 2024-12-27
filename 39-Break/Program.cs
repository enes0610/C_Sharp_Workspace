using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break
            for(int i = 0; i <= 10; i++)
            {
                if(i == 7)
                {
                    break; // Sayı 6 olduğunda döngü durur. Diğer sayıları yazdırmaz.
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}