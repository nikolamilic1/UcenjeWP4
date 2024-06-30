using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E03Z4
    {

        /*Program učitava od korisnika ime grada. 
         U ovisnosti  o imenu grada ispisuje regiju prema slijedećem
        Osijek -> Slavonija
        Zadar -> Dalmacija
        Čakovec -> Međimurje
        Pula -> Istra
        Za ostale unose program ispisuje: Ne znam koja je to regija
         */
        internal static void Izvedi()
        {
            Console.WriteLine("Unesite ime grada: ");

            string grad = Console.ReadLine(); ;

            if (grad == "Osijek")
            {
                Console.WriteLine("Slavonija");
            }
            else if (grad == "Zadar")
            {
                Console.WriteLine("Dalmacija");
            }
            else if (grad == "Čakovec")
            {
                Console.WriteLine("Međimurje");
            }
            else if (grad == "Pula")
            {
                Console.WriteLine("Istra");
            }
            else
            {
                Console.WriteLine("Ne znam koja je to regija");
            }

            Console.WriteLine("======================================");

            // --------- DRUGA VARIJANTA: SA CASE ----------------

            switch (grad)
            {
                case "Osijek":
                    Console.WriteLine("Slavonija");
                    break;
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
                case "Čakovec":
                    Console.WriteLine("Međimurje");
                    break;
                case "Pula":
                    Console.WriteLine("Istra");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }






        }
    }
}
