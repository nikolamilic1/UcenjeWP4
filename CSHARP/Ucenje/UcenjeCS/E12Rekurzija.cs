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
        //rekurzija je kada metoda poziva samu sebe - dedovoljna definicaja






        public static void Izvedi()
        {
            //LosaMetoda();
            do
            {
                Console.WriteLine(Zbroj(Pomocno.UcitajCijeliBroj("Unesi broj za sumu svih brojeva do tog broja")));
            } while () { }

        }

            private static int Zbroj(int broj)
            {
                if (broj == 0)
                {
                    return broj;
                }
                return broj + Zbroj(broj - 1);
            }




            
        

        static void LosaMetoda()
        {
            LosaMetoda();
        }
    }
}
