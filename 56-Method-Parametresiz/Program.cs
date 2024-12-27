using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Method_Parametresiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PARAMETRESİZ METHOD GERİYE DEĞER DÖNDÜRMEZ
            Console.WriteLine("Welcome");
            Merhaba();
        }

        static void Merhaba()
        {
            Console.WriteLine("Visual Studio :) ");
            Console.ReadLine();
        }

    }
}