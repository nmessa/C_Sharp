//Lab Exercise 2.6.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int inches;
            string userInput;

            //Get inches from user
            Console.Write("Enter the number of inches: ");
            userInput = Console.ReadLine();
            inches = Convert.ToInt32(userInput);

            //Pass inches to convertToFeet  function
            convertToFeet(inches);
        }

        //This function receives inches and prints out feet and inches
        static void convertToFeet(int inches)
        {
            int feet, i;
            feet = inches / 12;
            i = inches % 12;
            Console.WriteLine("{0} inches = {1} feet and {2} inches", inches, feet, i);
        }
    }
}

//Sample Output
//Enter the number of inches: 67
//67 inches = 5 feet and 7 inches
