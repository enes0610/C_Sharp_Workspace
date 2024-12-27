using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Diziler_Array_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ondalikliSayi = { 1.99, 5.25, 7.33 };

            for(int i = 0; i < ondalikliSayi.Length; i++)
            {
                Console.WriteLine("Ondalıklı Sayı: " + ondalikliSayi[i]);
                Console.ReadLine();
            }
        }
    }
}