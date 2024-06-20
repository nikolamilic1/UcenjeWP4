using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Z1
    {
        internal static void Izvedi()
        {

            int[] brojevi = new int[10];

            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine("Unesi {0}. broj: ", i+1);
                brojevi[i] = int.Parse(Console.ReadLine());
            }

            int zbroj = 0;
            foreach(var b in brojevi)
            {
                zbroj += b;
            }
            Console.WriteLine(zbroj);
            int index = 0;
            while (index < 10)
            {
                Console.WriteLine(brojevi[index++]);
            }


           











        }
    }
}
