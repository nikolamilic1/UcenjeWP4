using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E07WhilePetlja
    {
        internal static void Izvedi()
        {
            //ponoviti
            // u FOR petlju se ne mora ući
            Console.WriteLine("Unesite broj do kojeg će se izvoditi pelja FOR: ");
            int brojDo = int.Parse(Console.ReadLine());
            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine("Kod u petlji for");
            }
            // WHILE RADI SA BOOL TIPOM PODATKA
            // u WHILE petlju se ne mora ući
            Console.WriteLine("Unesite broj do kojeg će se izvoditi pelja WHILE: ");
            int b = int.Parse(Console.ReadLine());
            while (b < brojDo)
            {
                Console.WriteLine("Kod u petlji while");
            }
        }
    }
}
