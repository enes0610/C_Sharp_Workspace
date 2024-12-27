using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Contunie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contunie
            for(int i = 0; i <= 10;  i++)
            {
                if(i == 2 || i == 6)
                {
                    continue; // Döngü başlar 2 sayısını atlar ve döngü çalışmaya devam eder. 6 sayısına gelir ve 6 sayısını'da atlar devam eder.
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}