using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_Generic_ArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> sayi = new List<int>();
            sayi.Add(1);
            sayi.Add(2);
            sayi.Add(3);

            foreach(int say in sayi)
            {
                Console.WriteLine("Sayı: " + say);
            }
            Console.WriteLine("| ***** |");
            // String
            List<string> text = new List<string>();
            text.Add("Türkiye");
            text.Add("Ankara");
            text.Add("Eskişehir");

            foreach(string texts in text)
            {
                Console.WriteLine("Yazı: " + texts);
            }
            Console.WriteLine("| ***** |");
            // Double
            List<double> doubles = new List<double>();
            doubles.Add(1.5);
            doubles.Add(5.25);
            doubles.Add(9.99);

            foreach(double d in doubles)
            {
                Console.WriteLine("Double: " + d);
            }
            Console.ReadLine();
        }
    }
}