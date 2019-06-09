using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            /*                      Shallow clone - Deep Clone                        */

            Kontrol kontrol1 = new Kontrol();

            kontrol1.MaxKapasite = 3000;
            kontrol1.MaxSicaklik = -3;

            Console.WriteLine("Kontrol1 oluşturuldu.\n");

            Console.WriteLine("Kontrol1 MaxKapasitesi: " + kontrol1.MaxKapasite + "  Kontrol1 MaxSıcaklık: " + kontrol1.MaxSicaklik+"\n\n");


            Kontrol kontrol2 = kontrol1.DeepCopy();
            kontrol2.MaxKapasite = 2000;
            kontrol2.MaxSicaklik = 0;

            Console.WriteLine("DeepCopy ile Kontrol2 oluşturuldu ve kontrol1 etkilenmedi." + "\n" + "Kontrol2 MaxKapasitesi: " + kontrol2.MaxKapasite + "  Kontrol2 MaxSıcaklık: " + kontrol2.MaxSicaklik + "\n" + "Kontrol1 MaxKapasitesi: " + kontrol1.MaxKapasite + "  Kontrol1 MaxSıcaklık: " + kontrol1.MaxSicaklik+"\n\n");

            var kontrol3 = kontrol1.ShallowCopy();
        

            Console.WriteLine("ShallowCopy ile Kontrol3 oluşturuldu ." + "\n" + "Kontrol3 MaxKapasitesi: " + kontrol3.MaxKapasite + "  Kontrol3 MaxSıcaklık: " + kontrol3.MaxSicaklik);
          
            Console.Read();

        }
    }
}
