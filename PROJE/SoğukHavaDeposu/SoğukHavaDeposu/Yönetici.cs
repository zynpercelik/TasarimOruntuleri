using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class Yonetici : ICalisan
    {
        private string yoneticiAdi;

        public Yonetici()
        {
        }

        public Yonetici(string aadi)
        {

            this.yoneticiAdi = aadi;

        }
        void ICalisan.Update(urunKabul urunKabul)
        {

            Console.WriteLine("" + this.yoneticiAdi + " 'e " + urunKabul.GetUrun().Adi + " isimli üründen  " + urunKabul.GetUrun().Miktar + " kg miktarında giriş yapıldığı bilgisi aktarıldı.");
        }

    }
}
