using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E11Metode
    {

        public static void Izvedi()
        {
            // Poziv metode
            // Tip1();
            // Tip1();
            for (int i = 0; i < 55; i++) {
                Tip1();
            }
            Tip2("Edunova");
        }
        // Tip 1. Metoda ne prima parametre i ne vraća vrijednost
        // Ovdje je deklarirana, napisana
        // private se vidi samo u trenutnoj klasi
        private static void Tip1()
        {
            Console.WriteLine("Hello iz metode koje ne prima parametre i ne vraća vrijednost");
            Console.WriteLine("Drugi red");
            Console.WriteLine("Treći red");
        }
        // Tip 2. metoda prima parametre i ne vraća vrijednost
        // kada ispred [static] void nema načina pristupa tada je private

        static void Tip2(string ime)
        {
            Console.WriteLine("Hello {0}", ime);             // wp4 25.06.2024. 00:19:00
        }
    }
}
