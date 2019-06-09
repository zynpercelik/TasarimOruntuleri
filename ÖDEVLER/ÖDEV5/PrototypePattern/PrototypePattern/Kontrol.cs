using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Kontrol
    {

        public int MaxSicaklik { get; set; }

        public int MaxKapasite { get; set; }

 

        public Kontrol ShallowCopy()
        {

            return (Kontrol)this.MemberwiseClone();

        }


        public Kontrol DeepCopy()
        {
            Kontrol kntrl = (Kontrol)this.MemberwiseClone();
            kntrl.MaxKapasite = this.MaxKapasite;
            kntrl.MaxSicaklik = this.MaxSicaklik;

            return kntrl;
        }
    }


}
