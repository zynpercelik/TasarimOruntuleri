using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            UrunBuilder urun = new ElmaBuilder();
            UrunUret uret = new UrunUret();
            uret.Uret(urun);

            Console.WriteLine(urun.Urun.ToString());

            urun = new ErikBuilder();
            uret.Uret(urun);
            Console.WriteLine(urun.Urun.ToString());

            Console.Read();
        }
    }
}
