using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77_İnterface_Projesi
{
    public class HibritAraba : IAraba
    {
        public void Start()
        {
            Console.WriteLine("Hibrit araba çalıştı.");
        }

        public void Stop()
        {
            Console.WriteLine("Hibrit araba durdu.");
        }

        public string FuelType()
        {
            return "Hibrit";
        }
    }
}