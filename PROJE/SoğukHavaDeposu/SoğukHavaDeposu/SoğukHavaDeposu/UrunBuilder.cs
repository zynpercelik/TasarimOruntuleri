using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    abstract class UrunBuilder
    {
        protected Urun urun;
        public Urun Urun { get { return urun; } }

        public abstract void SetAd();
        public abstract void SetBirim();
        public abstract void SetMiktar();

    }
    class ElmaBuilder : UrunBuilder
    {
        public ElmaBuilder()
        {
            urun = new Urun();
        }

        public override void SetAd() => urun.Ad = "Elma";
        public override void SetBirim() => urun.Birim = "Kilo";
        public override void SetMiktar() => urun.Miktar = 2635;
    }

    class ErikBuilder : UrunBuilder
    {
        public ErikBuilder()
        {
            urun = new Urun();
        }

        public override void SetAd() => urun.Ad = "Erik";
        public override void SetBirim() => urun.Birim = "Kilo";
        public override void SetMiktar() => urun.Miktar = 725;
    }

    class UrunUret
    {
        public void Uret(UrunBuilder Urun)
        {
            Urun.SetAd();
            Urun.SetBirim();
            Urun.SetMiktar();

        }
    }
}
