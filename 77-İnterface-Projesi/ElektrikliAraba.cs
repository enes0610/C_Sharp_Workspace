using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77_İnterface_Projesi
{
    public class ElektrikliAraba : IAraba
    {
        public void Start()
        {
            Console.WriteLine("Elektrikli araba çalıştı");
        }
        
        public void Stop()
        {
            Console.WriteLine("Elektrikli araba durdu");
        }

        public string FuelType()
        {
            return "Elektrik";
        }
    }
}