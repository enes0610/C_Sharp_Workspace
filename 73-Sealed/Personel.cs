using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_Sealed
{
    // Sealed: Mühürlü 
    // Personel Class'ı Miras Alınamaz
    public sealed class Personel
    {
        public int pers_id {  get; set; }
        public string pers_name { get; set; }
        public string pers_surname { get; set; }
        public int pers_maas {  get; set; }

        public void Bilgiler()
        {
            Console.WriteLine("İd: " + pers_id);
            Console.WriteLine("Name: " + pers_name);
            Console.WriteLine("Surname: " + pers_surname);
            Console.WriteLine("Maaş: " + pers_maas);
        }
    }
}