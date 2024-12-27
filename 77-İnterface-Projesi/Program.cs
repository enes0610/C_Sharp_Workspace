using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77_İnterface_Projesi
{
    public class Program
    {
        static void Main(string[] args)
        {
            IAraba benzinliAraba = new BenzinliAraba();
            IAraba elektrikliAraba = new ElektrikliAraba();
            IAraba hibritAraba = new HibritAraba();

            Console.WriteLine("/ *** --- *** /");

            benzinliAraba.Start();
            Console.WriteLine("Yakıt: " + benzinliAraba.FuelType());
            benzinliAraba.Stop();

            Console.WriteLine("/ *** --- *** /");

            elektrikliAraba.Start();
            Console.WriteLine("Yakıt: " + elektrikliAraba.FuelType());
            elektrikliAraba.Stop();

            Console.WriteLine("/ *** --- *** /");

            hibritAraba.Start();
            Console.WriteLine("Yakıt: " + hibritAraba.FuelType());
            hibritAraba.Stop();

            Console.ReadLine();
        }
    }
}