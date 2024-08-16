using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadacaCS
{
    internal class PassGen_HR
    {
        internal static void Password()
        {

            Console.WriteLine("*************************************************");
            Console.WriteLine("*** Dobrodošli u Generator lozinki app. v 1.0 ***");
            Console.WriteLine("*************************************************");
            // Exiting console app message
            Console.WriteLine("Odaberite (Ctrl+C) za izlazak iz programa");


            Console.WriteLine("Unesite dužinu lozinke:");
            int length = Convert.ToInt32(Console.ReadLine());

            bool caps = true; // Assuming caps are on by default
            bool lowerCase = true;
            bool numbers = true;
            bool punctuation = true;
            bool startWithNumber = false;
            bool endWithPunctuation = false;
            bool noRepeatingChars = true;
            int numberOfPasswords = 1;

            // Prompt the user for each option
            Console.WriteLine("Velika slova uključeno/isključeno (DA/NE):");
            caps = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Mala slova uključeno/isključeno (DA/NE):");
            lowerCase = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Brojevi uključeno/isključeno (DA/NE):");
            numbers = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Dijakritički znakovi uključeno/isključeno (DA/NE):");
            punctuation = Convert.ToBoolean(Console.ReadLine());
            // esure case if user chose "false" for numbers
            if (numbers == false)
            {
                startWithNumber = false;
            }
            else
            {
                Console.WriteLine("Start with a number (true/false):");
                startWithNumber = Convert.ToBoolean(Console.ReadLine());
            }
            // esure case if user chose "false" for punctuation
            if (punctuation == false)
            {
                endWithPunctuation = false;
            }
            else
            {
                Console.WriteLine("End with a punctuation mark (true/false):");
                endWithPunctuation = Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine("No repeating characters (true/false):");
            noRepeatingChars = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Number of passwords to generate:");
            numberOfPasswords = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+<>?";
            List<string> passwords = new List<string>();

            for (int i = 0; i < numberOfPasswords; i++)
            {
                string password = GeneratePassword(length, caps, lowerCase, numbers, punctuation, startWithNumber, endWithPunctuation, noRepeatingChars, chars.ToCharArray(), rand);
                passwords.Add(password);
            }
            foreach (var password in passwords)
            {
                Console.WriteLine($"Generated Password: {password}");
            }


        }

    }
}
