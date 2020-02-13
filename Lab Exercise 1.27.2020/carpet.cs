//Lab Exercise 1.27.2020 Problem 1
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
            double length, width;
            double cost, roomCost;
            string userInput, money;

            //Get user input
            Console.Write("Enter the length of room: ");
            userInput = Console.ReadLine();
            length = Convert.ToDouble(userInput);
            Console.Write("Enter the width of room: ");
            userInput = Console.ReadLine();
            width = Convert.ToDouble(userInput);
            Console.Write("Enter the cost of carpet per square foot: ");
            userInput = Console.ReadLine();
            cost = Convert.ToDouble(userInput);

            //Calculate the cost of carpeting the room
            roomCost = length * width * cost;

            //Convert cost to a currency string
            money = roomCost.ToString("C");

            //Output the result
            Console.WriteLine("The cost of carpeting the room is {0}", money);
        }
    }
}

//Sample Output
//Enter the length of room: 10
//Enter the width of room: 15
//Enter the cost of carpet per square foot: 2.30
//The cost of carpeting the room is $345.00
