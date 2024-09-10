using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSistem
{
   public class Arac
    {

        public string Tur {  get; set; }
        public string Marka { get; set;}
        public string Model { get; set;}
        public string Sanzıman { get; set;}
        public string UretimYılı { get; set; }
        public string Kilometre { get; set;}
        public int Motor {  get; set; }
        public int Fiyat {  get; set; }
        public bool OnayDurum { get; set; }
        public Donanım donanım {  get; set; }



    }
}
