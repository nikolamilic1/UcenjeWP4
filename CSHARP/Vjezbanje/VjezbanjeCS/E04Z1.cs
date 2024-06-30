using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E04Z1
    {

        // korisnik unosi brojčani iznos ocjene.
        // Program ispisuje teksutualnu vrijednost ocjene
        internal static void Izvedi()
        {
            Console.WriteLine("Unesite ocjenu od 1 do 5");
            int ocjena = int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                    case 5:
                    Console.WriteLine("Odličan");
                    break;
                default:
                    Console.WriteLine("To nije ocjena");
                    break;
            }







        }
    }
}
