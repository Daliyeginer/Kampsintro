using System;

namespace YOKYOK

{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "YOKYOK E-Ticaret Sitesine Hoşgeldiniz!";
            Console.WriteLine(x);
            urun urun1 = new urun();
            urun1.adı = "bilgisayar";
            urun1.Kategori = "teknoloji";
            urun1.Fiyat = 3000;

            urun urun2 = new urun();
            urun2.adı = "Klavye";
            urun2.Kategori = "teknoloji";
            urun2.Fiyat = 330;

            urun urun3 = new urun();
            urun3.adı = "linux İşletim sistemi";
            urun3.Kategori = "teknoloji";
            urun3.Fiyat = 50;


            urun[] urunler = new urun[] { urun1, urun2, urun3 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.adı " : " + urun.Kategori + "tl" + "beğeni oranı % " + urun.begeniOrani);
            }

          
            class urun
        {
            public string adı { get; set; }
            public string Kategori { get; set; }
            public double Fiyat { get; set; }

        }











    }
}
