using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {


        internal static void Izvedi()
        {
            
            // ispiši 10 puta osijek

            // i++
            // ++i
             //  i +=1
              //  i=i+1

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Osijek");
            }

            int suma = 0;
            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            // ispiši sve parne brojeve od 3 do 29

            //loše rješenje

            // for (int i = 4)

            // bolje rješenje


            // najbolje rješenje

            //    int brojOd = 3; // korisnik unosi
            //int brojDo = 29; // korisnik unosi
            //for (int i = brojOd; i = brojDo; i ++)

            Console.WriteLine("*************************************");

            int[] niz = { 2, 3, 4, 5, 6, 7, 78, 5, 4, 3, 2 };
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);

            }


            Console.WriteLine("*************************************");



            for (int i = 20; i >= 10; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************************");

            // ispiši sve prim brojeve od 2 do 50


            bool prim;

            for (int i = 2; i <= 14; i++)
            {
                prim = true;
                for (int j = 2; j < i; j++) 
                
                {
                  //  Console.WriteLine("{0}%{1}={2}",i,j,i%j);
                    if(i%j == 0)
                    {
                        prim = false;
                    }
                }
                if (prim)
                {
                    Console.WriteLine(i);

                }
                       
                        


            }


            Console.WriteLine("*************************************");


            // preskakanje petlje

            for(int i = 0;i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                if(i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 0;i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(i*j);
                    goto labela;
                }

                
            }

        labela:
            Console.WriteLine("=============");



            // beskonačna petlja
            // Unesi broj između 1 i 10


            Console.WriteLine( int.MaxValue);
            int max = int.MaxValue;
            Console.WriteLine(max+1);

            int broj;

            //OVO NIJE BESKONAČNA PETLJA

            //for (int i = 0; i > -1; i++) 
            
            //{ 
            
            //}

            //for ( ; ; )
            //{
            //    Console.WriteLine("Unesi broj od 1 do 10");
            //    broj = int.Parse(Console.ReadLine());    
            //    if (broj<1 || broj > 10)
            //    {
            //        Console.WriteLine("Nisi uni broj u rasponu");
            //        continue;
            //    }
            //    break;
            //}
            //Console.WriteLine(broj);



            niz = PodaciInt.niz;

            Console.WriteLine(niz.Length);

            //for(int i = 0; i < niz.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}


            for (int i = 0; i < niz.Length; i++)
            {
               if (i % 10000 == 0)  { Console.WriteLine("*"); }
                for (int j = 0; j < niz.Length; j++)
                {
                    if (niz[i] == niz[j])
                    {
                        Console.WriteLine(niz[i]);
                        goto kraj;




                    }
                }
            }

        kraj:
            Console.WriteLine("**************************");


            string[] imena = PodaciString.Niz;
            Console.WriteLine(imena.Length);

            string grad = "Osijek";

            Console.WriteLine(grad[0]);
            Console.WriteLine(grad[grad.Length-1]);



        }
    }
}
