using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadacaCS.EvidencijaRadaKonzolna.Model;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class ObradaDjelatnik
    {

        public List<Djelatnik> Djelatnici { get; set; }
        private Izbornik Izbornik;
        public ObradaDjelatnik()
        {
            Djelatnici = new List<Djelatnik>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            for (int i = 0; i < 10; i++)
            {
                Djelatnici.Add(new()
                {
                    Ime = Faker.Name.First(),
                    Prezime = Faker.Name.Last()
                });
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa djelatnicima");
            Console.WriteLine("1. Pregled svih djelatnika");
            Console.WriteLine("2. Unos novog djelatnika");
            Console.WriteLine("3. Promjena podataka postojećeg djelatnika");
            Console.WriteLine("4. Brisanje djelatnika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziDjelatnike();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromjeniPodatkeDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;

            }
        }


            private void UnosNovogDjelatnika()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("--- Unesite tražene podatke o djelatniku ---");
            Console.WriteLine("--------------------------------------------");
            Djelatnici.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru djelatnika",1,int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime djelatnika",50,true),
                Prezime = Pomocno.UcitajString("Unesi prezime djelatnika",50,true),
                Email = Pomocno.UcitajString("Unesi email djelatnika",50,true)
            } 
                );
        }

        public void PrikaziDjelatnike()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("--- Djelatnici u aplikaciji ---");
            Console.WriteLine("-------------------------------");
            int rb = 0;
            foreach (var p in Djelatnici) 
            {
                Console.WriteLine(++rb + ". " + p.Ime + " " + p.Prezime);  //prepisati metodu to string
            }
            Console.WriteLine("-------------------------------");
        }


    }
}
