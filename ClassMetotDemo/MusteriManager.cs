using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassMetotDemo.Program;

namespace ClassMetotDemo
{
    internal class MusteriMenager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Eklendi");
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Silindi");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " - " + musteri.Adi + " " +
                musteri.Soyadi + " " + musteri.Tc);
        }

    }
}
