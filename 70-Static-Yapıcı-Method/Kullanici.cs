using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_Static_Yapıcı_Method
{
    public class Kullanici
    {
        private int kullaniciID;
        private string name;
        private string surname;
        private static double maas;

        // Statik yapıcı
        static Kullanici()
        {
            maas = 5000.99;
        }

        public static double Maas // public özellik
        {
            get { return maas; }
            set { maas = value; }
        }

        // Parametreli yapıcı
        public Kullanici(int id, string name, string surname)
        {
            kullaniciID = id;
            this.name = name;
            this.surname = surname;
        }

        public void BilgiYazdir()
        {
            Console.WriteLine("ID: " + kullaniciID);
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("SURNAME: " + surname);
            Console.WriteLine("MAAŞ: " + maas);
            Console.ReadLine();
        }
    }
}