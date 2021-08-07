using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteScrambledWordsFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteScrambledWordsManualEntryScenario();
                        break;
                    default:
                        Console.WriteLine("Command not recognized.");
                        break;
                }

                var continueWordUnscrambleDecision = string.Empty;
                do
                {
                    Console.Write("Do you want to continue? Y/N: ");
                    continueWordUnscrambleDecision = (Console.ReadLine() ?? string.Empty);
                } while (!continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueWordUnscrambleDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);
            
            } while (continueWordUnscramble);

        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
        }

        private static void ExecuteScrambledWordsFileScenario()
        {
        }
    }

}