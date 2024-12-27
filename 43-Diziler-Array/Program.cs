using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Diziler_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[4];

            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 40;
            sayilar[3] = 50;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar: " + sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}