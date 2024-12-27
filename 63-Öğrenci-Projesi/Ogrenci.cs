using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63_Öğrenci_Projesi
{
    public class Ogrenci
    {
        private int ogrno;
        private string isim;
        private string soyad;
        private int vize1;
        private int vize2;
        private int final;
        private string okulIsmi;

        public Ogrenci(int _ogrno, string _isim, string _soyad, int _vize1, int _vize2, int _final, string _okulIsmi)
        {
            ogrno = _ogrno;
            isim = _isim;
            soyad = _soyad;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            okulIsmi = _okulIsmi;
        }

        public void ogrenciBilgiGöster()
        {
            Console.WriteLine("Öğrenci No: " + ogrno);
            Console.WriteLine("Öğrenci Ad Soyad: " + isim + "" + soyad);
            Console.WriteLine("Vize1: " + vize1);
            Console.WriteLine("Vize2: " + vize2);
            Console.WriteLine("Final: " + final);
            Console.WriteLine("Öğrenci Okul Adı: " + okulIsmi);
        }

        public double ogrenciNotBul()
        {
            double ortalama = vize1 * 0.1 + vize2 * 0.3 + final * 0.6;
            return ortalama;
        }

        public void okulBilgi()
        {
            Console.WriteLine("Okul Adı: " + okulIsmi);
        }
    }
}
