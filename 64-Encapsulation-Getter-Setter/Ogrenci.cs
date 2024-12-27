using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64_Encapsulation_Getter_Setter
{
    class Ogrenci
    {
        public string isim = "ENES";
        private string soyad;

        public void setSoyad(string _soyad)
        {
            soyad = _soyad;
        }

        public string getSoyad()
        {
            return soyad;
        }
    }
}