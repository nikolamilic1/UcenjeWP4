using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForEachPetlja
    {
        internal static void Izvedi()
        {
            string rijec = "osijek";
            for (int i = 0; i < rijec.Length; i++)
            {
                Console.WriteLine(rijec[i]);
            }



            foreach (var znak in rijec)
            {
                Console.WriteLine(znak);
            }



            // vidi ovo dolje;:

       // https://docs.github.com/en/pull-requests/committing-changes-to-your-project/troubleshooting-commits/why-are-my-commits-linked-to-the-wrong-user






        }
    }
}
