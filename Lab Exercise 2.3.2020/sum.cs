//Lab Exercise 2.3.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int number, total=0;
            string userInput;

            //Prime the while loop
            Console.Write("Enter an integer (999 to quit): ");
            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            //Keep looping until 999 entered
            while (number != 999)
            {
                //Add number to total
                total += number;

                //Get another number
                Console.Write("Enter an integer (999 to quit): ");
                userInput = Console.ReadLine();
                number = Convert.ToInt32(userInput);
            }
            Console.WriteLine(total);
        }
    }
}

//Sample Output
//Enter an integer (999 to quit): 123
//Enter an integer (999 to quit): 456
//Enter an integer (999 to quit): 999
//579