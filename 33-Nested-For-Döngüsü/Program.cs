using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Nested_For_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}