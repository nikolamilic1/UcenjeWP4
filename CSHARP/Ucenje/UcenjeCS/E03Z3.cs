﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E03Z3
    {
        internal static void Izvedi()
        {
            Console.WriteLine("Unesi prvi broj: ");
            int b1=int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi prvi broj: ");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesi prvi broj: ");
            int b3 = int.Parse(Console.ReadLine());

            if (b1<b2 && b1<b3)
            {
                Console.WriteLine(b1);
            }
            if (b2 < b1 && b2 < b3)
            {
                Console.WriteLine(b2);
            }
            if (b3 < b1 && b3 < b2)
            {
                Console.WriteLine(b3);
            }
            else
            {
                Console.WriteLine(b1);
            }
        }
    }
}
