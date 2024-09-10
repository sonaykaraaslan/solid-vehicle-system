using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace AracSistem
{
    public class Admin : Uye, IlanIslemleri
    {

        public int AdmnNo { get; set; }
        public List<Ilan> Vitrinilan { get; set; }
        public List<Ilan> ilanlar;

        public Admin()
        {
            Vitrinilan = new List<Ilan>();
        }
        public string IlanEkle(Ilan ilan)
        {
            ilan.Id = GenerateIlanId();
            ilanlar.Add(ilan);
            return $"ilan basarıyla eklendi Ilan Id :{ ilan.Id}";

        }

        public string IlanGuncelle(int ilanId, Ilan yeniIlan)
        {
           Ilan ilan=ilanlar.FirstOrDefault(i => i.Id == ilanId);
            if(ilan==null)
                return $"güncellenecek ilan bulunamadı.İlan Id :{ilanId}";
            ilan.Baslik = yeniIlan.Baslik;
            ilan.onay = yeniIlan.onay;
            ilan.Acıklama = yeniIlan.Acıklama;
            ilan.Arac=yeniIlan.Arac;
            return $"güncellenecek ilan bulunamadı.İlan Id :{ilanId}";
        }

        public string IlanSil(int ilanId)
        {
            Ilan ilan = ilanlar.FirstOrDefault(i => i.Id == ilanId);
            if (ilan == null)
                return $"silinecek ilan bulunamadı.İlan Id :{ilanId}";
            ilanlar.Remove(ilan);
            return $"basarıyla silindi.İlan Id :{ilanId}";
        }

        private int GenerateIlanId()
        {
            int maxId=ilanlar.Count > 0 ? ilanlar.Max(i => i.Id) : 0;
            return maxId;
        }
    }
}
        

       
        
           
        
       
       
