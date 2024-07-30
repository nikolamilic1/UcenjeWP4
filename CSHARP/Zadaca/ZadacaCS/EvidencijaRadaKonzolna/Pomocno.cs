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
                    if(b<min || b>max)            // ako je b manje od minimalnog ili veći od maximalnog unosa
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
    }
}
