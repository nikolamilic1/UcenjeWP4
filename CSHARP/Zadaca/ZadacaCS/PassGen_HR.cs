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
            Console.WriteLine("*** Dobrodošli u Generator zaporki app. v 1.0 ***");
            Console.WriteLine("*************************************************");
            // Exiting console app message
            Console.WriteLine("Odaberite (Ctrl+C) za izlazak iz programa");


            Console.WriteLine("Unesite dužinu zaporke:");
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
                Console.WriteLine("Počni sa brojem (DA/NE):");
                startWithNumber = Convert.ToBoolean(Console.ReadLine());
            }
            // esure case if user chose "false" for punctuation
            if (punctuation == false)
            {
                endWithPunctuation = false;
            }
            else
            {
                Console.WriteLine("Završi sa dijakritčkim znakom (DA/NE):");
                endWithPunctuation = Convert.ToBoolean(Console.ReadLine());
            }
            Console.WriteLine("Znakovi se ne ponavljaju (DA/NE):");
            noRepeatingChars = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Odaberite broj zaporki za generiranje:");
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
                Console.WriteLine("Upozornje: Tražena zaporka ima prevelik broj znameniki i ne može se generirati jer ste odabrali opciju \"Znakovi se ne ponavljaju\".");

                // Prompt user for their choice
                Console.WriteLine("Što želite uraditi? Odaberite opciju (1 ili 2):");
                Console.WriteLine("1. Promijeniti postavke na način da dozvolite ponavljanje znakova ili smanjiti dužinu zaporke.");
                Console.WriteLine("2. Program će automatski promijeniti dužinu zaporke i zadovoljiti ostale odabrane parametre");

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
                        Console.WriteLine("Duljina zaporka je automatski podešena kako bi ostali parametri bili zadovoljeni.");
                        break;

                    default:
                        Console.WriteLine("Pogreška odabira. Molimo pokušajte ponovo.");
                        break;
                }
            }
            return password.ToString();
        }

    }
}
