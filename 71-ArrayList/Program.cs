using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_ArrayList
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList kolleksiyon = new ArrayList();

            kolleksiyon.Add("ENES");
            kolleksiyon.Add("AHMET");
            kolleksiyon.Add("AYŞE");
            kolleksiyon.Add("ZEYNEP");
            kolleksiyon.Add("Ali");

            kolleksiyon.Remove("Ali"); // Sadece Kişiyi Siler
            //kolleksiyon.Clear(); // Tüm Diziyi Siler
            kolleksiyon.Insert(4, "Mehmet"); // Yeni Kişi Ekler
            kolleksiyon.Reverse(); // Diziyi Tersten Yazdırır

            bool Kontrol = kolleksiyon.Contains("Fatma"); // Dizide Kontrol Yapar. Dizide Kişi Yok --> False
            bool Kontrol1 = kolleksiyon.Contains("AYŞE");  // --> True

            int dizi = kolleksiyon.Count; // Dizide Kaç Kişi olduğunu Gösterir
            int index = kolleksiyon.IndexOf("ENES"); // Kişinin index Numarasını Gösterir

            foreach (var a in kolleksiyon)
            {
                Console.WriteLine("Kolleksiyon: " + a);
            }
            Console.WriteLine("| ***** |");

            ArrayList rakamlar = new ArrayList();

            rakamlar.Add(1);
            rakamlar.Add(9);
            rakamlar.Add(50);
            rakamlar.Add(25);
            rakamlar.Add(100);
            rakamlar.Add(10);

            rakamlar.Sort(); // Sayıları Küçükten Büyüğe Doğru Sıralar 

            foreach (int z in rakamlar)
            {
                Console.WriteLine("Rakamlar: " + z);
            }
            Console.WriteLine("| ***** |");
            Console.WriteLine("Kişi Var mı? " + Kontrol);
            Console.WriteLine("Kişi Var mı? " + Kontrol1);
            Console.WriteLine("| ***** |");
            Console.WriteLine("Count: " + kolleksiyon.Count);
            Console.WriteLine("İndex Of: " + index);
            Console.ReadLine();
        }
    }
}