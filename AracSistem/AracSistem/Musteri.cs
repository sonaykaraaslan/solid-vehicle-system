using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSistem
{
    public class Musteri : Uye, Vitrinilan, Ikarsılastır
    {
        public int MusteriNo {  get; set; }
        public Ilan Vitrinilanlari {  get; set; }

        public string Ilankarsılastır()
        {
            return "Araclar karsılastırılıyor.";
        }

        public string VitrinAra()
        {
            return "Vitrin ilanı aranıyor";
        }

        public string VitrinGör()
        {
            if (Vitrinilanlari != null)
                return Vitrinilanlari.ToString();
            else
                return "vitrinde görüntülenecek ilan bulunamadı.";

        }

        public string yorumYap()
        {
            return "Bu arabanın rengi güzel";
        }
    }
}
