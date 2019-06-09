using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroy
{
     class Program {


        static void Main(string[] args)
        {

           IUrunFactory factory = new YesilFactory();
            var YesilElma = factory.Elma();
            var YesilErik= factory.Erik();

            Console.WriteLine(YesilErik.ErikFeature());

            Console.WriteLine(YesilElma.ElmaFeature());

            IUrunFactory factory2 = new KırmızıFactory();
            var KırmızıElma = factory2.Elma();
            var KırmızıErik = factory2.Erik();

            Console.WriteLine(KırmızıErik.ErikFeature());

            Console.WriteLine(KırmızıElma.ElmaFeature());

            Console.Read();

        }
    }
}
