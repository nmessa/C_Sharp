//Lab Exercise 1.27.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int test1, test2, test3, test4, test5;
            double average;
            string userInput, aveString;

            //Get input from user
            Console.Write("Enter score for test 1: ");
            userInput = Console.ReadLine();
            test1 = Convert.ToInt32(userInput);
            Console.Write("Enter score for test 2: ");
            userInput = Console.ReadLine();
            test2 = Convert.ToInt32(userInput);
            Console.Write("Enter score for test 3: ");
            userInput = Console.ReadLine();
            test3 = Convert.ToInt32(userInput);
            Console.Write("Enter score for test 4: ");
            userInput = Console.ReadLine();
            test4 = Convert.ToInt32(userInput);
            Console.Write("Enter score for test 5: ");
            userInput = Console.ReadLine();
            test5 = Convert.ToInt32(userInput);

            //Calculate average for 5 tests
            average = (test1 + test2 + test3 + test4 + test5) / 5.0;
            aveString = average.ToString("F2");
            Console.WriteLine("Your test average is {0}", aveString);
        }
    }
}

//Sample Output
//Enter score for test 1: 92
//Enter score for test 2: 85
//Enter score for test 3: 78
//Enter score for test 4: 83
//Enter score for test 5: 91
//Your test average is 85.80