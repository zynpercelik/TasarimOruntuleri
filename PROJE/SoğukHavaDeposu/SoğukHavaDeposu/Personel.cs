using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class Personel : Calisan
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

        public override void calisan()
        {

            Console.WriteLine("Bu personel departmanıdır ve çalışan sınıfından üretilmektedir.");
        }

        public override void calisan(string departman)
        {
            if (departman == "Personel")
            {
                Console.WriteLine("{0} karar verme yetkisine sahiptir. ", departman);
            }
            else
            {
                if (_Sonraki == null)
                {
                    Console.WriteLine("Karar vermek için başka yetkili yoktur.");
                }
            }
        }
    }
}
