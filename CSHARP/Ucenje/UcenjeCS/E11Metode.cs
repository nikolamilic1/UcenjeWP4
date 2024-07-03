using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Metode
    {
        public static void Izvedi()
        {
            //poziv metode Tip1()
            //Tip1();
            //Tip1();


            //for (int i = 0; i < 55; i++)
            //{
            //    Tip1();
            //}

            //Tip2("Edunova");
            //Console.WriteLine("Unesi ime:");
            //Tip2(Console.ReadLine());
            //Tip2("Pero","Perić");
            //int broj = Tip3();
            //Console.WriteLine(broj);

            //Tip4(1,99);
            Console.WriteLine(Tip4(2,8));

            //int doBroja = Pomocno.UcitajCijeliBroj("Unesi do broja");
            //int odBroja = Pomocno.UcitajCijeliBroj("Unesi od broja");
            //for (int i = odBroja;
            //i < doBroja; i++) ;

        }

        // Tip 1. metoda ne prima parametre i ne vraća vrijednost
        // Ovdje je deklarirana, napisana
        // PRIVATE se vidi samo u trenutnoj klasi
        //private static void Tip1()
        //{
        //    Console.WriteLine("Hello iz metode koja ne prima parametre i ne vraća vrijednost");
        //    Console.WriteLine("Drugi red");
        //    Console.WriteLine("Treći red");
        //}

        // Tip 2. metoda prima parametre i ne vraća vrijednost
        // kada ispred [static] void nema načina pristupa tada je: private
        //static void Tip2(string ime)
        //{
        //    Console.WriteLine("Hello {0}", ime);
        //}

        // Potpis metode: naziv + lista parametara
        // method signature
        // method overloading
        // METOD OVERLOADING  ---ime metode može biti isto ali lista parametara mora biti različita
        // Primjer:
        //static void Tip2(string ime, string prezime)
        //{
        //    Console.WriteLine("Hello {0} {1}", ime, prezime);
        //}

        // Tip 3. Metoda ne prima parametre i vraća vrijednost

        //static int Tip3()
        //{

        //    return new Random().Next(10, 30);


        //    return 0;  // <- ovo je dobro staviti da ne pokazuje sintaksnu grešku
        //               //  return '7';  // return vraća vrijednost onome tko je pozvao metodu
        //               // vraća prema ASCII tablici, pogledati: https://commons.wikimedia.org/wiki/File:ASCII-Table-wide.svg
        //}


        // 4. najbitniji ----  metoda prima parametre  i vraća vrijednost


        /// <summary>
        /// Metoda za dva primljena cijela broja  vraća zbroj svih zbrojeva između njih
        /// </summary>
        /// <param name="odBroja">Broj od kojeg se kreće uključujući taj broj</param>
        /// <param name="doBroja">Broj do kojeg se kreće uključujući taj broj</param>
        /// <returns>Zbroj brojeva između dva primljena broja</returns>       
        protected static int Tip4(int odBroja, int doBroja)
        {

            int Suma = 0;

            for (int i = odBroja; i <= doBroja; i++)
            {
                // return 0; // ovo stavimo da ne javlja grešku
                // throw new NotImplementedException();  // <--- a može i ovako
                Suma += i;
            }

            return Suma;


        }


        // primjer metode sa više return izraza

        //static bool primBroj(int broj)
        //{
        //    for(int i = 2;  i < broj; i++)
        //    {
        //        if(broj % i == 0)
        //        {
        //            return false;
        //        }
        //        return true;
        //    }
        //}










    }
}


