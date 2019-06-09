using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Depo
    {
        private static Depo dnesne;

        protected Depo() { }


        public static Depo Depo_Nesnesi
        {
            get
            {
                if (dnesne == null)
                {
                    dnesne = new Depo();
                }

                return dnesne;
            }
        }

        public double Sicaklik { get; set; }
        public double Kapasite { get; set; }
        public double YuzOlcumu { get; set; }
        public string InternetSifresi { get; set; }

    }
}
