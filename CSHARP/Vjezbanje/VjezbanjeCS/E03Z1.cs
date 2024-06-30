using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E03Z1
    {

        // Program od korisnika traži unos broja godina koje ima korisnik
        // Program ispisuje je li korisnik punoljetna osoba
        internal static void Izvedi()
        {
            Console.WriteLine("Unesite broj godina: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj >= 18) 
            {
                Console.WriteLine("Osoba je punoljetna");
            }else
            {
                Console.WriteLine("Osoba je maloljetna");
            }

            // ili   ONELINER

            Console.WriteLine(broj>=18 ? "Punoljetna" : "Maloljetna");





        }
    }
}
