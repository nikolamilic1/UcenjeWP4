using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Metode
    {
        public static void Izvedi()
        {
            // poziv metode Tip1()
            //Tip1();
            // Tip1();


            for (int i = 0; i < 55; i++)
            {
                Tip1();
            }

            Tip2("Edunova");
            Tip2(Console.ReadLine);
            Tip2();



            // Tip 1. metoda ne prima parametre i ne vraća vrijednost

            static void Tip1()
            {
                Console.WriteLine("Hello iz metode koja ne prima parametre i ne vraća vrijednost");
                Console.WriteLine("Drugi red");
                Console.WriteLine("Treći red");
            }


            static void Tip2(string ime)
            {
                Console.WriteLine("Hello {0}", ime);
            }

            static void Tip2(string ime, string prezime)
            {
                Console.WriteLine("Hello {0} {1}", ime, prezime);
            }






        }
    }
}
