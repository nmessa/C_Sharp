//Lab Exercise 2.3.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRateLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double payrate;
            string userInput, strPayrate;

            //Get user input
            Console.Write("Enter a pay rate: ");
            userInput = Console.ReadLine();
            payrate = Convert.ToDouble(userInput);

            //Keep looping until valid pay rate is entered
            while (payrate < 5.65 || payrate > 49.99)
            {
                Console.Write("Invalid payrate Enter a valid pay rate: ");
                userInput = Console.ReadLine();
                payrate = Convert.ToDouble(userInput);
            }

            //Output the pay rate
            strPayrate = payrate.ToString("C");
            Console.WriteLine("Your payrate is {0}", strPayrate);
        }
    }
}
//Sample Output
//Enter a pay rate: 123
//Invalid payrate Enter a valid pay rate: 3
//Invalid payrate Enter a valid pay rate: 23.45
//Your payrate is $23.45