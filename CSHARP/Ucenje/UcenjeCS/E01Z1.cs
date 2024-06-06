using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z1
    {

        public static void Izvedi()
        {
            int prviBroj;
            Console.WriteLine("Unesi cijeli broj: ");
            prviBroj = int.Parse(Console.ReadLine());

            int drugiBroj;
            Console.WriteLine("Unesi još jedan cijeli broj: ");
            drugiBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Njihov zbroj je: " + (prviBroj + drugiBroj));
        }



    }
}
