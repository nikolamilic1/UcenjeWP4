using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ZadacaCS
{
    internal class PassGen_EN
    {
        private static void Password(string[] args)
        {
            Console.WriteLine("Enter password length:");
            int length = Convert.ToInt32(Console.ReadLine());

            bool caps = true;
            bool lowerCase = true;
            bool numbers = true;
            bool punctuation = true;
            bool startWithNumber = false;
            bool endWithPunctuation = false;
            bool noRepeatingChars = true;
            int numberOfPasswords = 1;


            Console.WriteLine("Caps on/off (true/false):");
            caps = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Lower case on/off (true/false):");
            lowerCase = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Numbers on/off (true/false):");
            numbers = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Punctuation on/off (true/false):");
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

            // Prompt the user for each option
            Console.WriteLine("No repeating characters (true/false):");
            noRepeatingChars = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Number of passwords to generate:");
            numberOfPasswords = Convert.ToInt32(Console.ReadLine());

        }

    }
}