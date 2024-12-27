using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_Diziler_Array_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] karakter = { 'E', 'N', 'S' };

            for(int i = 0; i < karakter.Length; i++)
            {
                Console.WriteLine("Karakter: " + karakter[i]);
                Console.ReadLine();
            }
        }
    }
}