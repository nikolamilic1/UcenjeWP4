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

            double x;

            Console.WriteLine("Unesi decimalni broj: ");

                        x = double.Parse(Console.ReadLine());

            // https://www.geeksforgeeks.org/c-sharp-math-sqrt-method/

            x = Math.Sqrt(x);
            
            Console.WriteLine(x);

            // da se ne koristi varijabla X

            Console.WriteLine("Unesi decimalni broj: ");
            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));

        }
    }
}
