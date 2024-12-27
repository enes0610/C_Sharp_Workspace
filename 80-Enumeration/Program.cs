using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gunler bugun = Gunler.Pazartesi;
            Console.WriteLine("Bugün: " + bugun);

            Gunler bugun4 = Gunler.Perşembe;
            Console.WriteLine("Bugün: " + bugun4);

            int gunIndex = (int)bugun;
            Console.WriteLine("Gün İndeksi: " + gunIndex);

            int gunIndex1 = (int)bugun4;
            Console.WriteLine("Gün İndeksi: " + gunIndex1);
            Console.ReadLine();
        }
    }
}