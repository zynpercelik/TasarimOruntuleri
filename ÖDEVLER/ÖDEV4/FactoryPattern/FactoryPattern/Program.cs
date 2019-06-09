using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Creater creater = new Creater();
            Calisan calisan1 = creater.FactoryMethod(Calisanlar.Personel);
            Calisan calisan2 = creater.FactoryMethod(Calisanlar.Sofor);

            calisan1.calisan();
            calisan2.calisan();

            Console.Read();

        }
    }
}
