using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_Dizi_Array_örnek_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[3];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Ondalıklı Sayılar: " + (i + 1) + ". index değerini giriniz: "); // 1,11
                sayilar[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("| ----- * ----- * ----- |");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Değer: " + sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}