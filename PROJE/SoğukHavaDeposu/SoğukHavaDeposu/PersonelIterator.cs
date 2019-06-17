using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class PersonelIterator : IIterator
    {
        PersonelAggregate aggregate;
        int currentindex;
        public PersonelIterator(PersonelAggregate aggregate) => this.aggregate = aggregate;
        public Personel CurrentItem() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public Personel NextItem()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);
            return new Personel();
        }
    }
}
