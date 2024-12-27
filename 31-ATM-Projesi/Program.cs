using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_ATM_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SWİTCH CASE ATM PROJESİ
            int bakiye = 500;

            Console.WriteLine("HOŞGELDİNİZ");
            Console.WriteLine("1- Bakiye Sorgula");
            Console.WriteLine("2- Bakiye Çek");
            Console.WriteLine("3- Bakiye Yatır");
            Console.WriteLine("4- 'q' Çıkış");

            string secim = Console.ReadLine();

            switch(secim)
            {
                case "1":                    
                        Console.WriteLine("Bakiye: " + bakiye);
                        break;

                case "2":
                        Console.WriteLine("Çekmek istediğiniz Tutar:");
                        int para_cek = Convert.ToInt32(Console.ReadLine());
                        
                        if(para_cek > bakiye)
                        {
                            Console.WriteLine("Yetersiz Bakiye !!!");
                        }
                        else
                        {
                            Console.WriteLine("Kalan Bakiye: " + (bakiye - para_cek));
                        }
                        break;

                case "3":
                        Console.WriteLine("Yatırmak istediğiniz Tutar:");
                        int para_yatir = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Yeni Bakiye " + (bakiye + para_yatir));
                        break;

                case "q":
                    Console.WriteLine("Çıkış Yapıldı !");
                    break;

                default:
                    Console.WriteLine("Hatalı İşlem !");
                    break;
            }
            Console.ReadLine();
        }
    }
}