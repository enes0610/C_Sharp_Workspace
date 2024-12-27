using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_Getter_Setter_örnek
{
    class İnsan
    {
        // Public
        public string isim = "Ahmet";

        // Private
        private string soyad;
        private int ogrNo;
        private string ogrTc;

        // Getter Setter
        public void setSoyad(string _soyad)
        {
            soyad = _soyad;
        }

        public string getSoyad()
        {
            return soyad;
        }

        // Öğrenci Numarası Setter Getter
        public void setOgrNo(int _ogrNo)
        {
            ogrNo = _ogrNo;
        }

        public int getOgrNo()
        {
            return ogrNo;
        }

        // Öğrenci Tc Setter Getter
        public void setOgrTc(string _ogrTc)
        {
            ogrTc = _ogrTc;
        }

        public string getOgrTc()
        {
            return ogrTc;
        }
    }
}