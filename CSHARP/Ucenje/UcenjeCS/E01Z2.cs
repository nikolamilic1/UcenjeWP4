﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01Z2
    {

        public static void Izvedi()
        {
            int broj;
            
            Console.WriteLine("Unesi dvoznamenkasti broj: ");
            broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Prva znamenka toga broja je: " + (broj / 10));
            Console.WriteLine("Druga znamenka toga broja je: " + (broj % 10));

            //int prviBroj;
            //Console.WriteLine("Unesi cijeli broj: ");
            //prviBroj = int.Parse(Console.ReadLine());

            //int drugiBroj;
            //Console.WriteLine("Unesi još jedan cijeli broj: ");
            //drugiBroj = int.Parse(Console.ReadLine());

            //Console.WriteLine("Njihov zbroj je: " + (prviBroj + drugiBroj));


            decimal prvibroj;
            Console.WriteLine("Unesi decimalni broj");
            prvibroj = decimal.Parse(Console.ReadLine());

            decimal drugibroj;
            Console.WriteLine("Unesi drugi decimalni broj");
            drugibroj = decimal.Parse(Console.ReadLine());

            if (drugibroj == drugibroj)
            {
                Console.WriteLine("Jednaki su brojevi");
            }
            else
            {
                if (drugibroj > prvibroj)
                {
                    Console.WriteLine(drugibroj);
                }
                else {
                    Console.WriteLine(prvibroj);
                }

            }

        }



    }
}
