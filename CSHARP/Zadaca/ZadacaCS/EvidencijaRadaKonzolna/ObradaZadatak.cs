using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadacaCS.EvidencijaRadaKonzolna.Model;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class ObradaZadatak
    {
        public List<Zadatak> Zadaci { get; set; }

        private Izbornik Izbornik;  // zbog "this" u  izborniku u new ObradaZadatak(this) plus linije koda 24-28



        //konstruktor gore navedene liste:
        public ObradaZadatak() {
        Zadaci = new List<Zadatak>();
        }


        public ObradaZadatak(Izbornik izbornik)
        {
            this.Izbornik = izbornik;
            Zadaci = new List<Zadatak>();
        }



        public void PrikaziIzbornik()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("=== Izbornik za rad sa zadacima ===");
            Console.WriteLine("===================================");
            Console.WriteLine("1. Pregled svih zadataka");
            Console.WriteLine("2. Unos novog zadatka");
            Console.WriteLine("3. Promjena podataka postojećeg zadatka");
            Console.WriteLine("4. Brisanje zadatka");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku",1,5))
            {
                case 1:
                    PrikaziZadatak();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogZadatka();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;

            }
        }

        private void UnosNovogZadatka()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--- Unesite tražene podatke o zadatku ---");
            Console.WriteLine("-----------------------------------------");

            Zadatak g = new Zadatak();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru zadatka", 1, int.MaxValue);
            // g.Projekt
            Izbornik.ObradaProjekt.PrikaziProjekte();
            g.Projekt = Izbornik.ObradaProjekt.Projekti[Pomocno.UcitajRasponBroja("Odaberite redni broj projekta kojem dodjeljujete zadatak", 1, Izbornik.ObradaProjekt.Projekti.Count) - 1];
            g.Opis = Pomocno.UcitajString("Unesite opis zadatka", 255, true);
            g.Pocetak = Pomocno.UcitajDatum("Unesite datum početka zadatka",false);
            g.Zavrsetak = Pomocno.UcitajDatum("Unesite datum završetka zadatka", false);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Uspješno ste unijeli zadatak!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

        }

        private void PrikaziZadatak()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--- Zadaci u aplikaciji ---");
            Console.WriteLine("---------------------------");
            foreach(var g in Zadaci)
            {
                Console.WriteLine(g.Opis + " (" + g.Projekt?.Naziv + ")"); //prepisati metodu toString
            }
            Console.WriteLine("---------------------------");

        }
    }
}
