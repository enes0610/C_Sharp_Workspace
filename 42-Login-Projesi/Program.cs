using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Login_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int girishak = 3;
            while(true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Kullanıcı Şifrenizi Giriniz: ");
                string sifre = Console.ReadLine();

                if(kullaniciAdi == "enes" && sifre == "12345")
                {
                    Console.WriteLine("Giriş Başarılı");
                    break;
                }
                else
                {
                    Console.WriteLine("Bilgiler Hatalı Tekrar Deneyiniz...!");
                    Console.WriteLine(girishak);
                    if(girishak > 0)
                    {
                        girishak -= 1;
                    }
                    if(girishak == 0)
                    {
                        Console.WriteLine("Giriş hakkınız bitti");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}