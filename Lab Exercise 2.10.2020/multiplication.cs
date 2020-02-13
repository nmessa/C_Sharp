//Lab Exercise 2/10/2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int number;
            string userInput;

            //Get which table from the user
            Console.Write("Enter the times table you desire: ");
            userInput = Console.ReadLine();
            number = Convert.ToInt32(userInput);

            //Call the MultiplicationTable function
            MultiplicationTable(number);
        }

        //This function displays a multiplication table based on the integer
        //parameter passed to it.
        static void MultiplicationTable(int n)
        {
            for (int i = 2; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2}", i, n, i * n);
        }
    }
}

//Sample Output
//Enter the times table you desire: 8
//2 x 8 = 16
//3 x 8 = 24
//4 x 8 = 32
//5 x 8 = 40
//6 x 8 = 48
//7 x 8 = 56
//8 x 8 = 64
//9 x 8 = 72
//10 x 8 = 80