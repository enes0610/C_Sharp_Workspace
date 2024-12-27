using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_İnharitance_Projesi
{
    public class Yönetici : Calisan
    {
        private int yöneticiSayisi;
        public Yönetici(int id, string name, string surname, int yöneticiSayisi) : base(id, name, surname)
        {
            this.yöneticiSayisi = yöneticiSayisi;
        }

        public void zamYap(int zamMiktar)
        {
            // Yönetici çalışan'lara zam yapar.
            Console.WriteLine(getName() + " " + zamMiktar + " " + "₺");
        }
    }
}