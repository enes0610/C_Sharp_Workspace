using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_İnharitance_Projesi
{
    public class Calisan

        // PROPERTİES
    {
        private int id;
        private string name;
        private string surname;

        // CONSTRUCTOR
        public Calisan(int id, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }

        // GETTER --- SETTER 
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSurname()
        {
            return surname;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public void bilgiGöster()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
        }
    }
}