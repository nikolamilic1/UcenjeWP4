﻿using System;
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
        public ObradaZadatak() 
        {
        Zadaci = new List<Zadatak>();
        }


        public ObradaZadatak(Izbornik izbornik) : this()
        {
            this.Izbornik = izbornik;
          //  Zadaci = new List<Zadatak>();   // ne treba ovo ide samo " : this()" gore
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
                case 3:
                    PromjeniPodatkeZadatka();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiZadatak();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;

            }
        }

        private void ObrisiZadatak()
        {
            PrikaziZadatak();
            var g = Zadaci[Pomocno.UcitajRasponBroja("Odaberi redni broj zadatka za brisanje",1,Zadaci.Count)-1];
            if (Pomocno.UcitajBool("Sigurno obrisati zadatak: " + g.Opis + "? (DA/NE)", "da"))
            {
                Zadaci.Remove(g);
            }
        }

        private void PromjeniPodatkeZadatka()
        {
            var g = Zadaci[Pomocno.UcitajRasponBroja("Odaberi redni broj zadatka za promjenu",1,Zadaci.Count)-1];
            // copy paste sa linije 90-92  -- izvući u metodu!!!
            // nazvao je umjesto odabrana isto kao i dolje (linije 90-92) "g"
            g.Opis = Pomocno.UcitajString(g.Opis, "Unesite opis zadatka", 255, true);
            g.Pocetak = Pomocno.UcitajDatum("Unesite datum početka zadatka", false);
            g.Zavrsetak = Pomocno.UcitajDatum("Unesite datum završetka zadatka", false);
        }

        private void UnosNovogZadatka()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("--- Unesite tražene podatke o zadatku ---");
            Console.WriteLine("-----------------------------------------");

            Zadatak g = new Zadatak();
            g.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru zadatka", 1, int.MaxValue);
            // Projekt
            Izbornik.ObradaProjekt.PrikaziProjekte();
            g.Projekt = Izbornik.ObradaProjekt.Projekti[Pomocno.UcitajRasponBroja("Odaberite redni broj projekta kojem dodjeljujete zadatak", 1, Izbornik.ObradaProjekt.Projekti.Count) - 1];
            g.Opis = Pomocno.UcitajString("Unesite opis zadatka", 255, true);
            g.Pocetak = Pomocno.UcitajDatum("Unesite datum početka zadatka",false);
            g.Zavrsetak = Pomocno.UcitajDatum("Unesite datum završetka zadatka", false);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Uspješno ste unijeli zadatak!");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            // djelatnici
            g.Djelatnici = UcitajDjelatnike();
            Zadaci.Add(g);
        }

        private List<Djelatnik>? UcitajDjelatnike()
        {
           List<Djelatnik?> lista = new List<Djelatnik?>();

            while(Pomocno.UcitajBool("Za dodjeljivanje djelatnika zadatku unesi DA", "da"))
            {
                Izbornik.ObradaDjelatnik.PrikaziDjelatnike();
                lista.Add(
                    Izbornik.ObradaDjelatnik.Djelatnici[
                        Pomocno.UcitajRasponBroja("Odaberi redni broj djelatnika",1,
                        Izbornik.ObradaDjelatnik.Djelatnici.Count)-1
                        ]
                    );
            }

            return lista;
        }

        private void PrikaziZadatak()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("--- Zadaci u aplikaciji ---");
            Console.WriteLine("---------------------------");
            int rb = 0, rbd;   // u app edunova stoji rbp = redni broj polaznika (u ovoj app je redni broj grupe)
            foreach(var g in Zadaci)
            {
                Console.WriteLine(++rb + ". Naziv projekta: " + g.Projekt?.Naziv + "\n   Opis zadatka: " + g.Opis + "\n   Na projektu radi " + + g.Djelatnici?.Count + " djelatnika:"); //prepisati metodu toString
                rbd = 0;
                g.Djelatnici.Sort();
                foreach (var p in g.Djelatnici)
                {
                    Console.WriteLine("\t" + ++rbd +". " + p.Ime + " " + p.Prezime );
                }
            }
            Console.WriteLine("---------------------------");

        }
    }
}
