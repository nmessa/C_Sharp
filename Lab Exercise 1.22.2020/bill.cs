//Lab Exercise 1.22.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAX_RATE = 0.05;
            double myBill, tax, grandTotal;
            string userInput;

            //Get the amout of bill from user
            Console.Write("Enter the amount of the bill: ");
            userInput = Console.ReadLine();
            myBill = Convert.ToDouble(userInput);

            //Calculate tax
            tax = myBill * TAX_RATE;

            //Calculate grand total
            grandTotal = myBill + tax;

            //Output the bill
            Console.WriteLine("Your bill: \t${0}", myBill);
            Console.WriteLine("Sales tax: \t${0}", tax);
            Console.WriteLine("Grand total: \t${0}", grandTotal);
        }
    }
}

//Sample Output
//Enter the amount of the bill: 100
//Your bill:      $100
//Sales tax:      $5
//Grand total:    $105
