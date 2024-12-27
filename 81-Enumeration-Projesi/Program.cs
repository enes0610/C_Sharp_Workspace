using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81_Enumeration_Projesi
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList kisiler = new ArrayList();

            Kisi yeniKisi = new Kisi(0, "Enes", "Oğuz", 18, Cinsiyet.Erkek, "test@mail.com");
            kisiler.Add(yeniKisi);

            Console.WriteLine("Kişi Eklendi: " + yeniKisi.id);

            // Yeni Kişi Ekleme
            Kisi yeniKisi2 = new Kisi(1, "Havva", "Oğuz", 30, Cinsiyet.Kadın, "demo@mail.com");
            kisiler.Add(yeniKisi2);

            Console.WriteLine(" Yeni Kişi Eklendi: " + yeniKisi2.id);

            // Yeni Kişi Ekleme
            Kisi yeniKisi3 = new Kisi(2, "Arif", "Oğuz", 75, Cinsiyet.Erkek, "demotest@mail.com");
            kisiler.Add(yeniKisi3);

            Console.WriteLine(" Yeni Kişi Eklendi: " + yeniKisi3.id);

            BilgiGöster(kisiler);
        }
        public static void BilgiGöster(ArrayList kisiler)
        {
            foreach (Kisi kisi in kisiler)
            {
                Console.WriteLine("| ---------- |");
                Console.WriteLine("Id: " + kisi.id);
                Console.WriteLine("Name: " + kisi.name);
                Console.WriteLine("Surname: " + kisi.surname);
                Console.WriteLine("Yaş: " + kisi.yas);
                Console.WriteLine("Cinsiyet: " + kisi.cinsiyet);
                Console.WriteLine("Email: " + kisi.email);
                Console.WriteLine("| ---------- |");
                
                // Yeni Kişİ Bilgileri
            }
        }
    }
}