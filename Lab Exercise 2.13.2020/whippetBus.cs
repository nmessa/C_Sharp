//Lab Exercise 2.13.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two arrays for miles and prices
            int[] miles = new int[] { 0, 100, 300, 500 };
            double[] prices = new double[] { 25.00, 40.00, 55.00, 70.00};

            //Declare variables
            int distance;
            double amount;
            string strAmount;
            int index;

            //Get distance to travel from user
            Console.Write("Enter the distance to travel: ");
            distance = Convert.ToInt32(Console.ReadLine());

            //Find index
            index = miles.Length - 1;
            while (index >= 0 && distance < miles[index])
                index--;

            //Find amount
            amount = prices[index];

            //Convert amount to currency string
            strAmount = amount.ToString("C");

            //Output result
            Console.WriteLine("The bill for your {0} miles trip is {1}", distance, strAmount);
        }
    }
}
//Sample Output
//Enter the distance to travel: 150
//The bill for your 150 miles trip is $40.00