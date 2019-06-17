using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class PersonelAggregate : IAggregate
    {

        List<Personel> PersonelListesi = new List<Personel>();
        public void Add(Personel Model) => PersonelListesi.Add(Model);
        public Personel GetItem(int index) => PersonelListesi[index];
        public int Count { get => PersonelListesi.Count; }
        public IIterator CreateIterator() => new PersonelIterator(this);

    }
}
