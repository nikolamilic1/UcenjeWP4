using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Pomocno
    {

        public static int UcitajCijeliBroj()
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Unesi cijeli broj ");
                    return int.Parse(Console.ReadLine());

                }
                catch // ne mora se staviti Exception
                {
                    Console.WriteLine("pogreška prilikom unosa");
                }
            }
            
            
        }


        public static int UcitajCijeliBroj(string poruka)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine(poruka + ": ");
                    return int.Parse(Console.ReadLine());

                }
                catch // ne mora se staviti Exception
                {
                    Console.WriteLine("pogreška prilikom unosa");
                }
            }


        }


    }
}
