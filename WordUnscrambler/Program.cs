using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using WordUnscrambler.Controllers;
using WordUnscrambler.Models;
using WordUnscrambler.Utils;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private const string wordListFileName = "wordlist.txt";
        static void Main(string[] args)
        {
            bool continueWordUnscramble;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name: ");
                        ExecuteFileScenario();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually: ");
                        ExecuteManualScenario();
                        break;
                    default:
                        Console.WriteLine("Command not recognized.");
                        break;
                }

                string continueInput;
                do
                {
                    Console.Write("Do you want to continue? Y/N: ");
                    continueInput = Console.ReadLine() ?? string.Empty;

                } while (
                    !continueInput.Equals("Y", StringComparison.OrdinalIgnoreCase) &&
                    !continueInput.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);

        }
        private static void ExecuteFileScenario()
        {
            var fileName = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = _fileReader.Read(fileName);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteManualScenario()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambledWords = manualInput.Split(", ");
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);

            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {
                    Console.WriteLine($"Match found for {matchedWord.ScrambledWord}: {matchedWord.Word}");
                }
            }
            else
            {
                Console.WriteLine("No matches found.");
            }
        }
    }

}