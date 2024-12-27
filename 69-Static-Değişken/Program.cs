using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_Static_Değişken
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan();

            calisan.calisanID = 1;
            calisan.name = "Test";
            calisan.surname = "Demo";

            Calisan.maas = 100;

            Console.WriteLine("ID: " + calisan.calisanID);
            Console.WriteLine("Name: " + calisan.name);
            Console.WriteLine("Surname: " + calisan.surname);
            Console.WriteLine("Maaş: " + Calisan.maas);
            Console.ReadLine();
        }
    }
}