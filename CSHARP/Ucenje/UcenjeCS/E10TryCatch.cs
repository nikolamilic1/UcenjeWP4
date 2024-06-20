using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10TryCatch
    {
        internal static void Izvedi()
        {

            

            int i;
            while (true)
            {
                Console.WriteLine("Unesi cijeli pozitivni broj manji od 100: ");
                try
                {
                    i = int.Parse(Console.ReadLine());
                    if (i > 0 && i<100)
                    {
                        break;
                    }
                    Console.WriteLine("Uneseni broj nije veći od nule ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Niste unijeli broj");
                }

            }

            // ovdje si siguran da imaš cijeli broj

            Console.WriteLine("Unijeli ste broj " + i);




        }
    }
}
