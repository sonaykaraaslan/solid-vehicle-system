using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSistem
{
    public class Ilan : IlanOnay
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Acıklama { get; set; }

        public Arac Arac { get; set; }
        public bool onay { get; set; }

        
    }
}
