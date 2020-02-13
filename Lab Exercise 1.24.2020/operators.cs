//Lab Exercise 1.24.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string userInput;
            double number1, number2, sum, difference, product, quotient;

            //Get user input
            Console.Write("Enter the first number: ");
            userInput = Console.ReadLine();
            number1 = Convert.ToDouble(userInput);
            Console.Write("Enter the second number: ");
            userInput = Console.ReadLine();
            number2 = Convert.ToDouble(userInput);

            //Make calculations
            sum = number1 + number2;
            difference = number1 - number2;
            product = number1 * number2;
            quotient = number1 / number2;

            //Output results
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, difference);
            Console.WriteLine("{0} x {1} = {2}", number1, number2, product);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, quotient);
        }
    }
}

//Output
//Enter the first number: 3.5
//Enter the second number: 2
//3.5 + 2 = 5.5
//3.5 - 2 = 1.5
//3.5 x 2 = 7
//3.5 / 2 = 1.75
