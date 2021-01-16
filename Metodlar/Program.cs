using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama= "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 }; //Array

            //C# gıbı elemanlar type-safe dir 
            foreach (Urun urun in urunler) //benım her elemanımı tek tek gez ve ekrana bas

            {
                Console.WriteLine("urun.Adi");
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------------");
            }


            Console.WriteLine("---------------Metotlar------------------");
            //instance -klas örneğği oluşturmak
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("elma", "Yeşil elma", 12,8);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,9);








        }
    }
}


//Tekrar tekrar kullanmanızı sağlıyan codelar dont repeat yourself. 
//Sayfalarda ortak kodlarımız varsa kendımızı tekrar edecegımız kodlar varsa bunları method ediniriz
//Clean code- and best practise şöyleki sektörde hala bu zafiyetlerden vardır temiz kod yazma tekniklerini öğreneceğiz
//sepete ekle diyor detaya gıdıyoruz oraya da sepete ekle dıyor bı kac urun var orda da sepete ekle butonu koyuyuor 
//yani o sepete ekle işlemini farklı farklı yerde kullanıyor aryrıca kendını de tekrarlamıyor
//c# javada çoğu komplikasyonlar clasların içersinde olur