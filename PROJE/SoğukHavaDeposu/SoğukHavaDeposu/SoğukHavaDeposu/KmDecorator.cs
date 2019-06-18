using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    public class KmDecorator : AracDecoratorBase

    {
        public KmDecorator(IAracDecorator arac)
            : base(arac)
        {
        }

        public void DetayYaz()
        {
            base.Arac.EkleKM(50);
            base.Arac.EkleTanim(" Aracın bilgileri güncellendi");
            base.Arac.DetayYaz();
        }

    }
}
