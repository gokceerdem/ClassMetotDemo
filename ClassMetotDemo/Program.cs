
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Musteri mus1 = new Musteri();
            Musteri mus2 = new Musteri();
            Musteri mus3 = new Musteri();
            mus1.MusteriId = "1";
            mus1.Ad = "Ali";
            mus1.Soyad = "Cebeci";
            mus1.Tckn = "45934992018";

            mus2.MusteriId = "2";
            mus2.Ad = "Alixx";
            mus2.Soyad = "Cebecixx";
            mus2.Tckn = "56934992019";

            mus3.MusteriId = "3";
            mus3.Ad = "Can";
            mus3.Soyad = "Kurt";
            mus3.Tckn = "38274402938";


            Musteri[] musteris = new Musteri[] {mus1,mus2, mus3};
            /* foreach (Musteri musteri in musteris)
             {
                 Console.WriteLine("AD: " + musteri.Ad);
                 Console.WriteLine("SOYAD: " + musteri.Soyad);
                 Console.WriteLine("Tckn: " + musteri.Tckn);
                 Console.WriteLine("musno: " + musteri.MusteriId);


             }
            */

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriListele(musteris);


            Console.WriteLine("-----------------------");

            musteriManager.MusteriSil(musteris, "3");

        }
    }
}
