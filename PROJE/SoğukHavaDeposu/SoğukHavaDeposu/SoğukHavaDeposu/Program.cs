using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoğukHavaDeposu
{
    class Program
    {
        static void Main(string[] args)
        {
            /************************ 1- FACTORY PATTERN  **************************/
            Console.WriteLine("\n" + "/******************Factory Pattern Çalıştı**************/" + "\n");
            Creater creater = new Creater();
            Calisan calisan1 = creater.FactoryMethod(Calisanlar.Personel);
            Calisan calisan2 = creater.FactoryMethod(Calisanlar.Sofor);
            calisan1.calisan();
            calisan2.calisan();

            /************************ 2- SINGLETON PATTERN  **************************/
            Console.WriteLine("\n" + "/******************Singleton Pattern Çalıştı**************/" + "\n");

            Depo depo1 = Depo.Depo_Nesnesi;
            depo1.Sicaklik = 5;
            Console.WriteLine("Depo1 nesnesi üretildi Depo1 Sıcaklık: " + depo1.Sicaklik + "\n");
            Depo depo2 = Depo.Depo_Nesnesi;
            depo2.Sicaklik = -10;
            Console.WriteLine("Depo2 nesnesi üretildi Depo2 Sıcaklık: " + depo2.Sicaklik + "\n");

            if (depo1 == depo2)
            {
                Console.WriteLine("Nesneler singleton pattern ile üretildiği için depo1 depo2'deki değişiklikten etkilendi.\n  Depo1 Sıcaklık: " + depo1.Sicaklik + "\n" + "  Depo2 Sıcaklık: " + depo2.Sicaklik);
            }

            else
            {
                Console.WriteLine("Nesneler farklıdır");
            }

            /************************ 3-PROTOTYPE PATTERN  **************************/
            Console.WriteLine("\n" + "/******************Prototype Pattern Çalıştı**************/" + "\n");

            Kontrol kontrol1 = new Kontrol();
            kontrol1.MaxKapasite = 3000;
            kontrol1.MaxSicaklik = -3;
            Console.WriteLine("Kontrol1 oluşturuldu.\n");
            Console.WriteLine("Kontrol1 MaxKapasitesi: " + kontrol1.MaxKapasite + "  Kontrol1 MaxSıcaklık: " + kontrol1.MaxSicaklik + "\n\n");
            Kontrol kontrol2 = kontrol1.DeepCopy();
            kontrol2.MaxKapasite = 2000;
            kontrol2.MaxSicaklik = 0;

            Console.WriteLine("DeepCopy ile Kontrol2 oluşturuldu ve kontrol1 etkilenmedi." + "\n" + "Kontrol2 MaxKapasitesi: " + kontrol2.MaxKapasite + "  Kontrol2 MaxSıcaklık: " + kontrol2.MaxSicaklik + "\n" + "Kontrol1 MaxKapasitesi: " + kontrol1.MaxKapasite + "  Kontrol1 MaxSıcaklık: " + kontrol1.MaxSicaklik + "\n");
            var kontrol3 = kontrol1.ShallowCopy();

            Console.WriteLine("ShallowCopy ile Kontrol3 oluşturuldu ." + "\n" + "Kontrol3 MaxKapasitesi: " + kontrol3.MaxKapasite + "  Kontrol3 MaxSıcaklık: " + kontrol3.MaxSicaklik);


            /************************ 4- OBJECT POOL PATTERN  **************************/
            Console.WriteLine("\n" + "/******************Object Pool Pattern Çalıştı**************/" + "\n");

            Console.WriteLine("Havuzun boyutu {0}", ClientPool.Instance.Size);

            Console.WriteLine("Client sınıfı ediniyoruz.");
            var client1 = ClientPool.Instance.AcquireObject();

            client1.Connect();

            Console.WriteLine("Client'ı geri bırakıyoruz");
            if (client1 != null)
                ClientPool.Instance.ReleaseObject(client1);

            var clients = new List<Client>();
            for (int i = 0; i < ClientPool.Instance.Size; i++)
            {
                clients.Add(ClientPool.Instance.AcquireObject());
            }

            Console.WriteLine("Uygun olan tüm Client nesneleri listeye eklendi.");

            var nullClient = ClientPool.Instance.AcquireObject();

            if (nullClient == null)
                Console.WriteLine("Daha fazla Client sınıfı bulunmamaktadır.");

            Console.WriteLine("Havuzun boyutunu arttırıyoruz");
            ClientPool.Instance.IncreaseSize();

            Console.WriteLine("Yeni bir Client sınıfı ediniyoruz.");
            var newClient = ClientPool.Instance.AcquireObject();

            newClient.Connect();

            Console.WriteLine("Edindiğimiz sınıfı geri veriyoruz.");
            if (newClient != null)
                ClientPool.Instance.ReleaseObject(newClient);

            Console.WriteLine("Listedeki tüm Client sınıflarını geri bırakıyoruz.");

            foreach (var item in clients)
            {
                ClientPool.Instance.ReleaseObject(item);
            }
           
            /************************ 5-ABSTRACT FACTORY PATTERN  **************************/
            Console.WriteLine("\n" + "/******************Abstract Factory Pattern Çalıştı**************/" + "\n");

            IUrunFactory factory = new YesilFactory();
            Console.WriteLine("YeşilFactory çalıştı.\n");
            var YesilElma = factory.Elma();
            var YesilErik = factory.Erik();

            Console.WriteLine(YesilErik.ErikFeature());
            Console.WriteLine(YesilElma.ElmaFeature());

            IUrunFactory factory2 = new KırmızıFactory();
            Console.WriteLine("\nKırmızıFactory çalıştı.\n");
            var KırmızıElma = factory2.Elma();
            var KırmızıErik = factory2.Erik();

            Console.WriteLine(KırmızıErik.ErikFeature());
            Console.WriteLine(KırmızıElma.ElmaFeature());

            /************************ 6- BUILDER PATTERN  **************************/
            Console.WriteLine("\n" + "/******************Builder Pattern Çalıştı**************/" + "\n");

            UrunBuilder urun = new ElmaBuilder();
            UrunUret uret = new UrunUret();
            uret.Uret(urun);

            Console.WriteLine(urun.Urun.ToString());

            urun = new ErikBuilder();
            uret.Uret(urun);
            Console.WriteLine(urun.Urun.ToString());
            
            /************************ 7-ITERATOR PATTERN  **************************/
            Console.WriteLine("\n" + "/****************** Iterator Pattern Çalıştı**************/" + "\n");
            PersonelAggregate aggregate = new PersonelAggregate();
            aggregate.Add(new Personel { Id = 1, Adi = "Personel1", SoyAdi = "Soyad1" });
            aggregate.Add(new Personel { Id = 2, Adi = "Personel2", SoyAdi = "Soyad2" });

            IIterator iterasyon = aggregate.CreateIterator();
            while (iterasyon.HasItem())
            {
                Console.WriteLine($"ID : {iterasyon.CurrentItem().Id}\nAdı : {iterasyon.CurrentItem().Adi}\nSoyadı : {iterasyon.CurrentItem().SoyAdi}\n");
                iterasyon.NextItem();
            }


            /************************ 8-OBSERVER PATTERN  **************************/
            Console.WriteLine("\n" + "/****************** Observer Pattern Çalıştı**************/" + "\n");
            urunKabul kabul = new SebzeKabul();
            ICalisan yonetici = new Yonetici();

            kabul.Bilgilendir(new Yonetici("Murat Bey"));
            kabul.YeniBilgilendirme(new Urun2("Soğan", 5000));

            // Murat bey oluşturulduğu için bundan sonrakilerde otomatik bilgilendirilcek !!!

            kabul.Bilgilendir(new Yonetici("Sinan Bey"));
            kabul.YeniBilgilendirme(new Urun2("Havuç", 750));

            /************************ 9-MEMENTO PATTERN  **************************/
            Console.WriteLine("\n" + "/****************** Memento Pattern Çalıştı**************/" + "\n");

            KontrolSistemi sistem = new KontrolSistemi();
            sistem.MaxSicaklik = -10;
            sistem.MaxKapasite = 2300;
            sistem.DepoId = 1;
            Console.WriteLine(sistem.ToString());

            Caretaker Taker = new Caretaker();
            Taker.Memento = sistem.Kaydet();

            sistem.MaxSicaklik = -12;
            sistem.MaxKapasite = 1850;
            sistem.DepoId = 1;
            Console.WriteLine(sistem.ToString());
            sistem.OncekiniYukle(Taker.Memento);

            Console.WriteLine("\n Sistem önceki durumuna geri döndü.\n"+sistem.ToString());
            
            /************************ 10-CHAIN OF RESPONSİBİLİTY PATTERN  **************************/
            Console.WriteLine("\n" + "/****************** ChainofResponsibility Pattern Çalıştı**************/" + "\n");

            Calisan dep1 = new Sofor();
            Calisan dep2 = new Personel();

            dep1.Sonraki = dep2;

            dep1.calisan("Şöför");
            dep2.calisan("Personel");
            dep2.calisan("Müdür");


            /************************ 11-DECORATOR PATTERN  **************************/
            Console.WriteLine("\n" + "/****************** Decorator Pattern Çalıştı**************/" + "\n");

            Arac arac = new Arac() { Model = "Astra", Km = 100, Yakıt = 120 };
            arac.DetayYaz();
            KmDecorator kmdeco = new KmDecorator(arac);
            kmdeco.DetayYaz();

            KmDecorator kmdeco2 = new KmDecorator(arac);
            kmdeco2.DetayYaz();

            Console.WriteLine("\n\n 11 Adet pattern çalıştı.");
            Console.ReadLine();

        }
    }
    }

