using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_Encapsulation_Getter_Setter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setter --> Değer ataması için kullanılır.
            // Getter --> Değer almak için kullanılır.

            Ogrenci ogrenci = new Ogrenci();

            Console.WriteLine("Ad: " + ogrenci.isim);
            Console.ReadLine();

            ogrenci.setSoyad("Oğuz");
            ogrenci.getSoyad();

            Console.WriteLine("Soyad: " + ogrenci.getSoyad());
            Console.ReadLine();
        }
    }
}