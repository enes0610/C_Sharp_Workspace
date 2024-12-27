using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_İnharitance_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            // ÇALIŞAN PROJESİ
            Console.WriteLine("Uygulamaya Hoşgeldiniz");

            // Yazılımcı İşlemleri
            while(true)
            {

                Console.WriteLine("1-Yazılımcı");
                Console.WriteLine("2- Yönetici");
                Console.WriteLine("q- Çıkış");

                string secilenIslem = Console.ReadLine();

                if (secilenIslem == "q")
                {
                    Console.WriteLine("Çıkış Yapıldı");
                    break;
                } 
                else if(secilenIslem == "1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "ENES", "OĞUZ", "REACT & C#");

                    while(true)
                    {
                        Console.WriteLine("Yazılımcı için İşlem Seçiniz: ");

                        Console.WriteLine("1- Format At");
                        Console.WriteLine("2- Yazılımcı Bilgileri");
                        Console.WriteLine("q- Çıkış");

                        string yazilimciIslem = Console.ReadLine();

                        if (yazilimciIslem == "q")
                        {
                            Console.WriteLine("Yazılımcı İşlemlerinden Çıkış Yapıldı");
                            break;
                        }
                        else if(yazilimciIslem == "1")
                        {
                            Console.WriteLine("İşletim Sistemi Girin: ");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }

                        else if(yazilimciIslem == "2")
                        {
                            yazilimci.bilgiGöster();
                        }
                        else
                        {
                            Console.WriteLine("Hatalı İşlem");
                        }
                    }

                }

                // Yönetici İşlemleri
                else if(secilenIslem == "2")
                {
                    Yönetici yönetici = new Yönetici(2, "Havva", "Oğuz", 1);

                    while(true)
                    {
                        Console.WriteLine("Yönetici için İşlem Seçiniz: ");

                        Console.WriteLine("1- Zam Yap");
                        Console.WriteLine("2- Yönetici Bilgileri");
                        Console.WriteLine("q- Çıkış");

                        string yöneticiIslem = Console.ReadLine();

                        if (yöneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici İşlemlerinden Çıkış Yapıldı");
                            break;
                        }
                        else if(yöneticiIslem == "1")
                        {
                            Console.Write("Zam Miktatını Giriniz: ");
                            int zamMiktar = Convert.ToInt32(Console.ReadLine());
                            yönetici.zamYap(zamMiktar);
                        }
                        else if(yöneticiIslem == "2")
                        {
                            yönetici.bilgiGöster();
                        }
                        else
                        {
                            Console.WriteLine("Hatalı İşlem");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Geçerssiz İşlem Yaptınız");
                }
            }

        }
    }
}