using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Büyüktür_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 10;
            int age = 20;

            bool kontrol = yas > 18;
            bool sonuc = age > 18;

            Console.WriteLine(kontrol);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}