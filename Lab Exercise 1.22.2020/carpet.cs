//Lab Exercise 1.22.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double length, width, area;
            string userInput;

            //Get input from user
            Console.Write("Enter the length of the room (in feet): ");
            userInput = Console.ReadLine();
            length = Convert.ToDouble(userInput);
            Console.Write("Enter the width of the room (in feet): ");
            userInput = Console.ReadLine();
            width = Convert.ToDouble(userInput);

            //Calcualte the area of the room
            area = length * width;

            //Output the result
            Console.WriteLine("Area = {0} square feet", area);
        }
    }
}
//Sample Output
//Enter the length of the room (in feet): 12
//Enter the width of the room (in feet): 10
//Area = 120 square feet
