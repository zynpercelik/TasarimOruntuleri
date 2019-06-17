using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class Urun
    {
        public string Ad { get; set; }
        public string Birim { get; set; }
        public double Miktar { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
     

        public override string ToString()
        {
            return $"{Ad} meyvesi {Birim} cinsinden {Miktar} miktarında olarak üretilmiştir.";
        }
    }
}
