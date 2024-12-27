using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_İnharitance_Projesi
{
    public class Yazilimci : Calisan
    {
        private string diller;
        public Yazilimci(int id, string name, string surname, string diller) : base(id, name, surname)
        {
            this.diller = diller;
        }

        public void formatAt(string isletim_sistemi)
        {
            Console.WriteLine(getName() + " " + isletim_sistemi + " " + "Format Atılıyor..." );
        }
    }
}