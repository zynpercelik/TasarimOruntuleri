using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class KontrolSistemi
    {
        public int MaxSicaklik { get; set; }
        public int MaxKapasite { get; set; }
        public int DepoId { get; set; }

        public override string ToString()
        {
            return $" Maksimum Sıcaklık : {MaxSicaklik} Maksimum Kapasite : {MaxKapasite} Depo No : {DepoId}";
        }

        public Memento Kaydet()
        {
            return new Memento
            {
                MaxSicaklik = this.MaxSicaklik,
                MaxKapasite = this.MaxKapasite,
                DepoId = this.DepoId
            };
        }

        //T anındaki nesneye bizi ulaşturacak olan metod.
        public void OncekiniYukle(Memento Memento)
        {
            this.MaxSicaklik = Memento.MaxSicaklik;
            this.MaxKapasite = Memento.MaxKapasite;
            this.DepoId = Memento.DepoId;
        }
    }
}
