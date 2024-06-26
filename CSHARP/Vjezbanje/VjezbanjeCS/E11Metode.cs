using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E11Metode
    {

        public static void Izvedi()
        {
            // Poziv metode
            Tip1();
            Tip1();

        }

        private static void Tip1()
        {
            Console.WriteLine("Hello iz metode koje ne prima parametre i ne vraća vrijednost");
            Console.WriteLine("Drugi red");
            Console.WriteLine("Treći red");
        }

    }
}
