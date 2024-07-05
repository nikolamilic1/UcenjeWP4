using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt
{

    //Klasa je opisnik objekta
    internal class Osoba
    {
        // Klasa sadrži svojstva (property)
        // kratica "prop" i automatski piše svojstvo
        public string? Ime { get; set; } // OOP princip učahurivanje  -- svojstvo gdje klasa sakrije svoja svojstva ali ih ostavi dostupne putem javnih get i set metoda

        public string? Prezime { get; set; }

        public int Sifra { get; set; } // ako nema upitnika, ne može biti null


        public Mjesto? Mjesto { get; set; }



        // klasa može sadržavati i metode

        public string ImePrezime()
        {
            return Ime + " " + Prezime;
        }

        public string PrezimeIme()
        { 
        return Prezime + " " + Ime;
        }











    }
}
