//Lab Exercise 1.29.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lawn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int length, width, area, fee, totalFee;
            string userInput, strTotalFee, strFee;

            //Define constant for number of weeks in the season
            const int NUM_WEEKS = 20;

            //Get length of lawn and convert to 32 bit integer
            Console.Write("Enter the length of the lawn: ");
            userInput = Console.ReadLine();
            length = Convert.ToInt32(userInput);

            //Get width of lawn and convert to 32 bit integer
            Console.Write("Enter the width of the lawn: ");
            userInput = Console.ReadLine();
            width = Convert.ToInt32(userInput);

            //Calculate are of lawn
            area = length * width;

            //Determine the fee
            if (area < 400)
                fee = 25;
            else if (area < 600)
                fee = 35;
            else
                fee = 50;

            //Calculate the total fee for the season
            totalFee = fee * NUM_WEEKS;

            //Create currency strings to be used in output
            strFee = fee.ToString("C");
            strTotalFee = totalFee.ToString("C");

            //Output the weekly fee and fee for season
            Console.WriteLine("Weekly Fee:        {0}", strFee);
            Console.WriteLine("Fee for season     {0}", strTotalFee);
        }
    }
}
//Sample Output
//Enter the length of the lawn: 40
//Enter the width of the lawn: 40
//Weekly Fee:        $50.00
//Fee for season     $1,000.00

//Enter the length of the lawn: 20
//Enter the width of the lawn: 25
//Weekly Fee:        $35.00
//Fee for season     $700.00

//Enter the length of the lawn: 15
//Enter the width of the lawn: 20
//Weekly Fee:        $25.00
//Fee for season     $500.00