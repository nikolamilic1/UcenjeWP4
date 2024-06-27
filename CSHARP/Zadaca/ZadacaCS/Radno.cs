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
            Console.WriteLine("Unesite broj redova: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj kolona: ");
            int k = int.Parse(Console.ReadLine());

            int[,] tablica = new int[r, k];
            int redovi = r;
            int kolone = k;
            int pocetakReda = 0;
            int krajReda = r - 1;
            int pocetakKolone = 0;
            int krajKolone = k - 1;

            while (pocetakReda <= krajReda && pocetakKolone <= krajKolone)
            {
                for (kolone = pocetakKolone; kolone <= krajKolone; kolone++) {
                    Console.Write([krajReda,kolone] + " ");
                }
            }





            //for (int i = 0; i < r; i++)
            //{
            //    for (int j = 0; j < k; j++)
            //    {

            //        Console.WriteLine();
            //    }

            //}





        }
    }
}
