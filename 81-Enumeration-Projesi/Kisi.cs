using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _81_Enumeration_Projesi
{
    public class Kisi
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int yas { get; set; }
        public Cinsiyet cinsiyet { get; set; }
        public string email { get; set; }

        public Kisi(int id, string name, string surname, int yas, Cinsiyet cinsiyet, string email)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.yas = yas;
            this.cinsiyet = cinsiyet;
            this.email = email;
        }
    }
}