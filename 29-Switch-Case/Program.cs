using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz");
            string sayi = Console.ReadLine();

            switch (sayi)
            {
                case "1":
                    {
                        Console.WriteLine("Sayı 1");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Sayı 2");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Sayı 3");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hatalı İşlem");
                        break;
                    }
            }
        }
    }
}