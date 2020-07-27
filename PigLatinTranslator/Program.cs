using System;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!\n");
            string repeat = "y";

            while (repeat == "y" || repeat == "Y")
            {
                Console.WriteLine("Please enter a word or sentence to translate into Pig Latin:");
                string input = Console.ReadLine();
                string[] words = input.ToLower().Split(' ');
                string firstletter,
                       remainder,
                       vowels = "aeiou";

                StringBuilder Piglatin = new StringBuilder();
                int vowelchecker;

                foreach (string word in words)
                {
                    firstletter = word.Substring(0, 1);
                    remainder = word.Substring(1, word.Length - 1);
                    vowelchecker = vowels.IndexOf(firstletter);

                    if (vowelchecker == -1)
                    {
                        string output = remainder + firstletter + "ay";
                        Piglatin.Append(output + " ");
                    }
                    else
                    {
                        string output = word + "way";
                        Piglatin.Append(output + " ");
                    }
                }
                Console.WriteLine(Piglatin);
                Console.WriteLine("Translate another line? (y/n)");
                repeat = Console.ReadLine();

                //Couldn't find a way to repeat the program only at "Translate another line?" 
                //when an input for repeat wasn't "y" or "n"
                //Please advise if you can.
                if (repeat != "y" && repeat != "Y" && repeat != "n" && repeat != "N")
                {
                    Console.WriteLine("Please enter a valid response.");
                    continue;
                }
            }
            Console.WriteLine("Thank you for using the Pig Latin Translator!");
        }
    }
}
