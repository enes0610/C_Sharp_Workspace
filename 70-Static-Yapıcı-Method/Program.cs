using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_Static_Yapıcı_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici1 = new Kullanici(1, "Ahmet", "Yılmaz");
            Kullanici kullanici2 = new Kullanici(2, "Ayşe", "Demir");

            kullanici1.BilgiYazdir();
            kullanici2.BilgiYazdir();

            // Maaş güncellemesi
            Kullanici.Maas = 9000.0;
            Console.WriteLine("Maaş güncellendi.");

            kullanici1.BilgiYazdir();
            kullanici2.BilgiYazdir();
        }
    }
}