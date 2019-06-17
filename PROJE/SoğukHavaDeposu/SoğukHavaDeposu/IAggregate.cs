using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
 
    interface IAggregate
    {
        IIterator CreateIterator();
    }

    interface IIterator
    {
        //Bir sonraki adımda eleman var mı?
        bool HasItem();
        //Bir sonraki adımdaki elemanı getir.
        Personel NextItem();
        //Mevcut elemanı getir.
        Personel CurrentItem();
    }
}
