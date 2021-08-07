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
            // Lists dynamically grow
            List<int> myFirstList = new List<int>();

            myFirstList.Add(10);
            myFirstList.Add(5);

            List<int> list = new List<int>() { 10, 5 };
            
            Console.WriteLine(myFirstList[0]); // 10
            Console.WriteLine(myFirstList[1]); // 5

            // 10 is the initial capacity
            int[] myFirstArray = new int[5];
            myFirstArray[0] = 7;
            myFirstArray[1] = 8;
            myFirstArray[2] = 4;
            myFirstArray[3] = 5;
            myFirstArray[4] = 15;

            // More concise way
            int[] myArray = { 7, 8, 4, 5, 15 };

            Array.Sort(myArray);
        }
    }
}
*/