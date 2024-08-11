using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS.EvidencijaRadaKonzolna
{
    internal class Pomocno
    {

       public static bool DEV=false;

        internal static bool UcitajBool(string poruka, string trueValue)
        {
            Console.WriteLine(poruka + ": ");
            return Console.ReadLine().Trim().ToLower() == trueValue;
        }
        internal static DateTime UcitajDatum(string poruka, bool kontrolaPrijeDanasnjegDatuma)
        {
            DateTime d;
            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-mm-dd, za današnji datum {0}", DateTime.Now.ToString("yyyy-MM-dd"));
                    if (kontrolaPrijeDanasnjegDatuma)
                    {
                        Console.WriteLine("Uneseni datum ne smije biti prije današnjeg datuma!");
                    }
                    
                    Console.WriteLine(poruka + ": ");
                    d = DateTime.Parse(Console.ReadLine());
                    if (kontrolaPrijeDanasnjegDatuma && d < DateTime.Now)
                    {
                        throw new Exception();
                    }
                    return d;
                }
                catch
                {
                    Console.WriteLine("Unos datuma nije dobar");
                }
            }





        }

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
        internal static string UcitajString(string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();             
                if (obavezno && s.Length==0 || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan! Maksimalno dozvoljeno {0} znakova", max);
                    continue;   // ovo znači da neće vratiti nazad već će tražiti ponovni unos
                }
                return s;
            }
        }

        internal static string UcitajString(string stara, string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.Write(poruka + " (" + stara + "): ");
                s = Console.ReadLine().Trim();
                if (s.Length == 0)
                {
                    return stara;
                }
                if (obavezno && s.Length == 0 || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan! Maksimalno dozvoljeno {0} znakova", max);
                    continue;   // ovo znači da neće vratiti nazad već će tražiti ponovni unos
                }
                return s;
            }
        }
    }
}
