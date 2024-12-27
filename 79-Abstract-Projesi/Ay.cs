using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79_Abstract_Projesi
{
    public abstract class Ay
    {
        public int günSaati()
        {
            return 24;
        }

        public abstract int kacGünolustur();
        public abstract int yilinKacinciAyi();
    }
}