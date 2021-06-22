using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.id = 1;
            musteri1.MusteriAdSoyad = "Hakan Uğurdil";
            musteri1.TcKimlikNo = "12345678901";
            musteri1.Yas = 22;
            musteri1.Adres = "xyzdf";

            Musteri musteri2 = new Musteri();
            musteri2.id = 2;
            musteri2.MusteriAdSoyad = "Savaş Satış";
            musteri2.TcKimlikNo = "1234567535";
            musteri2.Yas = 32;
            musteri2.Adres = "xyzasdadf";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriListeleme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            Console.ReadLine();

        }
    }
}
