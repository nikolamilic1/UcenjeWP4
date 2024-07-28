using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS.E18KonzolnaAplikacija
{
    internal class Izbornik
    {
        public Izbornik() 
        {
            PozdravnaPoruka();
            PrikaziIzbornik();

        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Edunova Console App v 1.0 ***");
            Console.WriteLine("*********************************");

        }
    }
}
