using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.LjubavniKalkulator
{
    internal class Program
    {
        public void ljubav()
        {
            var ime1 = "Ivica";
            var ime2 = "Marica";

            string s = ime1[0].ToString();
            char c = ime1[0];

            Console.WriteLine(s);


            s = ime1.ToLower() + ime2.ToLower();
            Console.WriteLine(s);

            int[] brojevi = new int[s.Length];
            int u;
            //ivicamarica
            for (int i = 0; i < s.Length; i++)
            {
                /*
                u = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        u++;
                    }
                }
                brojevi[i] = u;
                */
                brojevi[i] = s.Count(znak => znak == s[i]);
            }
            Console.WriteLine(string.Join(",", brojevi));

            Console.WriteLine("{0} i {1} se vole {2} %", ime1, ime2, jubav(brojevi));
        }


        private int jubav(int[] brojevi)
        {
            var broj = int.Parse(string.Join(",", brojevi));
            if (broj <= 100)
            {
                return broj;
            }

            //algoritam zbrajanja
            return jubav(brojevi);

        }




    }
}
