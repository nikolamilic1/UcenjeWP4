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
            // WHILE radi sa BOOL tipom podataka
            // IF    radi sa BOOL tipom podataka

            // SWITCH radi sa STRING, INT i CHAR tipom podataka


            // u WHILE petlju se ne mora ući
            Console.WriteLine("Unesite broj do kojeg će se izvoditi pelja WHILE: ");
            int b = int.Parse(Console.ReadLine());
            while (b < brojDo)
            {
                Console.WriteLine("Kod u petlji while");
            }


            while (true)
            {
                Console.WriteLine("Kod u beskonačnoj pelji while");
                break;   // continue radi isto kao i u FOR
            }

            // ispiši prvih 10 brojeva
            b = 0;
            while (b < 10)
            {
                Console.WriteLine(++b);
                ////druga varijanta:
                //b++;
                //Console.WriteLine(b);
            }



        }
    }
}
