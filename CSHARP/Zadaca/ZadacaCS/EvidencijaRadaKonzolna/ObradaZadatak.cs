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
        public ObradaZadatak() {
        Zadaci = new List<Zadatak>();
        }
        internal static void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa zadacima");
            Console.WriteLine("1. Pregled svih zadataka");
            Console.WriteLine("2. Unos novog zadatka");
            Console.WriteLine("3. Promjena podataka postojećeg zadatka");
            Console.WriteLine("4. Brisanje zadatka");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private static void OdabirOpcijeIzbornika()
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

        private static void UnosNovogZadatka()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--- Unesite tražene podatke o zadatku ---");
            Console.WriteLine("-----------------------------------------");

            Zadatak g = new Zadatak();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru zadatka", 1, int.MaxValue);
            g.Pocetak = Pomocno.UcitajDatum("Unesite datum početka", true); 
        }

        private void PrikaziZadatak()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--- Zadaci u aplikaciji ---");
            Console.WriteLine("---------------------------");
            foreach(var g in Zadaci)
            {
                Console.WriteLine(g); //prepisati metodu toString

            }
            Console.WriteLine("---------------------------");

        }
    }
}
