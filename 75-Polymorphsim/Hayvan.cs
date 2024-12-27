using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_Polymorphsim
{
    class Hayvan
    {
        public string isim;
        public Hayvan(string isim)
        {
            this.isim = isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        public string getIsim()
        {
            return this.isim;
        }
        public virtual void SesCikart()
        {
            Console.WriteLine("Hayvanlar Ses Çıkartıyor");
            Console.ReadLine();
        }
    }
}
