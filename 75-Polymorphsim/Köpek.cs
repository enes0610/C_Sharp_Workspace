using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_Polymorphsim
{
    internal class Köpek : Hayvan
    {
        public Köpek(string isim) : base(isim)
        {

        }
        public override void SesCikart()
        {
            Console.WriteLine(getIsim() + " " + "Köpek Havlıyor");
        }
    }
}