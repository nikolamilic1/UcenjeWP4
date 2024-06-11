using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi()
        {



            Console.WriteLine("Unesi godine*?");

            var godine = int.Parse(Console.ReadLine());
            if (godine >= 18)
            {
                Console.WriteLine("osoba je punoljetna");
            }
            else
            {
                Console.WriteLine("osoba je maloljetna");
            }


        }
    }
}