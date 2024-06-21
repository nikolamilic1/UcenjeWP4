using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z5
    {

        public static void Izvedi()
        {

            Console.WriteLine("Unesi decimalni broj: ");
            // sqrt ne prima decimal, ali prima double

            var decBroj = double.Parse(Console.ReadLine());
            decBroj = Math.Sqrt(decBroj);
            Console.WriteLine("drugi korijen je " + decBroj);

            // bez varijable decBroj


            Console.WriteLine("Unesi decimalni broj: ");
            Console.WriteLine(Math.Sqrt(double.Parse(Console.ReadLine())));




        }
    }
}
