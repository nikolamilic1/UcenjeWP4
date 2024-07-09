using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class Pomocno
    {
        internal static decimal? UcitajDecimalniBroj(string poruka, int min, float max)
        {
             float b;
            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    b = float.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                }
                catch {
            }
        }

        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {

            int b;
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;

                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }


            }







        }

        internal static int? UcitajString(string poruka, int max, bool obavezno)
        {
            string s;
            while (true)
            {
                Console.WriteLine(poruka);
                s = Console.ReadLine().Trim();
                if(obavezno && s.Length==0  || s.Length > max)
                {
                    Console.WriteLine("Unos obavezan. Maksimalno dozvoljeno {0} znakova", max);
                    continue;
                }
                return s;
            }
        }
    }
}
