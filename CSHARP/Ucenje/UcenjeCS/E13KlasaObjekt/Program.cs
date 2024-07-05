using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt
{
    public class Program
    {
        public static void Izvedi()
        {
            // Klasa je opisnik objekta
            // Objekt je instanca (pojavnost) klase
            // "Osoba" je klasa
            // "osoba" je instanca klase (objekt, varijabla)

            Osoba osoba = new Osoba();


            osoba.Ime = "Pero"; // DZ: Napraviti metodu Pomocno.UcitajString koja osigurava unos <--NAPRAVLJENO

            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.ImePrezime());
            Console.WriteLine(osoba.PrezimeIme());



            // Evo drugog objekta klase osoba:

            Osoba ravnatelj = new Osoba
            {
                Ime = "Eduard",
                Prezime = "Kuzma"
            };


            // Noraju se postavljati sve vrijednosti objekta

            var direktor = new Osoba { Prezime = "Kas" };
            direktor.Ime = "Diki";

            // da bi izbjegli: grešku/pucanje programa "System.NullReferenceException"
            // kraj varijable Ime stavljamo upitnik za slučaj da ime nije postavljeno (kao u našem slučaju):
            Console.WriteLine(direktor.Ime?.ToUpper());

            Osoba o = new()
            {
                Ime = "Ana",
                Prezime = "Kiš"
            };


            o.Mjesto = new() { PostanskiBroj = "31000" };

            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());
            Console.WriteLine(o.Mjesto?.Naziv ?? "Nema");


            






        }       
        
    }
}