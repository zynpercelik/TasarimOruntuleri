using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{


    public enum Calisanlar
    {
        Personel,
        Sofor
    }

    class Creater

    {

        public Calisan FactoryMethod(Calisanlar CalisanTipi)
        {
            Calisan calisan = null;
            switch (CalisanTipi)
            {
                case Calisanlar.Personel:
                    calisan = new Personel();
                    break;

                case Calisanlar.Sofor:
                    calisan = new Sofor();
                    break;
            }
            return calisan;
        }
    }
}
