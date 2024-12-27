using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_İnterface
{
    public class Musteri : IMusteri,IPersonel
    {
        public void ekle()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri Geldi");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }

        public void sil()
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public int personelEkle()
        {
            throw new NotImplementedException();
        }

    }
} 