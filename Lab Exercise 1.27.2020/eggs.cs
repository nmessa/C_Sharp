//Lab Exercise 1.27.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varaibles
            int eggs1, eggs2, eggs3, eggs4, total, eggs, dozen;
            string userInput;

            //Get user input
            Console.Write("Enter the number of eggs from chicken 1: ");
            userInput = Console.ReadLine();
            eggs1 = Convert.ToInt32(userInput);
            Console.Write("Enter the number of eggs from chicken 2: ");
            userInput = Console.ReadLine();
            eggs2 = Convert.ToInt32(userInput);
            Console.Write("Enter the number of eggs from chicken 3: ");
            userInput = Console.ReadLine();
            eggs3 = Convert.ToInt32(userInput);
            Console.Write("Enter the number of eggs from chicken 4: ");
            userInput = Console.ReadLine();
            eggs4 = Convert.ToInt32(userInput);

            //Calculate total number of eggs produced
            total = eggs1 + eggs2 + eggs3 + eggs4;

            //Calculate number of dozen and leftovers
            dozen = total / 12;
            eggs = total % 12;

            //Output the result
            Console.WriteLine("A total of {0} eggs is {1} dozen and {2} eggs.", total,
                dozen, eggs);
        }
    }
}

//Sample Output
//Enter the number of eggs from chicken 1: 123
//Enter the number of eggs from chicken 2: 234
//Enter the number of eggs from chicken 3: 345
//Enter the number of eggs from chicken 4: 456
//A total of 1158 eggs is 96 dozen and 6 eggs.
