using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z4
    {
        internal static void Izvedi()
        {


            string grad = "Valpovo";
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

                Console.WriteLine("Neka druga regija");

            }

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

                
                    
                   // Console.WriteLine("Ne poznajem regiju");

            }









        }
    }


}
