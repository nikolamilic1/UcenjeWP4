using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E03Z2
    {
        internal static void Izvedi()
        {

            // Korisnik unosi dva decimalna broja
            // Program ispisuje veći broj ili "jednaki su"  ako su jednaki


            Console.WriteLine("Unesite prvi decimalni broj: ");
            double prviBroj = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi decimalni broj: ");
            double drugiBroj = double.Parse(Console.ReadLine());

            if (prviBroj > drugiBroj)
            {
                Console.WriteLine("Veći broj je: " + prviBroj);

            }
            else if (prviBroj < drugiBroj)
            {
                Console.WriteLine("Veći broj je: " + drugiBroj);
            }
            else
            {
                Console.WriteLine("Brojevi su jednaki");
            }
        }

    }
}

