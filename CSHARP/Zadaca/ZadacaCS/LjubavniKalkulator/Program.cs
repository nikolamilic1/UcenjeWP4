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
