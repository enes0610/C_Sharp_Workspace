using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79_Abstract_Projesi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ocak ocak = new Ocak();
            Subat subat = new Subat();
            Mart mart = new Mart();

            Console.WriteLine("Gün" + ocak.kacGünolustur());
            Console.WriteLine("Ay" + ocak.yilinKacinciAyi());
            Console.WriteLine("Saat" + ocak.günSaati());

            Console.WriteLine("/ --- /");

            Console.WriteLine("Gün" + subat.kacGünolustur());
            Console.WriteLine("Ay" + subat.yilinKacinciAyi());
            Console.WriteLine("Saat" + subat.günSaati());

            Console.WriteLine("/ --- /");

            Console.WriteLine("Gün" + mart.kacGünolustur());
            Console.WriteLine("Ay" + mart.yilinKacinciAyi());
            Console.WriteLine("Saat" + mart.günSaati());

            Console.ReadLine();
        }
    }
}