/* 
using System;
using System.IO;

namespace WordUnscrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is the first line", "Second line", "Third" };
            File.WriteAllLines("MyFirstFile.txt", lines);
            string[] fileContents = File.ReadAllLines("MyFirstFile.txt");

            foreach (string line in File.ReadLines("MyFirstFile.txt"))
            {
                Console.WriteLine(line);
            }
        }
    }
}
*/
