using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
   
    abstract class Calisan
    {
        int Id, Yas, Maas;
        string Ad, Departman, KanGrubu, Sifre;

        public abstract void calisan();
    }
}
