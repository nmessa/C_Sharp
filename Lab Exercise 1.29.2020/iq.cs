//Lab Exercise 1.29.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int iq;
            string userInput;

            //Get IQ score from user and convert to 32 bit integer
            Console.Write("Enter your IQ: ");
            userInput = Console.ReadLine();
            iq = Convert.ToInt32(userInput);

            //Determine is score entered is valid and if it is, determine
            //if it is above average, average, or below average
            if (iq < 0 || iq > 200)
                Console.WriteLine("You have entered an invalid score");
            else if (iq > 100)
                Console.WriteLine("Above average");
            else if (iq < 100)
                Console.WriteLine("Below average");
            else
                Console.WriteLine("Average");
        }
    }
}
