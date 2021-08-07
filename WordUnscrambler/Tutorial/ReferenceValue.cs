/*
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
            // Value type
            int a = 10;
            ChangeNumber(a);
            Console.WriteLine(a); // 10

            ChangeNumberRef(ref a);
            Console.WriteLine(a); // 90, we forced ref behavior
            // Could have used 'out' instead of 'ref'
            // 'ref' paramaters need to be initialized, 'out' does not
            // 'out' needs to be assigned a value in method below, 'ref' does not

            // Reference type, classes are reference types
            Person person = new Person();
            person.FirstName = "John";
            person.LastName = "Smith";

            ChangeName(person);
            Console.WriteLine(person.FirstName); // Jane
            Console.WriteLine(person.LastName); // Doe
            // If class Person was a struct, would return John Smith
            // Structs are value types

        }

        static void ChangeNumber(int a)
        {
            a = 90;
        }

        static void ChangeNumberRef(ref int a)
        {
            a = 90;
        }

        static void ChangeName(Person personToChange)
        {
            personToChange.FirstName = "Jane";
            personToChange.LastName = "Doe";
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
*/