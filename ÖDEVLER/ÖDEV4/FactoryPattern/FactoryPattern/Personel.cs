﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Personel : Calisan
    {
        public override void calisan()
        {

            Console.WriteLine("Bu personel departmanıdır ve çalışan sınıfından üretilmektedir.");
        }
    }
}

