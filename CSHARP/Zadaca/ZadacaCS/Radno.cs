using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS
{
    internal class Radno
    {
        internal static void Izvedi()
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };


            for (int i = 0; i < numbers.GetLength(0); i++)
            {
               // Console.Write("Row " + i + ": ");
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
