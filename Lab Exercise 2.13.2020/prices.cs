//Lab Exercise 2.13.2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array to hold 20 prices
            double[] prices = new double[20];

            //Declare variables
            double price;
            string strPrice;

            //Fill the array with 20 prices
            for (int i = 0; i < prices.Length; i++)
            {
                Console.Write("Enter a price: ");
                prices[i] = Convert.ToDouble(Console.ReadLine());
            }

            //Print the prices less than $5
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < 5.0)
                {
                    price = prices[i];
                    strPrice = price.ToString("C");
                    Console.WriteLine(strPrice);
                }
            }
        }
    }
}
//Sample Output
//Enter a price: 7
//Enter a price: 4
//Enter a price: 5
//Enter a price: 6
//Enter a price: 7
//Enter a price: 8
//Enter a price: 34
//Enter a price: 3
//Enter a price: 1.34
//Enter a price: 4.56
//Enter a price: 9
//Enter a price: 34
//Enter a price: 45
//Enter a price: 65
//Enter a price: 1.37
//Enter a price: 4.99
//Enter a price: 3
//Enter a price: 2
//Enter a price: 1
//Enter a price: 2
//$4.00
//$3.00
//$1.34
//$4.56
//$1.37
//$4.99
//$3.00
//$2.00
//$1.00
//$2.00