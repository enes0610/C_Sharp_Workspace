using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_OOP_Public_Private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.isim = "ENES";
            musteri.soyad = "OĞUZ";
            musteri.maasDegeri = 1000;
            musteri.cinsiyet = "Erkek";

            musteri.musteriBilgiGöster();
        }
    }
}