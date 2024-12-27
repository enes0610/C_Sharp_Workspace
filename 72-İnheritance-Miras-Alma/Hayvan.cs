using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_İnheritance_Miras_Alma
{
    public class Hayvan
    {
        public string isim;
        public string cinsiyet;
        public string renk;
        public int yas;
        
        public void hayvanBilgi()
        {
            Console.WriteLine("AD: " + isim);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Renk: " + renk);
            Console.WriteLine("Yaş: " + yas);
            Console.ReadLine();
        }
    }
}