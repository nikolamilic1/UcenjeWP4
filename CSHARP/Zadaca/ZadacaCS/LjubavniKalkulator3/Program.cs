using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.LjubavniKalkulator3
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
            // Provjera ispravnog unosa znaka
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

            // Da bi znakovi veći od 9 bili pretvoreni u drugu znamenku dvoznamenkastog broja,
            // prebacujemo u string pa onda u broj.
            brojevi = srediNiz(brojevi);

            Console.WriteLine(string.Join(",", brojevi));

            // Poziva metodu ljubav
            Console.WriteLine("{0} i {1} se vole {2}%", ime1, ime2, Ljubav(brojevi));
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
            while (brojevi.Length > 4)
            {
                int[] novi = new int[brojevi.Length % 2 == 0 ? brojevi.Length / 2 : brojevi.Length / 2 + 1];

                for (int i = 0; i < brojevi.Length / 2; i++)
                {
                    novi[i] = brojevi[i] + brojevi[brojevi.Length - 1 - i];
                }

                if (brojevi.Length % 2 != 0)
                {
                    novi[novi.Length - 1] = brojevi[brojevi.Length / 2];
                }

                brojevi = srediNiz(novi);
                Console.WriteLine(string.Join(",", brojevi));
            }

            var rezultat = int.Parse(string.Join("", brojevi));
            return rezultat <= 100 ? rezultat : 100;
        }



        // Da bi znakovi veći od 9 bili pretvoreni u drugu znamenku dvoznamenkastog broja,
        // prebacuje se u string pa onda u broj.
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
