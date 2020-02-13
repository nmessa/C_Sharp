//Lab Exercise 2.13.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two arrays for cost and commission as integers
            int[] cost = new int[] { 0, 15001, 24001 };
            int[] commission = new int[] {5, 7, 10};

            //Declare variables
            int sales, index;
            double comm;
            string strSales, strComm;

            //Get cost of car as an integer
            Console.Write("Enter the cost of the car: ");
            sales = Convert.ToInt32(Console.ReadLine());

            //Find the commission index
            index = cost.Length-1;
            while (index >= 0 && sales < cost[index])
                index--;

            //Calculate commission
            comm = sales * commission[index]/100.0;

            //Convert sales and commission to currency strings
            strSales = sales.ToString("C");
            strComm = comm.ToString("C");

            //Output the results
            Console.WriteLine("Your commission on a sale of {0} is {1}%", strSales, strComm);
        }
    }
}

//Sample Output
//Enter the cost of the car: 21000
//Your commission on a sale of $21,000.00 is $1,470.00