using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.Edunova;

namespace UcenjeCS.E18KonzolnaAplikacija
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
            Console.WriteLine("1 Pregled svih smjerova");
            Console.WriteLine("2 Promjena podataka postojećeg smjera");
            Console.WriteLine("3 Unos novog smjera");
            Console.WriteLine("4 Brisanje smjera");
            Console.WriteLine("5 Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1,5))
            {
                case 5:
                    Console.WriteLine("Gotov rad sa smjerovima");
                    break;
            }
        }
    }
}
