using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class Pomocno
    {
        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int b;

            while (true) {
                try
                {
                    Console.Write(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    if(b<min || b>max)            // ako je b manji od minimalnog ili veći od maksimalnog unosa
                    {
                        throw new Exception();   // ovo baca u catch
                    }
                    return b;
                }
                catch 
                {
                    Console.WriteLine("Unos nije dobar. Unos mora biti u rasponu {0} do {1}",min,max);
                }
            }
            
        }
        /// <summary>
        /// Metoda vraća učitani string uz osigurače da mora biti veći od nula znakova i kraći od 50 znakova
        /// </summary>
        /// <param name="poruka"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static string UcitajString(string poruka, int max)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length==0 || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan! Maksimalno dozvoljeno {0} znakova", max);
                    continue;   // ovo znači da neće vratiti nazad već će tražiti ponovni unos
                }
                return s;
            }
        }
    }
}
