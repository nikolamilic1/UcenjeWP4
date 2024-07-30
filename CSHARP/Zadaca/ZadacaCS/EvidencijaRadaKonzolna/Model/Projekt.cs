using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna.Model
{
    internal class Projekt:Entitet
    {

        public string? Naziv { get; set; }
        public string? Klijent { get; set; }

        public override string ToString()
        {
            return "Sifra=" + Sifra + ", Naziv=" + Naziv + ", Klijent=" + Klijent + ".";
        }

    }
}
