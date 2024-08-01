using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class ObradaDjelatnik
    {
        internal static void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad sa djelatnicima");
            Console.WriteLine("1. Pregled svih djelatnika");
            Console.WriteLine("2. Unos novog djelatnika");
            Console.WriteLine("3. Promjena podataka postojećeg djelatnika");
            Console.WriteLine("4. Brisanje djelatnika");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }
    }
}
