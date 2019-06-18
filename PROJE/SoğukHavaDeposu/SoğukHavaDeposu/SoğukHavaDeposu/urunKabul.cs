using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    abstract class urunKabul
    {
        private List<ICalisan> calisanlar = new List<ICalisan>();

        private List<Urun2> urunler = new List<Urun2>();
        private Urun2 Soğan;

        public void Bilgilendir(ICalisan calisan)
        {

            calisanlar.Add(calisan);
        }

        public void Bilgilendirme(ICalisan calisan)
        {
            calisanlar.Remove(calisan);

        }

        public void Degisiklik()
        {
            foreach (ICalisan calisan in calisanlar)
            {
                calisan.Update(this);
            }

        }

        public void YeniBilgilendirme(Urun2 urun)
        {

            urunler.Add(urun);
            this.Soğan = urun;
            Degisiklik();
        }

        public Urun2 GetUrun()
        {
            return Soğan;
        }
    }
    }
