using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_İnheritance_Miras_Alma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();

            kedi.isim = "Kedi";
            kedi.cinsiyet = "Erkek";
            kedi.renk = "Beyaz";
            kedi.yas = 10;

            kedi.hayvanBilgi();
            Console.ReadLine();
        }
    }
}