using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79_Abstract_Projesi
{
    public class Mart : Ay
    {
        public override int kacGünolustur()
        {
            return 31;
        }

        public override int yilinKacinciAyi()
        {
            return 3;
        }
    }
}