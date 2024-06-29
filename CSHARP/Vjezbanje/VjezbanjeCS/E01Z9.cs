using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E01Z9
    {

        /* Program učitava od korisnika tri broja.
         * Program ispisuje razliku druga dva broja pribrojeno  prvom broju
         */
                
        internal static void Izvedi()
        {

            int prBr;
            int drBr;
            int trBr;
            Console.WriteLine("Upiši prvi broj");
            prBr = int.Parse(Console.ReadLine());
            Console.WriteLine("Upiši drugi broj");
            drBr = int.Parse(Console.ReadLine());
            Console.WriteLine("Upiši treći broj");
            trBr = int.Parse(Console.ReadLine());
            Console.WriteLine(prBr + drBr - trBr);
        }
    }
}
