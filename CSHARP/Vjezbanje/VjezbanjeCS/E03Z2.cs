using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E03Z2
    {
        internal static void Izvedi()
        {

            // Korisnik unosi dva decimalna broja
            // Program ispisuje veći broj ili "jednaki su"  ako su jednaki


            Console.WriteLine("Unesite prvi decimalni broj: ");
            double prviBroj = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi decimalni broj: ");
            double drugiBroj = double.Parse(Console.ReadLine());

            if (prviBroj > drugiBroj)
            {
                Console.WriteLine("Veći broj je: " + prviBroj);

            }
            else if (prviBroj < drugiBroj)
            {
                Console.WriteLine("Veći broj je: " + drugiBroj);
            }
            else
            {
                Console.WriteLine("Brojevi su jednaki");
            }

            // Drugi način (sa nizom)

            float[] b = new float[2];
            Console.WriteLine("Unesite prvi broj: ");
            b[0] = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            b[1] = float.Parse(Console.ReadLine());

            if (b[1] == b[0])
            {
                Console.WriteLine("Jednaki su");
            }
            else {
                Console.WriteLine(b[0] > b[1] ? b[0] : b[1]);
            }
            /* može i ovako else izgledati:  DVA UGNJEŽĐENA INLINE TIPA
             * else {
                Console.WriteLine(
                    b[1] == b[0] ? "Jednaki su" :
                    b[0] > b[1] ? b[0] : b[1]);
             *  Čitaj: Ako b1 jednako b0 ispiši "jednaki su", 
             *  ako je b0 veće od b1 ispiši b0,
             *  inače ispiši b1
             */


        }

    }
}

