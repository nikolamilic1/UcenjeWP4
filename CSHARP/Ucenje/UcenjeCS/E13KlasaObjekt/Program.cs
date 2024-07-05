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


            // Više o upitniku u kodu pročitaj dolje:
            // https://gunnarpeipman.com/csharp-question-marks/
            // https://blog.wordbot.io/tech/what-do-two-question-marks-together-mean-in-c/
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-



            // Još jedan način:
            // Desna strana zna što je lijeva stana.
            // Ovo ne može sa "var o" jer onda ne zna što je
            Osoba o = new()
            {
                Ime = "Ana",
                Prezime = "Kiš"
            };

            // Ovo ispod ne može jer Mjesto nije postavljeno. Daje: "System.NullReferenceException"
            //Console.WriteLine(o.Mjesto.Naziv);



            o.Mjesto = new()
            {
                PostanskiBroj = "31000",
                Zupanija = new()
                {
                    Drzava = new() { Naziv = "Hrvatska" }
                }
            };

            Console.WriteLine(o.Mjesto?.Zupanija?.Drzava?.Naziv ?? "Ne znam");





            // Naziv može biti null. Kad pozoveš null program puca
            // Console.WriteLine(o.Mjesto.Naziv.ToUpper());
            // Zato idu upitnici da ne puca prog. ukoliko nema vrijednosti
            Console.WriteLine(o.Mjesto?.Naziv?.ToUpper());

            // Linija dolje znači: Prošao si mjesto, ako ti je naziv null ispiši "nema" a ako nije ispiši Naziv
            // to se  zove: Null 'colesti' operator ??
            Console.WriteLine(o.Mjesto?.Naziv ?? "Nema");

            //Osoba o = new();


            // Ovjde unutar klase kada se upiše "o." daje/nudi metode u pomoćnom meniju

            // ovo ovdje NE RADI:
            //Osoba o = new();






        }

        // ovdje van klase ne nudi ništa na "o."

        // ovo ovdje radi:
        //Osoba o = new();

    }
}