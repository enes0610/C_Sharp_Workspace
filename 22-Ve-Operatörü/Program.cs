using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Ve_Operatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
		// Her iki koşulda doğru ise sonuç TRUE olur.
		// Eğer koşullardan biri TRUE birisi FALSE ise sonuç FALSE olur.
 
            int sayi1 = 1;
            int sayi2 = 1;
            int sayi3 = 10;

            bool kontrol = sayi1 == sayi2 && sayi1 < sayi3;

            Console.WriteLine(kontrol);
            Console.ReadLine();
        }
    }
}