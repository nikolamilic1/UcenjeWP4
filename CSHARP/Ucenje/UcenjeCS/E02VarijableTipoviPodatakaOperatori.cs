﻿

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {
        public static void Izvedi()
        {
            int broj;

            broj = 7;

            Console.WriteLine("Unesi broj: ");

                broj = int.Parse(Console.ReadLine());
            Console.WriteLine(broj + 1);

            Console.WriteLine("Unesi decimalni broj: ");
            decimal db = decimal.Parse(Console.ReadLine());

            Console.WriteLine(db / 10);

            Console.WriteLine(decimal.Parse(Console.ReadLine()));

            // modulo: Ostatak nakon cjelobrojnog djeljenja

            int modulo = 4 % 2;
            Console.WriteLine(modulo);

            int i = 5;
            int j = 3; 
            Console.WriteLine(i / (float)j);  // (float) je cast

            bool logickaVrijednost = true;   // to je SQLu bit

            // Operatori:


            Console.WriteLine(i==j);

            int k=5, l=j;

            var ime = "Edunova";

            int b = 0;

            b = b + 1;  // 1
            b += 1;     // 2
            b++;        // 3
            ++b;

            Console.WriteLine(++b);
            Console.WriteLine(b++);
            Console.WriteLine(b);


        }


    }
}
