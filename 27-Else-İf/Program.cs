using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Else_İf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vize Notu
            Console.WriteLine("Vize Notu Girin...");
            int vize = int.Parse(Console.ReadLine());

            // Final Notu
            Console.WriteLine("Final Notu Girin...");
            int final = int.Parse(Console.ReadLine());

            // Ortalama
            double ortalama = (vize * 0.3) + (final * 0.7);

            // Kontrol
            if(ortalama >= 90)
            {
                Console.WriteLine("Notunuz: A");
            } 
            else if (ortalama >= 80)
            {
                Console.WriteLine("Notunuz: B");
            }
            else if (ortalama >= 70)
            {
                Console.WriteLine("Notunuz: C");
            }
            else if (ortalama >= 60)
            {
                Console.WriteLine("Notunuz: D");
            }
            else
            {
                Console.WriteLine("Kaldınız Notunuz: E");
            }
            Console.WriteLine("Ortalama: " + ortalama);
        }
    }
}