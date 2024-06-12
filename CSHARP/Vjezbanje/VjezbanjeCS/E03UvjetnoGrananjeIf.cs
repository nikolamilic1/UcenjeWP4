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
                Console.WriteLine("5. Logičko AND &");
            }
            // & provjerava oba uvjeta bez obzira što je možda prvi FALSE
            // && ukoliko prvi uvjet bude FALSE drugi se ne provjerava

            if (j == 2 || i < 2)
            {
                Console.WriteLine("6. Logičko OR | ");
            }

            //   | (OR) provjerava oba uvjeta bez obzira što prvi bude TRUE
            //  || (OR OR) Ukoliko prvi uvjet bude TRUE drugi uvjet se ne provjerava

            if (i != 5)
            {
                Console.WriteLine("7. i n ema vrijednost 5");
            }

            
            int ocjena = Console.ReadLine();

            if (ocjena == 1)
            {
                Console.WriteLine("8. Ocjena je NEDOVOLJAN");
            }
            else if (ocjena == 2)
            {
                Console.WriteLine("9. Ocjena je DOVOLJAN");
            }
            else if (ocjena == 3)
            {
                Console.WriteLine("10. Ocjena je DOBAR");
            }
            else if (ocjena == 4)
            {
                Console.WriteLine("11. Ocjena je VRLO DOBAR");
            }
            else if (ocjena == 5)
            {
                Console.WriteLine("12. Ocjena je ODLIČAN");
            }
            else if (ocjena < 1 || ocjena > 5)
            {
                Console.WriteLine("Netočan unos. Broj mora biti od 1 do 5");
            }






        }
    }
}
