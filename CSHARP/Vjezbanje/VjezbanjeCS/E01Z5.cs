using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E01Z5
    {
        internal static void Izvedi()
        {
            // Program od korisnika učitava decimalni brojte ispisuje drugi korijen učitanog broja

            Console.WriteLine("Unesi decimalni broj: ");

            double broj;

            broj = double.Parse(Console.ReadLine());

        // https://www.geeksforgeeks.org/c-sharp-math-sqrt-method/

            broj = Math.Sqrt(broj);
            
            Console.WriteLine(broj);


        }
    }
}
