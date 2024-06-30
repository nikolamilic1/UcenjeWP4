using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        internal static void Izvedi()
        {

            // ako je i==0 ispiši DOBAR, 1 LOŠ, 2 ZAO

            int i = 3;

            switch (i)
            {
                case 0:
                    Console.WriteLine("Dobar");
                    break;
                case 1:
                    Console.WriteLine("Loš");
                    break;
                case 2:
                    Console.WriteLine("Zao");
                    break;
                default:
                    Console.WriteLine("Nije definirano");
                    break;
            }







            }
    }
}
