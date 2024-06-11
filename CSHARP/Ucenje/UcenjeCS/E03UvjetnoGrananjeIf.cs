using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {

            int i = 8;

            bool uvjet = i == 7;

            Console.WriteLine(uvjet);

            //minimalna if sintaksa

            if (uvjet)
            {
                Console.WriteLine("1. Ušao sam u if granu");
            }
            // neobavezni dio if grananja

            else
            {
                Console.WriteLine("2. Uvjet nije zadovoljen, otišao u else granu");
            }
            // uobičajena sintaksa što se tiče uvjeta

            if (i > 2)
                Console.WriteLine("3. Ušao u if bez vitičastih zagrada");

        }



    }
}
