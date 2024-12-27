using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Dizi_Array_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[3];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayılar: " + (i + 1) + ". index değerini giriniz: ");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("| ----- * ----- * ----- |");

            for(int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine("Değer: " + sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}