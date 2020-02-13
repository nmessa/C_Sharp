//Lab Exercise 2/10/2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int number, squareValue, cubeValue;
            string userInput;

            //Get an integer value from the user
            Console.Write("Enter an integer value: ");
            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            //Call function to calculate the square of a number
            squareValue = Square(number);

            //Call function to calculate the cube of a number
            cubeValue = Cube(number);

            //Output the results
            Console.WriteLine("{0} squared = {1}", number, squareValue);
            Console.WriteLine("{0} cubed = {1}", number, cubeValue);
        }

        //This fucntion is passed an integer and returns the square of that integer
        static int Square(int n)
        {
            return n * n;
        }

        //This fucntion is passed an integer and returns the cube of that integer
        //it also calls the Square function
        static int Cube(int n)
        {
            return Square(n) * n;
        }
    }
}

//Sample Output
//Enter an integer value: 12
//12 squared = 144
//12 cubed = 1728