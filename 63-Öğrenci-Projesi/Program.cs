namespace _63_Öğrenci_Projesi
{
    using System;

    public class Program
    {
        internal static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci = new Ogrenci(1, "Enes", "Oğuz", 56, 67, 88, "Ankara Üniversitesi");

            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("İşlem Seçiniz: ");

            while (kontrol)
            {
                islemGöster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        {
                            ogrenci.ogrenciBilgiGöster();
                            break;
                        }
                    case "2":
                        {
                            double ogrenciOrtalama = ogrenci.ogrenciNotBul();
                            Console.WriteLine("Öğrenci Not Ortalama: " + ogrenciOrtalama);
                            break;
                        }
                    case "3":
                        {
                            ogrenci.okulBilgi();
                            break;
                        }
                    case "4":
                        {
                            kontrol = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Geçersiz bir seçim yaptınız.");
                            break;
                        }
                }
            }
        }

        static void islemGöster()
        {
            Console.WriteLine("1- Öğrenci Bilgileri");
            Console.WriteLine("2- Öğrenci Ortalaması");
            Console.WriteLine("3- Öğrenci Okul Adı");
            Console.WriteLine("4- Çıkış");
        }
    }
}