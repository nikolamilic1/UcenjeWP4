using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {

            //int = 0;

            //switch (i)
            //{
            //    case 0:
            //        Console.WriteLine("Dobar");
            //        break;
            // case 1:

            // default:

            //}

            Console.WriteLine("Unesite ocjenu od 1 do 5");
            var godine = int.Parse(Console.ReadLine());

            switch (godine)
            {

                case 1:
                    Console.WriteLine("Ocjena je nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Ocjena je dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Ocjena je dobar");
                    break;
                case 4:
                    Console.WriteLine("Ocjena je vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Ocjena je odličan");
                    break;
                default:
                    Console.WriteLine("pogrešan unos. Unesite ocjenu od 1 do 5");
                    break;



            }

        }
    }
}
