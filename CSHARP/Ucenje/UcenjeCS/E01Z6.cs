using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z6
    {
        internal static void Izvedi()
        {
            Console.WriteLine("Upišite ime grada: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Upišite broj stanovnika: ");
            int broj = int.Parse(Console.ReadLine());
            //Console.WriteLine("U gradu " + ime + " živi " + broj + " stanovnika.");
            Console.WriteLine("U {0} živi {1} stanovnika.",ime,broj);
        }
    }
}
