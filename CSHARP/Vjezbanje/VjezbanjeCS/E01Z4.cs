using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E01Z4
    {
        internal static void Izvedi()
        {
            // Program od korisnika učitava dvije rečenice i ispisuje jednu nakon druge u istom retku
            Console.WriteLine("Unesi prvu rečenicu: ");
            string recenica1;
            recenica1 = Console.ReadLine();
            Console.WriteLine("Unesi drugu rečenicu: ");
            string recenica2 = Console.ReadLine();
            // prva varijanta
            Console.WriteLine(recenica1 + " " + recenica2);
            // druga varijanta


        }
    }
}
