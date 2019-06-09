using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroy
{
    class YesilFactory : IUrunFactory
    {
        public IUrunFactoryElma Elma()
        {
            return new  YesilElma();
        }

        public IUrunFactoryErik Erik()
        {
            return new YesilErik();
        }
    }
}
