using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VjezbanjeCS
{
    internal class E05Nizovi
    {
        internal static void Izvedi()
        {
            // NIZOVI = (eng.) arrays
            // još na hrvatskom ih zovu POLJA

            // Jednodimenzionalni niz
            //altGr+F = [   altGr+F = ]
            int[] godine = new int[12];

            godine[0] = 43; // Element na indeksu poprima vrijednost 43

            godine[godine.Length - 1] = 23;  // Na zadnji element postavljam vrijednost 23


            Console.WriteLine(godine);


            // Ovako ispisuje cijeli NIZ:

            Console.WriteLine(string.Join(",", godine));

            // Skraćena sintaksa definiranja niza skupa s zadanim vrijednostima

            int[] niz = { 2, 3, 4, 5, 6, 7, 8, 4, 5, 7, 4, 4 };

            // Ispis niza niz
            Console.WriteLine(string.Join("-", niz));


            //kako ispisati broj 3 iz niza? Ovako:
            Console.WriteLine(niz[1]);


            string[] gradovi = { "Osijek", "Donji Miholjac", "Valpovo" };

            Console.WriteLine(string.Join(", ", gradovi));

            // DVODIMENZIONALNI NIZ
            // tablica, matrica

            int[,] tablica = {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 }
            };

            Console.WriteLine(tablica[0,2]);

            // zvjezdane staze :)
            // u varijablu multiverse može se pohraniti 100 000 podataka

            int[,,,,] multiverse = new int[10, 10, 10, 10, 10 ];

            /* ovo se radi npr u prodaji (4dimenzionalni niz): 
               prodajni kanal(internet,trgovina,trgovački putnik), 
             * regija (sjever, središnja jug ...), 
             * proizvod (prepaid, postpaid ...), 
             * vrijeme 
             */



            // smisao nizova je da budu istog tipa
            // ali moguće je napraviti niz objekata sa različitim tipovima podatak
            // to se uglavnom ne radi, jer smisao nizova je da rade sa jednim tipom podatka
            object[] objekti = { 1, "Pero", true, 2.2 };

            // problem nizova je što se unaprijed treba odrediti koliko zin uzima elemenata
            // to zauzima memoriju, možda bez potrebe

        }
    }
}
