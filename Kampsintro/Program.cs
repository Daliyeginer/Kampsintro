using System;

namespace Kampsintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself :)
            //değer tutucu- alias= kategoriEketi
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmişMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }

         
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }


            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmişMi == true)

            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }


            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }
           



            Console.WriteLine(kategoriEtiketi);
            
           
           
        }
    }
}
