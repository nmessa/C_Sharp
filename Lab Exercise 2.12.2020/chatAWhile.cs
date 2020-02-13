//Lab Exercise 2.12.2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare an array of area codes as strings
            string[] codes = new string[] {"262", "414", "608", "715", "815", "920"};

            //Declare an array of rates as doubles
            double[] rates = new double[] { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            //Declare variables
            string strBill, areaCode, strRate;
            int minutes, index;
            double bill;

            //Get area  code from user
            Console.Write("Enter area code: ");
            areaCode = Console.ReadLine();

            //Find location of area code in the array codes
            index = Array.IndexOf(codes, areaCode);

            if (index != -1) //Area code found
            {
                //Get minutes talked as an integer
                Console.Write("Enter the number of minutes talked: ");
                minutes = Convert.ToInt32(Console.ReadLine());

                //Calculate bill
                bill = minutes * rates[index];

                //Convert the bill and rate to currency strings
                strBill = bill.ToString("C");
                strRate = rates[index].ToString("C");

                //Output bill
                Console.WriteLine("Minutes billed:        {0}", minutes);
                Console.WriteLine("Rate:               {0}", strRate);
                Console.WriteLine("Total Bill:         {0}", strBill);
            }
            else //Area code not found
            {
                Console.WriteLine("We do not service that area code");
            }   
        }
    }
}

//Sample Output
//Enter area code: 414
//Enter the number of minutes talked: 23
//Minutes billed:        23
//Rate:               $0.10
//Total Bill:         $2.30