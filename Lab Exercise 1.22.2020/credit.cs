//Lab Exercise 1.22.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Credit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            const double MAX_CREDIT = 1000;
            double purchase, credit;
            string userInput;

            //Get amount of purchase from user
            Console.Write("Enter the amount of purchase: ");
            userInput = Console.ReadLine();
            purchase = Convert.ToDouble(userInput);

            //Calculate credit remaining
            credit = MAX_CREDIT - purchase;
            Console.WriteLine("Credit balance = {0}", credit.ToString("c"));
        }
    }
}

//Sample Output
//Enter the amount of purchase: 29.95
//Credit balance = $970.05