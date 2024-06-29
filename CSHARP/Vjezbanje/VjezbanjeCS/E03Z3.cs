using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E03Z3
    {

        // Za tri učitana cijela broja od strane korisnika program ispisuje najmanji
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
            
            if (prBr < drBr && prBr < trBr  )
            {
                Console.WriteLine(prBr);
            }
            if (drBr < trBr && drBr < prBr)
            {
                Console.WriteLine(drBr);
            }
            if(trBr < prBr && trBr < drBr) 
            {
                Console.WriteLine(trBr); 
            } 
            // Za slučaj da korisnik unese sva tri ista broja: 
            else {Console.WriteLine(prBr);
            }


        }
    }
}
