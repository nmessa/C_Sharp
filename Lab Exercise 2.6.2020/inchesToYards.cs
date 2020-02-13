//Lab Exercise 2/6/2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToYards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int inches;
            string userInput;

            //Get number of inches to convert from user
            Console.Write("Enter the number of inches: ");
            userInput = Console.ReadLine();
            inches = Convert.ToInt32(userInput);

            //Pass inches to convertToFeet function
            convertToFeet(inches);

            //Pass inches to convertToYards function
            convertToYards(inches);
        }

        //This function is passed a number of inches and prints the number of feet and inches
        static void convertToFeet(int inches)
        {
            int feet, i;
            feet = inches / 12;
            i = inches % 12;
            Console.WriteLine("{0} inches = {1} feet and {2} inches", inches, feet, i);
        }

        //This function is passed a number of inches and prints the number of yards, feet, and inches
        static void convertToYards(int inches)
        {
            int yards, feet, i;
            yards = inches / 36;
            i = inches % 36;
            feet = i / 12;
            i = i % 12;
            Console.WriteLine("{0} inches = {1} yard, {2} feet, and {3} inches", inches, yards, feet, i);
        }
    }
}

//Sample Output
//Enter the number of inches: 67
//67 inches = 5 feet and 7 inches
//67 inches = 1 yard, 2 feet, and 7 inches