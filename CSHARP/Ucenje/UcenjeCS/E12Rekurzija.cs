using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12Rekurzija
    {
        //rekurzija je kada metoda poziva samu sebe - nedovoljna definicaja

        
        // OVO SE NE RADI ---- Dovodi do pucanja programa stack overflow exception
        public static void Izvedi()
        {
            //    LosaMetoda();
            //  Console.WriteLine(Zbroj(100));
            Console.WriteLine(Zbroj(Pomocno.UcitajCijeliBroj("Učitaj broj za sumu svih brojeva: ")));
        }

        //static void LosaMetoda()
        //{
        //    LosaMetoda();
        //}
        




        //    do
        //    {
        //        Console.WriteLine(Zbroj(Pomocno.UcitajCijeliBroj("Unesi broj za sumu svih brojeva do tog broja")));
        //    } while () { }

        //}



        private static int Zbroj(int broj)
        {
            // Uvijek prvo napraviti uvijet prekida rekurzije
            if (broj == 0)
            {
                return broj;
            }
            return broj + Zbroj(broj - 1);
        }














    }
}

