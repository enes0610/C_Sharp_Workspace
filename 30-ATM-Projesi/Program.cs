using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_ATM_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                1- Bakiye Sorgula
                2- Para Çek
                3- Para Yatır
                4- 'q' Çıkış
             */
            int bakiye = 1000;
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("İşlem Seçiniz");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Bakiye: " + bakiye);
            }
            else if (secim == "2") {
                Console.WriteLine("Çekmek istenilen Tutar:");
                int para_cek = Convert.ToInt32(Console.ReadLine());

                if(para_cek <= bakiye)
                {
                    Console.WriteLine("Kalan Bakiye: " + (bakiye - para_cek));
                }
                else
                {
                    Console.WriteLine("Yetersiz Bakiye Para Yatırın veya Tekrar Deneyiniz !");
                }
            }
            else if(secim == "3")
            {
                Console.WriteLine("Yatırmak istenilen Tutar");
                int para_yatir = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiye: " + (bakiye + para_yatir));
            }
            else if(secim == "q")
            {
                Console.WriteLine("ATM' Çıkış Yapılıyor... İyi Günler !");
            }
            else
            {
                Console.WriteLine("Hatalı İşlem Tekrar Dene !");
            }
            Console.ReadLine();
        }
    }
}