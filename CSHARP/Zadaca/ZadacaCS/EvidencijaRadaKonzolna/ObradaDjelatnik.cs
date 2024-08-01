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

        private static void OdabirOpcijeIzbornika()
        {
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika",1,5))
            {
                case 1:
                    PrikaziDjelatnike();
                    PrikaziIzbornik();
                    break;
                    case 2:
                    UnosNovogDjelatnika();
                    PrikaziIzbornik();
                    break;
                    case 5:
                    Console.Clear();
                    break;
            
            }
        }

        private static void UnosNovogDjelatnika()
        {
            throw new NotImplementedException();
        }

        private static void PrikaziDjelatnike()
        {
            throw new NotImplementedException();
        }
    }
}
