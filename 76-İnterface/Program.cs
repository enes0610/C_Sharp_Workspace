using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_İnterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                İnterface'lerden bir tane örnek oluşturamazsınız.
                İnterface'i implement'e eden class'dan aldığımız örneği interfacee karşılayabilir.
                İnterface içinde metot tanımlanır. Class'larla içeriğini doldururuz.
                İnterface içindeki metotların Erişim Belirleyicileri ve içeriği olmaz.
                İnterfacele'ri miras alan sınıflar içerisindee tanımlanan tüm metotları İmplement etmek zorundadır.
                Bir class sadece bir clas'dan türetilebilirken, bir class birden çok İnterface'den türetülebilir.
             */
            Musteri musteri = new Musteri();
            musteri.ekle();
            musteri.sil();

            IMusteri musteri1 = new Musteri();
            musteri1.guncelle();

            Console.ReadLine();
        }
    }
}