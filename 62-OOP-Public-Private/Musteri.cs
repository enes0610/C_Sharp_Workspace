using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_OOP_Public_Private
{
    public class Musteri
    {
        public string isim;
        public string soyad;
        public string cinsiyet;
        public int maasDegeri;
        private int yas;

        public void musteriBilgiGöster()
        {
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Maaş: " + maasDegeri);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Yaş: " + yas);
        }

        private void IsimSoyad(string musteriisim, string musterisoyad)
        {
            Console.WriteLine("Adı Soyad: " + musteriisim + "" + musterisoyad);
            Console.WriteLine("Yaş: " + yas);
        }
    }
}