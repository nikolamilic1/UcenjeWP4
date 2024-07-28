using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VjezbanjeCS.E18KonzolnaAplikacija.Model;

namespace VjezbanjeCS.E18KonzolnaAplikacija
{
    internal class ObradaSmjer
    {

        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer() 
        {
            Smjerovi = new List<Smjer>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa smjerovima");
            Console.WriteLine("1. Pregled svih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena podataka postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
        }
    }
}
