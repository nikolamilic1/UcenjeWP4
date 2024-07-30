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
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {

                case 1:
                    UnosNovogProjekta();
                    PrikaziIzbornik();
                    break;
                case 5:
                    //Console.WriteLine("Gotov rad s projektima");  // Ovo se ne vidi jer naredba ispod odmah briše konzolu
                    Console.Clear();
                    break;
            }
        }

        private void UnosNovogProjekta()
        {
            Projekti.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera",1,int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv projekta",50, true)
            }
                );
        }
    }
}
