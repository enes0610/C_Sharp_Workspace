using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77_İnterface_Projesi
{
    public class BenzinliAraba : IAraba
    {
        public void Start()
        {
            Console.WriteLine("Benzinli araba çalıştı.");
        }

        public void Stop()
        {
            Console.WriteLine("Benzinli araba durdu.");
        }

        public string FuelType()
        {
            return "Benzin";
        }
    }
}