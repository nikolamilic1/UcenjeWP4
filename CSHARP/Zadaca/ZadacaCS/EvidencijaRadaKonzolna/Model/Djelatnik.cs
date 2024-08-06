using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna.Model
{
    internal class Djelatnik:Entitet, IComparable<Djelatnik>
    {

        public string? Ime { get; set; }

        public string? Prezime { get; set; }

        public string? Email { get; set; }

        public int CompareTo(Djelatnik? other)
        {
            
        }
    }
}
