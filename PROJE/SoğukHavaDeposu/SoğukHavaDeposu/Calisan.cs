using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{

    abstract class Calisan
    {
        int Id, Yas, Maas;
        string Ad, Departman, KanGrubu, Sifre;

        public abstract void calisan();

        //Handler
        protected Calisan _Sonraki;
        public Calisan Sonraki { set { _Sonraki = value; } }

        public abstract void calisan(String departman);
    }
}
