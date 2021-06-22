using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.id + " " + musteri.MusteriAdSoyad);
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi: " + musteri.id + " " + musteri.MusteriAdSoyad);
        }

        public void MusteriListeleme(Musteri musteri)
        {
            Musteri[] musteriler = new Musteri[] { musteri };
            foreach (Musteri mus in musteriler)
            {
                Console.WriteLine("Kayıtlı müşteri listesi: " + mus.id + " " + mus.MusteriAdSoyad + " " + mus.Yas + " " + mus.TcKimlikNo + " " + mus.Adres);
            }
        }

    }
}
