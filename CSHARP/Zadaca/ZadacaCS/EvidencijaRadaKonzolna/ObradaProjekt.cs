using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadacaCS.EvidencijaRadaKonzolna.Model;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class ObradaProjekt
    {

        public List<Projekt> Projekti { get; set; }
        public ObradaProjekt()
        {
            Projekti = new List<Projekt>();
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa projektima");
            Console.WriteLine("1. Pregled svih projekata");
            Console.WriteLine("2. Unos novog projekta");
            Console.WriteLine("3. Promjena podataka postojećeg projekta");
            Console.WriteLine("4. Brisanje projekta");
            Console.WriteLine("5. Povratak na glavni izbornik");
        }

    }
}
