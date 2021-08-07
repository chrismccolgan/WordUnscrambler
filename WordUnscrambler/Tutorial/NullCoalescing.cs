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
            Person person = new Person("John", "Smith");

            Person newPerson = person ?? new Person("Default", "Person");

            Console.WriteLine(newPerson.FirstName); // John
        }
    }

    class Person
    {
        public Person(string argFirstName, string argLastName)
        {
            FirstName = argFirstName;
            LastName = argLastName;
        }
        public string FirstName { get; }
        public string LastName { get; }
    }

}
*/