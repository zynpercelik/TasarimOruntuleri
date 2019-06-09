using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Sofor : Calisan
    {
        public override void calisan()
        {

            Console.WriteLine("Bu sürücü departmanıdır ve çalışan sınıfından üretilmektedir.");
        }
    }
}
