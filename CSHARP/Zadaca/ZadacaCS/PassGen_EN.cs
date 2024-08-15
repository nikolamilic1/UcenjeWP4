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

            bool caps = true; // Assuming caps are on by default
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

        static string GeneratePassword(int length, bool caps, bool lowerCase, bool numbers, bool punctuation, bool startWithNumber, bool endWithPunctuation, bool noRepeatingChars, char[] chars, Random rand)
        {
            StringBuilder password = new StringBuilder();

            // Filter characters based on flags
            var filteredChars = new List<char>();
            foreach (char c in chars)
            {
                if ((Char.IsUpper(c) && caps) || (Char.IsLower(c) && lowerCase) || (Char.IsDigit(c) && numbers) || (!Char.IsLetterOrDigit(c) && punctuation))
                {
                    filteredChars.Add(c);
                }
            }
            // Shuffle the filtered character set if no repeating characters are allowed
            if (noRepeatingChars)
            {
                Shuffle(filteredChars, rand);
            }
            // Handle starting with a number
            if (startWithNumber)
            {
                password.Append(rand.Next(0, 10));
            }
            // Generate the rest of the password
            int remainingLength = length - password.Length - (endWithPunctuation ? 1 : 0); // Adjust for ending punctuation if needed
            for (int i = 0; i < remainingLength && i < filteredChars.Count; i++) // Ensure we don't exceed the bounds of filteredChars
            {
                char nextChar = filteredChars[i]; // Take characters sequentially from shuffled list
                password.Append(nextChar);
            }

        }
    }
}