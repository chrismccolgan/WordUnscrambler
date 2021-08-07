namespace WordUnscrambler.Utils
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word(s) [M]anually or as a [F]ile?";
        public const string OptionsOnContinuing = "Would you like to continue? Y/N: ";

        public const string EnterScrambledWordsViaFile = "Enter full path including file name: ";
        public const string EnterScrambledWordsManually = "Enter word(s) manually (separated by commas if multiple): ";

        public const string ErrorOptionNotRecognized = "The option was not recognized.";
        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error: ";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated.";

        public const string MatchFound = "Match found for {0}: {1}";
        public const string MatchNotFound = "No matches found.";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordlist.txt";
    }
}
