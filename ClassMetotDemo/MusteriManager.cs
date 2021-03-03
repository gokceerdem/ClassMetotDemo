using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {

                musteri[] tempArray = items;
                items = new T[items.Length + 1];
                //for + tab+ tab döngü oluşturur
                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                }

                items[items.Length - 1] = item;

            
        }

        public void MusteriSil(Musteri musteri)
        {
        }

        public void MusteriListele(Musteri[] musteriler)
        {
        }
    }
}
