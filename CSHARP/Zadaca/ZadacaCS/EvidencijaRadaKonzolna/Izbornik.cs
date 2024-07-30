using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class Izbornik
    {

        public Izbornik() {

            //Console.WriteLine("Hello!");

            PozdravnaPoruka();
            PrikaziIzbornik();

        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Projekt");
            Console.WriteLine("2. Djelatnik");
            Console.WriteLine("3. Zadatak");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("*** Evidencija Rada Console App v 1.0 ***");
            Console.WriteLine("*****************************************");
        }
    }
}
