using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_Generic_ArrayList_Projesi
{
    public class Kisiler
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int yas { get; set; }

        public Kisiler(int id, string name, string surname, int yas)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.yas = yas;
        }

        public override string ToString()
        {
            return "ID: " + this.id + " " + "NAME: " + this.name + " " + "SURNAME: " + this.surname +
                    " " + "YAŞ: " + this.yas;
        }
    }
}