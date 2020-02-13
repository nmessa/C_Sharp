//Lab Exercise 2.13.2020 Problem 2a
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two arrays for sizes and prices
            string[] sizes = new string[] {"S", "M", "L", "X"};
            double[] prices = new double[] {6.99, 8.99, 12.50, 15.00};

            //Declare variables
            string size, strCost;
            int index;
            double cost;

            //Get size of pizza
            Console.Write("Enter the size of the pizza(S, M, L, of X): ");
            size = Console.ReadLine().ToUpper();

            //Find index of size
            index = Array.IndexOf(sizes, size);


            if (index != -1)  //size found
            {
                //Get cost of pizza
                cost = prices[index];
                strCost = cost.ToString("C");
                Console.WriteLine("Your pizza costs {0}", strCost);
            }
            else  //size not found
            {
                Console.WriteLine("You have entered an invalid size");
            }
        }
    }
}

//Sample Output
//Enter the size of the pizza(S, M, L, of X): M
//Your pizza costs $8.99