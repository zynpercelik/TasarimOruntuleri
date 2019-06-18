using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    public interface IAracDecorator
    {
        void DetayYaz();
        void EkleKM(decimal eklenenkm);
        void EkleTanim(string eklenentanim);
    }
}
