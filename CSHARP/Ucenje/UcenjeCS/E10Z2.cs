using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Z2
    {
        internal static void Izvedi()
        {
            {
                Console.WriteLine("Enter a string: ");
                string[] input = Console.ReadLine().Split(' ');

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write(input[i] + " ");
                }
                Console.ReadKey();
            }
        }
    }
}
