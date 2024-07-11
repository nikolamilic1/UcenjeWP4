﻿using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaSmjer
    {

        public List<Smjer>  Smjerovi { get; set; }

        public ObradaSmjer() 
        { 
            Smjerovi = new List<Smjer>();

            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }

        }

        private void UcitajTestnePodatke()
        {
            Smjerovi.Add(new() { Naziv = "Web Programiranje" });
            Smjerovi.Add(new() { Naziv = "Web Dizajn" });
            Smjerovi.Add(new() { Naziv = "Web Serviser" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s smjerovima");
            Console.WriteLine("1. Pregled svih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena podataka postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
           switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziSmjerove();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;
                case 5:                    
                    Console.Clear();
                    break;
            }
        }

        public void PrikaziSmjerove()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Smjerovi u aplikaciji");
            int rb = 0;
            foreach(var s in Smjerovi)
            {
                Console.WriteLine(++rb + ". " + s.Naziv); // prepisati metodu toString
            }
            Console.WriteLine("****************************");
        }

        private void UnosNovogSmjera()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o smjeru");
            Smjerovi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true),
                Trajanje = Pomocno.UcitajRasponBroja("Unesi trajanje smjera", 1, 500),
                Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera", 0, 10000),
                IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kada se izvodi smjer", true),
                Verificiran = Pomocno.UcitajBool("Da li je smjer verificiran (DA/NE)","da")
            });
        }
    }
}
