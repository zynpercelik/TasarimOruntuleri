using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroy
{
    class KırmızıFactory : IUrunFactory
    {
        public IUrunFactoryElma Elma()
        {
            return new KırmızıElma();
        }

        public IUrunFactoryErik Erik()
        {
            return new KırmızıErik();
        }
    }
}
