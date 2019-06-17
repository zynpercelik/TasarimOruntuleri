using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{

    class Arac : IAracDecorator
    {
        public string Model { get; set; }
        public decimal Km { get; set; }
        public decimal Yakıt { get; set; }
        public string Tanim { get; set; }

        public Arac()
        {
            Km = 300;
        }


        public void DetayYaz()
        {
            Console.WriteLine(Tanim);
        }

        public void EkleKM(decimal eklenenkm)
        {
            Km += eklenenkm;
        }

        public void EkleTanim(string eklenentanim)
        {
            Tanim = "Model: " + Model + "   Şuanki Km: " + Km + " Yakıt: " + Yakıt + " " + eklenentanim;
        }

    }

    }
