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
            Console.WriteLine("==========================================");
            Console.WriteLine("===  Izbornik za rad sa djelatnicima   ===");
            Console.WriteLine("==========================================");
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
                case 4:
                    ObisiDjelatnika();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;

            }
        }

        private void ObisiDjelatnika()
        {
            PrikaziDjelatnike();
            var odabrani = Djelatnici[Pomocno.UcitajRasponBroja("Odaberi redni broj djelatnika za brisanje", 1, Djelatnici.Count) - 1];
            if(Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Ime + " " + odabrani.Prezime + "? (DA/NE)","da"))
                {
                Djelatnici.Remove(odabrani);
               Console.WriteLine("Djelatnik/ca {0} {1} uspješno obrisan/a.", odabrani.Ime, odabrani.Prezime);
               // Console.WriteLine("Djelatnik {0} uspješno obrisan", odabrani);  --- ovako ne prikazuje ime i prezime već alocirano mjesto u memoriji
            }
        }

        private void PromjeniPodatkeDjelatnika()
        {
            PrikaziDjelatnike();
            var odabrani = Djelatnici[Pomocno.UcitajRasponBroja("Odaberi redni broj djelatnika za promjenu", 1, Djelatnici.Count) - 1];
            odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru djelatnika", 1, int.MaxValue);
            odabrani.Ime = Pomocno.UcitajString(odabrani.Ime, "Unesi ime djelatnika", 50, true);
            odabrani.Prezime = Pomocno.UcitajString(odabrani.Prezime, "Unesi prezime djelatnika", 50, true);
            odabrani.Email = Pomocno.UcitajString(odabrani.Email, "Unesi email djelatnika", 50, true);
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
