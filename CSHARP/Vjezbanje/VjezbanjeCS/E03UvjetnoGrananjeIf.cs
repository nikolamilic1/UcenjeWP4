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

            // dodatak (neobavezni dio) IF grananja je ELSE
            else
            {
                Console.WriteLine("2. Uvjet nije zadovoljen, otišao u else granu");
            }

            // uobičajena sintaksa što se tiče uvjeta

            if (i > 2) // ako ne postoje vitičaste zagrade IF se odnosi samo na 1. selijedeću liniju
                Console.WriteLine("3. Ušao u IF bez vitičastih zagrada");
            Console.WriteLine("4. ovo se izvodi bez obzira na gornji if");

            var j = 2;

            // dodatni operatori & (and), && (and and), | (or), || (or or), ! (not) 
            // *** znak | (or) piše se AltGr+W  ***
            // *** čišćenje sintakse ide sa CTRL+K+D ***

            if (i < 2 && j == 2)
            {
                Console.WriteLine("5. Logičko &");
            }
            // & provjerava oba uvjeta bez obzira što je možda prvi FALSE
            // && ukoliko prvi uvjet bude FALSE drugi se ne provjerava









        }
    }
}
