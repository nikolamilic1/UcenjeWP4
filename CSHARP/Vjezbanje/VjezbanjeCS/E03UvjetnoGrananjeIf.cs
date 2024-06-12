using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E03UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {

            int i = 8; // Ne koristimo Console.ReadLine kako bi bili brži

            // Uvjetno grananje IF radi s bool tipom podataka

            bool uvjet = i == 7;

            Console.WriteLine(uvjet);

            // Minimalna sintaksa

            if (uvjet)
            {
                Console.WriteLine("1. Ušao sam u if granu");
            }
            else
            {
                Console.WriteLine("2. Uvjet nije zadovoljen, otišao u else granu");
            }











            } 
    }
}
