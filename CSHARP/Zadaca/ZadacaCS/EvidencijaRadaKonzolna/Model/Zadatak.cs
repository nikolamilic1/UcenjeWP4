using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna.Model
{
    internal class Zadatak:Entitet
    {

        public DateTime? Pocetak { get; set; }

        public DateTime? Zavrsetak { get; set; }

        public Projekt? Projekt { get; set; }

        public string? Opis { get; set; }

        // Što sa ostalim kolonama entiteta evidencija_rada??? Jel treba u ovom slučaju napraviti  posebnu klasu za tu tablicu?
        public List<Djelatnik>? Djelatnici { get; set; }

    }
}
