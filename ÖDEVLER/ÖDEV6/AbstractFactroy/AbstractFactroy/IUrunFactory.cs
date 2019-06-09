using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactroy
{
    public interface IUrunFactory
    {
        IUrunFactoryElma Elma();

        IUrunFactoryErik Erik();
    }

    public interface IUrunFactoryErik
    {
        string ErikFeature();
    }

    public interface IUrunFactoryElma
    {
        string ElmaFeature();
    }

    class YesilElma : IUrunFactoryElma
    {
        public string ElmaFeature()
        {
            return "Bu ürün yeşil elma özelliklerini taşımaktadır.";
        }
    }

    class KırmızıElma : IUrunFactoryElma
    {
        public string ElmaFeature()
        {
            return "Bu ürün kırmızı elma özelliklerini taşımaktadır.";
        }
    }

    class YesilErik : IUrunFactoryErik
    {
        public string ErikFeature()
        {
            return "Bu ürün yeşil erik özelliklerini taşımaktadır.";
        }
    }

    class KırmızıErik : IUrunFactoryErik
    {
        public string ErikFeature()
        {
            return "Bu ürün kırmızı erik özelliklerini taşımaktadır.";
        }
    }
}
