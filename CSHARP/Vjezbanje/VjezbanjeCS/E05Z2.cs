using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{

    //Definirajte dvodimenzionalni niz od 4 elementa koji su decimalni brojevi.
    //Korisnik upisuje vrijednost  ----ovo za DZ
    //Program ispisuje unesene brojeve jedno pokraj dugog odvojeno zarezom
    internal class E05Z2
    {
        internal static void Izvedi()
        {
            //int[,] niz = new int[,] {
            //    {2,3},
            //    {4,5},
            //};

            int[,] niz = new int[,] {
                 {2,3},   // ne mogu deklarirati prazan niz ???
                 {4,5}
            };
            Console.WriteLine("Unesite prvi element prvog niza: ");
            niz[0, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi element prvog niza: ");
            niz[0, 1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite prvi element drugog niza: ");
            niz[1, 0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi element drugog niza: ");
            niz[1, 1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Vrijednosti nizova su: {0},{1},{2},{3}", niz[0, 0], niz[0, 1], niz[1, 0], niz[1, 1]);
        }
    }
}
