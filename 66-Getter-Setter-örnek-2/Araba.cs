using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Getter_Setter_örnek_2
{
    class Araba
    {
        // Public
        public string marka = "Opel";
        public string model = "Astra";
        public string renk = "Beyaz";
        private string plaka;
        private int modelYili;

        // Plaka Getter Setter
        public void setPlaka(string _plaka)
        {
            plaka = _plaka;
        }

        public string getPlaka()
        {
            return plaka;
        }

        public void setModelYili(int _modelYili)
        {
            modelYili = _modelYili;
        }

        public int getModelYili()
        {
            return modelYili;
        }
    }
}