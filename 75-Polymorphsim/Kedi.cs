using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_Polymorphsim
{
    class Kedi : Hayvan
    {
        public Kedi(string isim) : base(isim)
        {
            
        }
        public override void SesCikart()
        {
            Console.WriteLine(getIsim() + " " + "Kedi Miyavlıyor");
        }
    }
}