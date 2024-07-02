﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS
{
    internal class CiklicnaTablica
    {
        internal static void Izvedi()
        {
            Console.WriteLine("Unesite broj redova: ");
            int red = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj kolona: ");
            int kolona = int.Parse(Console.ReadLine());
            //int red = 11;
            //int kolona = 13;
            int[,] tablica = new int[red, kolona]; // dvodimenzionalni niz

            int redMax = red - 1;
            int redMin = 0;
            int kolonaMax = kolona - 1;
            int kolonaMin = 0;
            int broj = 1;

            while (broj <= red * kolona)
            {
                // smanjuje kolonu max i zadržava red max
                for (int i = kolonaMax; i >= kolonaMin; i--)
                {
                    if (tablica[redMax, i] == 0)
                    {
                        tablica[redMax, i] = broj++;
                    }
                    else
                    {
                        break;
                    }
                }
                // Smanjuje red max zbog preklapanja
                redMax--;
                // Smanjuje red max i zadržava kolonu min
                for (int i = redMax; i >= redMin; i--)
                {
                    if (tablica[i, kolonaMin] == 0)
                    {
                        tablica[i, kolonaMin] = broj++;
                    }
                    else
                    {
                        break;
                    }
                }
                // Povećava kolonu min zbog preklapanja
                kolonaMin++;
                // Povećava kolonu min i zadržava red min
                for (int i = kolonaMin; i <= kolonaMax; i++)
                {
                    if (tablica[redMin, i] == 0)
                    {
                        tablica[redMin, i] = broj++;
                    }
                    else
                    {
                        break;
                    }
                }
                // Povećava red min zbog preklapanja
                redMin++;
                // Povećava min red i zadržava kolonu max
                for (int i = redMin; i <= redMax; i++)
                {
                    if (tablica[i, kolonaMax] == 0)
                    {
                        tablica[i, kolonaMax] = broj++;
                    }
                    else
                    {
                        break;
                    }
                }
                // Smanjuje kolonu max zbog preklapanja
                kolonaMax--;
            }
            for (int i = 0; i < red; i++)
            {
                for (int j = 0; j < kolona; j++)
                {
                    Console.Write("\t" + tablica[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}

