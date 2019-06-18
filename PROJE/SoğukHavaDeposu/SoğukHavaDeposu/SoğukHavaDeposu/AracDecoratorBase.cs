using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    public class AracDecoratorBase : IAracDecorator
    {
        internal IAracDecorator Arac;
        public AracDecoratorBase(IAracDecorator arac)
        {
            Arac = arac;
        }
        void IAracDecorator.DetayYaz()
        {
            Arac.DetayYaz();
        }

        void IAracDecorator.EkleKM(decimal eklenenkm)
        {
            Arac.EkleKM(eklenenkm);
        }

        void IAracDecorator.EkleTanim(string eklenentanim)
        {
            Arac.EkleTanim(eklenentanim);
        }

    }
}
