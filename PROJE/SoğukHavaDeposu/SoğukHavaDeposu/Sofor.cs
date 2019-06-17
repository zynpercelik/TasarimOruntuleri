using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class Sofor : Calisan
    {
        public override void calisan()
        {

            Console.WriteLine("Bu sürücü departmanıdır ve çalışan sınıfından üretilmektedir.");
        }

        public override void calisan(string departman)
        {
            if (departman == "Şöför")
            {
                Console.WriteLine("{0} karar verme yetkisine sahip değildir. ", departman);
            }
            else
            {
                if (_Sonraki != null)
                    _Sonraki.calisan(departman);
            }
        }
    }
}
