using System;
using System.Text.RegularExpressions;

namespace RegexConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text to clean:");
            string inputText = Console.ReadLine();

            string cleanedText = CleanText(inputText);

            Console.WriteLine("\nCleaned Text:");
            Console.WriteLine(cleanedText);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static string CleanText(string text)
        {
            // Remove emojis
            string cleanedText = Regex.Replace(text, @"\p{Cs}", "");

            // Remove non-English characters and punctuation
            cleanedText = Regex.Replace(cleanedText, @"[^\w\s]", "");

            return cleanedText;
        }
    }
}
