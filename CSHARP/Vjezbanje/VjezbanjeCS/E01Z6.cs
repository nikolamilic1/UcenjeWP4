using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E01Z6
    {
        internal static void Izvedi()
        {
            // Program od korisnika učitava ime grada i broj stanovnika
            // Ispisuje rečenicu: U xy gradu živi xyz stanovnika.


            Console.WriteLine("Upiši ime grada: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Upiši broj stanovnika: ");
            string broj = Console.ReadLine();
            Console.WriteLine("Grad " + ime + " ima " + broj + " stanovnika.");
        }
    }
}
