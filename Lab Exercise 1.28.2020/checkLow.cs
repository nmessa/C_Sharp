//Lab Exercise 1.28.2020 Problem 1
//Author:nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double hourlyRate;
            string userInput;

            //Get hourly rate from user and convert to double
            Console.Write("Enter the hourly rate: ");
            userInput = Console.ReadLine();
            hourlyRate = Convert.ToDouble(userInput);

            //Determine if pay rate is too low
            if (hourlyRate < 7.5)
                Console.WriteLine("Your pay is too low");
        }
    }
}

//Sample output
//Enter the hourly rate: 4.35
//Your pay is too low
