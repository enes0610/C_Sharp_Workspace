using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_Polymorphsim
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan kedi = new Kedi("Minik");
            Hayvan köpek = new Köpek("Boncuk");

            Console.WriteLine("Kedi İsmi: " + kedi.getIsim());
            kedi.SesCikart();
            Console.WriteLine("Köpek İsmi: " + köpek.getIsim());
            köpek.SesCikart();

            Console.ReadLine();
        }
    }
}