//Lab Exercise 2/10/2020 Problem 3
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
            //Declare variables
            int salesAmount;
            double myCommission;
            string strCommission;

            //Get sales amount
            salesAmount = Sales();

            //Get Commission on sales amount
            myCommission = Commission(salesAmount);

            //Convert commission into a currency string
            strCommission = myCommission.ToString("C");
            Console.WriteLine("Your commission is {0}", strCommission);
        }


        //This function returns the sales amount as an integer
        static int Sales()
        {
            int amount;
            string userInput;
            Console.Write("Enter the sales amount: ");
            userInput = Console.ReadLine();
            amount = Convert.ToInt32(userInput);
            return amount;
        }

        //This function is passed the sales amount as a parameter and returns
        //the commission on the sales
        static double Commission(int sales)
        {
            double comm;
            if (sales < 1000)
                comm = sales * 0.03;
            else if (sales < 3000)
                comm = sales * 0.04;
            else
                comm = sales * 0.05;

            return comm;
        }
    }
}

//Sample Output
//Enter the sales amount: 3500
//Your commission is $175.00
