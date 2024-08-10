using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadacaCS.EvidencijaRadaKonzolna.Model;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class ObradaProjekt
    {

        public List<Projekt> Projekti { get; set; }
        public ObradaProjekt()
        {
            Projekti = new List<Projekt>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Projekti.Add(new() { Naziv = "Web stranica"});
            Projekti.Add(new() { Naziv = "Google app"});
            Projekti.Add(new() { Naziv = "Guide app"});
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("=== Izbornik za rad sa projektima ===");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Pregled svih projekata");
            Console.WriteLine("2. Unos novog projekta");
            Console.WriteLine("3. Promjena podataka postojećeg projekta");
            Console.WriteLine("4. Brisanje projekta");
            // ubaciti opciju 5. Detalji projekta
            // kad se uđe u detalje projekta prvo pokaže sve smjerove a ti odabereš broj projekta da bi pokazao detalje
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    PrikaziProjekte();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogProjekta();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromijeniPostojeciProjekt();
                    PrikaziIzbornik();
                    break;
                case 5:
                    //Console.WriteLine("Gotov rad s projektima");  // Ovo se ne vidi jer naredba ispod odmah briše konzolu
                    Console.Clear();
                    break;
            }
        }

        private void PromijeniPostojeciProjekt()
        {
            throw new NotImplementedException();
        }

        public void PrikaziProjekte()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("--- Projekti u aplikaciji: ---");
            Console.WriteLine("------------------------------");
            int rb = 0;
            foreach(var s in Projekti)
            {
                Console.WriteLine(++rb + ". " + s.Naziv);  // prepisati metodu toString
            }
            Console.WriteLine("------------------------------");
        }

        private void UnosNovogProjekta()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("--- Unesite tražene podatke o projektu ---");
            Console.WriteLine("------------------------------------------");
            Projekti.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru projekta", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv projekta", 50, true),
                Klijent = Pomocno.UcitajString("Unesi ime klijenta", 50, true),
                // ovo će ići u klasu Zadatak
                //Pocetak = Pomocno.UcitajDatum("Unesi datum početka zadatka",true)

            }
                );
        }
    }
}
