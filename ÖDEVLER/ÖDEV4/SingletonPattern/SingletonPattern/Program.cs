using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            Depo depo1 = Depo.Depo_Nesnesi;
            depo1.Sicaklik = 5;
            Console.WriteLine("Depo2 nesnesi üretilip atama yapılmadan önce Depo1 Sıcaklık: " + depo1.Sicaklik+"\n\n");
            Depo depo2 = Depo.Depo_Nesnesi;
            depo2.Sicaklik = -10;


            if (depo1 == depo2)
            {
                Console.WriteLine("Nesneler singleton pattern ile üretildi.\n\n  Depo1 Sıcaklık: " + depo1.Sicaklik + "\n"+"  Depo2 Sıcaklık: " + depo2.Sicaklik);
                Console.Read();
            }

            else
            {
                Console.WriteLine("Nesneler farklıdır");
                Console.Read();
            }
        }
    }
}
