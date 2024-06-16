using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z9
    {
        internal static void Izvedi()
        {
            Console.WriteLine("Unesi prvi broj: ");
            int broj1;
            broj1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi drugi broj: ");
            int broj2;
            broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesi treći broj: ");
            int broj3;
            broj3 = int.Parse(Console.ReadLine());
            int ispis = (broj1 + (broj2 - broj3));
            Console.WriteLine("Rješenje je: " + ispis);
        }
    }
}
