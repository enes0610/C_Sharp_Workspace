using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.pers_id = 1;
            musteri.pers_name = "Arif";
            musteri.pers_surname = "Oğuz";
            musteri.pers_maas = 20000;

            musteri.Bilgiler();
            Console.ReadLine();
        }
    }
}