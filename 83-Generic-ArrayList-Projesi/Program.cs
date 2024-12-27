using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Generic_ArrayList_Projesi
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kisiler> kisilers = new List<Kisiler>();
            kisilers.Add(new Kisiler(1, "Enes", "Oguz", 28));
            kisilers.Add(new Kisiler(2, "Ahmet", "Oğuz", 40));
            kisilers.Add(new Kisiler(3, "Havva", "Oğuz", 35));

            foreach(Kisiler kisiler in kisilers)
            {
                Console.WriteLine(kisiler);
            }
            Console.ReadLine();
        }
    }
}