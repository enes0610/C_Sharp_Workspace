using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Class
{
    public class Araba
    {
        // Değişken Tanımlama

        public int kapiSayisi;
        public string arabaMarka;
        public string arabaModel;
        public string arabaRenk;

        public void motorCalistir()
        {
            Console.WriteLine("Araba Çalışıyor");
        }

        public void kapıKilit()
        {
            Console.WriteLine("Kapılar Kilitli");
        }
    }
}