using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.LjubavniKalkulator
{
    internal class Program
    {

        public Program()
        {

            pozdravna();
            var ime1 = "bobo";
            var ime2 = "boba";
            //Console.Write("Unesite prvo ime:");
            //ime1 = Console.ReadLine();
            //Console.Write("Unesite drugo ime:");
            //ime2 = Console.ReadLine();
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
                return;
            }

            string s = ime1.ToLower() + ime2.ToLower();

            Console.WriteLine(s);

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

            int[] novi = new int[brojevi.Length % 2 == 0 ? brojevi.Length / 2 : brojevi.Length / 2 + 1];

            for (int i = 0; i < brojevi.Length / 2; i++)
            {
                novi[i] = brojevi[i] + brojevi[brojevi.Length - 1 - i];
            }
            if (brojevi.Length % 2 != 0)
            {
                novi[novi.Length - 1] = brojevi[brojevi.Length / 2];
            }
            novi = srediNiz(novi);
            Console.WriteLine(string.Join(",", novi));

            //algoritam zbrajanja
            return ljubav(novi);

        }

        //da bi znakovi veći od 9 bili pretvoreni u drugu znamenku dvoznamenkastog broja
        // prebacujemo u string pa onda u broj.
        private int[] srediNiz(int[] brojevi)
        { 
        
        }


            private void pozdravna()
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("*** Ovo je Ljubavni kalkulator ***");
                Console.WriteLine("**********************************");
                Console.WriteLine();
                Console.WriteLine("Program na jedinstven način \"računa\" koliko se 2 osobe vole.");
                Console.WriteLine("Ako ste spremni, unesite imena osoba");

            }
        }
    }
