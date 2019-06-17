using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class Urun2
    {
        public String Adi { get; set; }
        public int Miktar { get; set; }

        public Urun2(string mAdi, int mMiktar)
        {
            this.Adi = mAdi;
            this.Miktar = mMiktar;
        }
    }
}
