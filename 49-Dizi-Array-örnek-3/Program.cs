using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Dizi_Array_örnek_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[3];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write("İsimler: " + (i + 1) + ". index değerini giriniz: ");
                isimler[i] = Console.ReadLine();
            }
            Console.WriteLine("| ----- * ----- * ----- |");

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine("Değer: " + isimler[i]);
            }
            Console.ReadLine();
        }
    }
}