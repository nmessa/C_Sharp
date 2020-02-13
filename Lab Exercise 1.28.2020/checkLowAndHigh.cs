//Lab Exercise 1.28.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
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

            //Determine if rate is too high, too low, or just right
            if (hourlyRate < 7.5)
                Console.WriteLine("Your pay is too low");
            else if (hourlyRate > 49.99)
                Console.WriteLine("Your pay is too high");
            else
                Console.WriteLine("Your pay is OK");
        }
    }
}

//Output
//Enter the hourly rate: 12.34
//Your pay is OK
