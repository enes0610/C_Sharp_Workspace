using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79_Abstract_Projesi
{
    public class Ocak : Ay
    {
        public override int kacGünolustur()
        {
            return 30;
        }

        public override int yilinKacinciAyi()
        {
            return 1;
        }
    }
}