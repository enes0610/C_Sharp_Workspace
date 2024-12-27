using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_Abstract_Class
{
    public abstract class TemelSınıf
    {
        public void metot1()
        {
            Console.WriteLine("Metot1 Çalıştı");
        }

        public abstract void metot2(); // metot imzası
    }
}