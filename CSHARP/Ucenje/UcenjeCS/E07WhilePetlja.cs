using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E07WhilePetlja
    {
        internal static void Izvedi()
        {
            int brojDo = 1;
            for (int i = 0; i < brojDo; i++)
            {

                Console.WriteLine("Kod u petlji for ");
            }


            // U while petlju se ne mora ući

            int b = 0;
            while (b < brojDo)
            {
                Console.WriteLine("kod u petlji while");
            }

            // while radi s bool tipom podatka

            while (true)
            {
                Console.WriteLine("Kod u beskonačnoj petlji while");
                break;
            }
