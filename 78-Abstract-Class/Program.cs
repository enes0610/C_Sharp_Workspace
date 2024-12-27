using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_Abstract_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                Abstract class'lar tamamen kalıtım amaçla geliştirilmiştir.
                İçerisinde tanımlanmış metot miras alan class'lar override etmek zorundadır.
                
                - Abstract Class ve Class Farkı
                    Normal classlar'da metot imzası tanımı yapamaz. Abstract classlar'da metot imzası yapılır.
                    Normal classlar'da new anahtar kelimesi ile nesneler oluşturulur. Abstract class'larda yapılamaz.

                - Abstract Class ve İnterface Farkı
                  Bir class'a Abstract classlar'dan sadece birini miras alabilirken o class birden çok İnterface'i İmplement edebilir.
             */

            AltSınıf altsinif = new AltSınıf();
            altsinif.metot1();
            altsinif.metot2();

            Console.ReadLine();
        }
    }
}