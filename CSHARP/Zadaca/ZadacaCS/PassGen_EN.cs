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
            


            Console.WriteLine("Enter password length:");
            int length = Convert.ToInt32(Console.ReadLine());

            bool caps = true;
            bool lowerCase = true;
            bool numbers = true;
            bool punctuation = true;
            bool startWithNumber = false;
            bool endWithNumber = false;
            bool startWithPunctuation = false;
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
            if (numbers == false)
            {
                startWithNumber = false;
                endWithNumber = false;
            }
            else
            {
                Console.WriteLine("Start with a number (true/false):");
                startWithNumber = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("End with a number (true/false):");
                endWithNumber = Convert.ToBoolean(Console.ReadLine());
            }
            if (punctuation == false)
            {
                startWithPunctuation = false;
                endWithPunctuation = false;
            }
            else
            {
                Console.WriteLine("Start with a punctuation mark (true/false):");
                startWithPunctuation = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("End with a punctuation mark (true/false):");
                endWithPunctuation = Convert.ToBoolean(Console.ReadLine());
                if (startWithNumber == true && startWithPunctuation == true)
                {
                    Console.WriteLine("NOTE: \"Start With Number\" is replaced with \"Start With Punctuation\"");
                }
                if (endWithNumber == true && endWithPunctuation == true)

                {
                    Console.WriteLine("NOTE: \"End With Number\" is replaced with \"End With Punctuation\"");
                }
            }
        RepeatingChar:
            Console.WriteLine("No repeating characters (true/false):");
            noRepeatingChars = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Number of passwords to generate:");
            numberOfPasswords = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+<>?";

            // Provjera duljine prije generiranja lozinki
            int testLength = length;
            string testPassword = GeneratePassword(testLength, caps, lowerCase, numbers, punctuation, startWithNumber, endWithNumber, startWithPunctuation, endWithPunctuation, noRepeatingChars, chars.ToCharArray(), rand);

            if (testPassword.Length < length)
            {
                Console.WriteLine("Warning: The requested password length cannot be achieved with the current settings without repeating characters.");

                Console.WriteLine("Would you like to:");
                Console.WriteLine("1. Adjust your settings to allow for character repetition or reduce the desired password length.");
                Console.WriteLine("2. Automatically adjust the password length to match the generated password length.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Please adjust your settings to allow for character repetition or reduce the desired password length.");
                        goto RepeatingChar;
                        break;  // Izađi iz programa dok se postavke ne promijene
                    case "2":
                        length = Math.Min(length, testPassword.Length);
                        Console.WriteLine("The password length has been automatically adjusted to match the generated password length.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        return;  // Izađi iz programa zbog nevažećeg izbora
                }
            }

            List<string> passwords = new List<string>();

            for (int i = 0; i < numberOfPasswords; i++)
            {
                string password = GeneratePassword(length, caps, lowerCase, numbers, punctuation, startWithNumber, endWithNumber, startWithPunctuation, endWithPunctuation, noRepeatingChars, chars.ToCharArray(), rand);
                passwords.Add(password);
            }

            foreach (var password in passwords)
            {
                Console.WriteLine($"Generated Password: {password}");
            }
        }

        static string GeneratePassword(int length, bool caps, bool lowerCase, bool numbers, bool punctuation, bool startWithNumber, bool endWithNumber, bool startWithPunctuation, bool endWithPunctuation, bool noRepeatingChars, char[] chars, Random rand)
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

            // Shuffle the filtered character set if noRepeatingChars is true
            if (noRepeatingChars)
            {
                Shuffle(filteredChars, rand);
            }

            // Handle starting with a number
            if (startWithNumber)
            {
                password.Append(rand.Next(0, 10));
            }

            // Handle starting with punctuation
            if (startWithPunctuation && punctuation)
            {
                char startPunctuationMark = filteredChars.FirstOrDefault(c => !Char.IsLetterOrDigit(c));
                if (startPunctuationMark != '\0')
                {
                    password.Append(startPunctuationMark);
                }
            }

            // Generate the rest of the password
            int remainingLength = length - password.Length - (endWithPunctuation ? 1 : 0);
            for (int i = 0; i < remainingLength && i < filteredChars.Count; i++)
            {
                char nextChar = filteredChars[i];
                password.Append(nextChar);
            }

            // Handle ending with a number
            if (endWithNumber)
            {
                password.Append(rand.Next(0, 10));
            }

            // Handle ending with punctuation
            if (endWithPunctuation && punctuation)
            {
                char endingPunctuationMark = filteredChars.FirstOrDefault(c => !Char.IsLetterOrDigit(c));
                if (endingPunctuationMark != '\0')
                {
                    password.Append(endingPunctuationMark);
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