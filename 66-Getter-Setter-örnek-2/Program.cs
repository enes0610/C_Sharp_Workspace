using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Getter_Setter_örnek_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();

            Console.WriteLine("Araba Marka: " + araba.marka);
            Console.WriteLine("Araba Model: " + araba.model);
            Console.WriteLine("Araba Renk:" + araba.renk);

            // Plaka
            araba.setPlaka("06TC006");
            Console.WriteLine("Araba Plaka: " + araba.getPlaka());

            // Model Yılı
            araba.setModelYili(2001);
            Console.WriteLine("Araba Model Yılı: " + araba.getModelYili());
            Console.ReadLine();
        }
    }
}