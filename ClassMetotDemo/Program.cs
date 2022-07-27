using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 202200001;
            musteri1.Adi = "Abdurrahman";
            musteri1.Soyadi = "VAROL";
            musteri1.Tc = "11111111111";
            Musteri musteri2 = new Musteri();
            musteri2.Id = 202200002;
            musteri2.Adi = "Zafer";
            musteri2.Soyadi = "KAYA";
            musteri2.Tc = "22222222222";
            Musteri musteri3 = new Musteri();
            musteri3.Id = 202200003;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "ÇINAR";
            musteri3.Tc = "33333333333";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriMenager musteriMenager = new MusteriMenager();

            musteriMenager.MusteriEkle(musteri1);
            musteriMenager.MusteriSil(musteri2);
            musteriMenager.MusteriListele(musteri3);

            Console.WriteLine("");
            Console.WriteLine("Müşteri Listesi");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " - " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Tc);
            }
        }
    }
}