using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class Izbornik
    {
        public ObradaProjekt ObradaProjekt { get; set; } // = new ObradaProjekt();  // da se ne mora raditi instanca u konstruktoru

        public ObradaDjelatnik ObradaDjelatnik { get; set; } // = new ObradaDjelatnik();

        public ObradaZadatak ObradaZadatak { get; set; } // = new ObradaZadatak();

        public Izbornik() {

            //Console.WriteLine("Hello!");

            //Pomocno.DEV=true;
            ObradaProjekt = new ObradaProjekt();
            ObradaDjelatnik = new ObradaDjelatnik();
            ObradaZadatak = new ObradaZadatak(this);
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();

        }

        private void UcitajPodatke()
        {
            throw new NotImplementedException();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=== Glavni izbornik ===");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Projekt");
            Console.WriteLine("2. Djelatnik");
            Console.WriteLine("3. Zadatak");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        public void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    Console.Clear();
                    ObradaProjekt.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaDjelatnik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaZadatak.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije! Doviđenja!");
                    SpremiPodatke();
                    break;

            }
        }

        private void SpremiPodatke()
        {
            if (Pomocno.DEV)     // ako je DEV uključen neće upisivati u fajl
            {
                return;
            }
            // Ispisat će u konzolu
            //Console.WriteLine(JsonConvert.SerializeObject(ObradaProjekt.Projekti));

            // Ispisuje u file u JSON formatu
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "projekti.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaProjekt.Projekti));
            outputFile.Close();

        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*** Evidencija Rada - Console App v 1.0 ***");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
        }
    }
}
