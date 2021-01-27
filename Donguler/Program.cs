using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI";
            string kurs2 = "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS";
            string kurs3 = "Java";

            //array = dizi

            string[] kurslar = new string[] { "YAZILIM GELİŞTİRİCİ YETİŞTİRME KAMPI" ,
            "PROGRAMLAMAYA BAŞLANGIÇ İÇİN TEMEL KURS", "Java" , "Python"};


            for (int i = 0; i<kurslar.Length;  i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Foreach bitti");
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
