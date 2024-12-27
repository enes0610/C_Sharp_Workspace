using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Enes", "Ahmet", "Ayşe" };

            foreach (string ad in isimler)
            {
                Console.WriteLine("İsimler: " + ad);
            }
            Console.ReadLine();
        }
    }
}