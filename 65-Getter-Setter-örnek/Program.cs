using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_Getter_Setter_örnek
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Yeni Öğrenci Oluştur
            İnsan insan = new İnsan();

            Console.WriteLine("Ad: " + insan.isim);

            insan.setSoyad("Oğuz");
            Console.WriteLine("Soyad: " + insan.getSoyad());

            insan.setOgrNo(123);
            Console.WriteLine("Öğrenci No: " + insan.getOgrNo());

            insan.setOgrTc("01234567890");
            Console.WriteLine("Tc No: " + insan.getOgrTc());
            Console.ReadLine();
        }
    }
}