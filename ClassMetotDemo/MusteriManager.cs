using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri[] musteriler,Musteri musteri)
        {
            Musteri[] tempArray = musteriler;
            musteriler = new Musteri[musteriler.Length + 1];
            //for + tab+ tab döngü oluşturur
            for (int i = 0; i < tempArray.Length; i++)
            {
                musteriler[i] = tempArray[i];
            }

            musteriler[musteriler.Length - 1] = musteri;

        }

        public void MusteriSil(Musteri[] musteriler,string musteriId)
        {


            Musteri  silMusteri = null;

            foreach (var p in musteriler) {
                if(musteriId == p.MusteriId)
                {
                    silMusteri = p;
                }
            }


            musteriler = musteriler.Except(new Musteri[] { silMusteri }).ToArray();
            foreach (var i in musteriler)

                Console.WriteLine(i.Ad + " " + i.Soyad + "  MÜŞTERİ NO: " + i.MusteriId + "  TC NO: " + i.Tckn);


        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var i in musteriler)
                
                Console.WriteLine(i.Ad + " " + i.Soyad + "  MÜŞTERİ NO: " + i.MusteriId + "  TC NO: " + i.Tckn);

            }
    }





}

