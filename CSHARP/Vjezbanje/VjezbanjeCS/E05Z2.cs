using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{

    //Definirajte dvodimenzionalni niz od 4 elementa koji su decimalni brojevi.
    //Korisnik upisuje vrijednost  ----ovo za DZ
    //Program ispisuje unesene brojeve jedno pokraj dugog odvojeno zarezom
    internal class E05Z2
    {
        internal static void Izvedi()
        {
            int[,] niz = new int[,] {
                {22,222},
                {33,333}
            };

            Console.WriteLine("{0},{1},{2},{3}", niz[0, 0], niz[0, 1], niz[1, 0], niz[1,1]);
        }
    }
}
