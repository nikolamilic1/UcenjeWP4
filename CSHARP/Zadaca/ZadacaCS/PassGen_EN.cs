using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ZadacaCS
{
    public class PassGen_EN
    {
        internal static void Password()
        {
          
            Console.WriteLine("************************************************");
            Console.WriteLine("*** Welcome to Password Generator app. v 1.0 ***");
            Console.WriteLine("************************************************");
            // Exiting console app message
            Console.WriteLine("Press (Ctrl+C) for terminating the application in any time");
                 
           
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

            // Prompt the user for each option
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
            // Handle ending with punctuation
            if (endWithPunctuation && punctuation)
            {
                char endingPunctuationMark = filteredChars.FirstOrDefault(c => !Char.IsLetterOrDigit(c));
                if (endingPunctuationMark != '\0') // Ensure we found a punctuation mark
                {
                    password.Append(endingPunctuationMark);
                }
            }
            // Check if the generated password meets the desired length
            if (password.Length < length)
            {
                // Display warning message
                Console.WriteLine("Warning: The requested password length cannot be achieved with the current settings without repeating characters.");

                // Prompt user for their choice
                Console.WriteLine("Would you like to:");
                Console.WriteLine("1. Adjust your settings to allow for character repetition or reduce the desired password length.");
                Console.WriteLine("2. Automatically adjust the password length to match the generated password length.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Option 1: Prompt user to adjust settings
                        Console.WriteLine("Please adjust your settings to allow for character repetition or reduce the desired password length.");
                        break;

                    case "2":
                        // Option 2: Automatically adjust settings (example: reduce password length)
                        // Note: This is a simplistic approach and may not always be desirable
                        length = Math.Min(length, password.Length);
                        Console.WriteLine("The password length has been automatically adjusted to match the generated password length.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            return password.ToString();
        }
        static void Shuffle<T>(List<T> list, Random rng)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;

            }

        }
    }

}