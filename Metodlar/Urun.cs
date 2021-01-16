using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Urun
    {
        //propery - Özellik
        public int Id { get; set; }
        public string  Adi { get; set; }

        public double Fiyati { get; set; }
        public string Aciklama{ get; set; }

        public int StokAdedi { get; set; }

    }
}



//klaslar su amaclaa kullanılır bır urunle ılgılı hangı bılgıler var onları stringle belirtiyoruz
//daha sonra double ıle sayı belırtebilitiz açıklama olursa yine strıngle belırtıyoruz
//e ticaret sitesinde urunun adı gelıyo açıklama eski fşyatı busuru sey gelıyor bunların 3 u beraber
//deray veriyor yani class urun hakkındakı bılgılerı tutan anlatan codedır
//string gibi double gıbı class da bı strıng gıbı double gıbı dır
//prop tab tab  yaparsak bbuna özellik deriz