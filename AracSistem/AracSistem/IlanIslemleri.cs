using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSistem
{
    public interface IlanIslemleri
    {
       String IlanEkle(Ilan ilan);
        String IlanGuncelle(int ilanId, Ilan yeniIlan);
        String  IlanSil(int ilanId);

    }
}
