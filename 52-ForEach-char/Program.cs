using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_ForEach_char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'A', '&', 'z', '@' };

            foreach(char c in chars)
            {
                Console.WriteLine("Char:" + c);
            }
            Console.ReadLine();
        }
    }
}