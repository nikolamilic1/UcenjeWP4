using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.LjubavniKalkulator2
{
    internal class Program
    {

        public Program()
        {
            pozdravna();
        Pocetak:
            var ime1 = "";
            var ime2 = "";
            Console.Write("Unesite prvo ime:");
            ime1 = Console.ReadLine();
            Console.Write("Unesite drugo ime:");
            ime2 = Console.ReadLine();
            ime1 = ime1.Trim();
            ime2 = ime2.Trim();
            //Provjera ispravnog unosa znaka
            bool ispravno = true;
            foreach (var z in ime1)
            {
                if (!char.IsLetter(z))
                {
                    ispravno = false;
                    break;
                }
            }
            if (!ispravno)
            {
                Console.WriteLine("Unos imena nije dobar.");
                goto Ponovi;
                return;
            }

            string s = ime1.ToLower() + ime2.ToLower();


            Console.WriteLine("==================================");
            Console.WriteLine(s);
            Console.WriteLine("==================================");
            int[] brojevi = new int[s.Length];
            //ivicamarica

            int u;
            for (int i = 0; i < s.Length; i++)
            {
                u = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        u++;
                    }
                }
                brojevi[i] = u;

            }

            Console.WriteLine(string.Join(",", brojevi));

            //da bi znakovi veći od 9 bili pretvoreni u drugu znamenku dvoznamenkastog broja
            // prebacujemo u string pa onda u broj.
            brojevi = srediNiz(brojevi);

            Console.WriteLine(string.Join(",", brojevi));

            // poziva metodu ljubav
            Console.WriteLine("{0} i {1} se vole {2}%", ime1, ime2, ljubav(brojevi));
            Console.WriteLine("==================================");
        Ponovi:
            Console.WriteLine("Želite li ponoviti unos imena? Odgovorite sa \"da\" ili \"ne\"");
            string odgovor = Console.ReadLine();
            if (odgovor == "da")
            {
                goto Pocetak;
            }
            else if (odgovor == "ne")
            {
                Console.WriteLine("Hvala na korištenju aplikacije! Goodbye!");
            }
            else
            {
                Console.WriteLine("Netočan unos. Odgovorite sa \"da\" ili \"ne\"");
                goto Ponovi;
            }



        }



        private int ljubav(int[] brojevi)
        {
            if (brojevi.Length < 4)
            {
                var broj = int.Parse(string.Join("", brojevi));
                if (broj <= 100)
                {
                    return broj;
                }
            }

            int noviDuzina = brojevi.Length / 2 + (brojevi.Length % 2);
            int[] novi = new int[noviDuzina];
            int index = 0;

            for (int i = 0; i < brojevi.Length - 1; i += 2)
            {
                novi[index] = brojevi[i] + brojevi[i + 1];
                index++;
            }

            if (brojevi.Length % 2 != 0)
            {
                novi[index] = brojevi[^1];
            }

            // Ispisujemo samo ako se niz promijenio
            int[] noviSredjeni = srediNiz(novi);
            if (!Enumerable.SequenceEqual(brojevi, noviSredjeni))
            {
                Console.WriteLine(string.Join(",", noviSredjeni));
            }

            return ljubav(noviSredjeni);
        }


        //da bi znakovi veći od 9 bili pretvoreni u drugu znamenku dvoznamenkastog broja
        // prebacuje se u string pa onda u broj
        private int[] srediNiz(int[] brojevi)
        {
            var niz = string.Join("", brojevi);
            brojevi = new int[niz.Length];
            for (int i = 0; i < niz.Length; i++)
            {
                brojevi[i] = int.Parse(niz[i].ToString());
            }
            return brojevi;

        }

        private void pozdravna()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*** Ovo je Ljubavni kalkulator ***");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("Program na jedinstven način \"računa\" koliko se 2 osobe vole.");
            Console.WriteLine("Ako ste spremni, unesite imena:");
        }


    }
}
