//Lab Exercise 2.3.2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare varaibles
            string person, userInput;
            double andreaSales=0, brittanySales=0, ericSales=0, amount=0;
            double andreaCommission, brittanyCommission, ericCommission;
            double andreaTotal, brittanyTotal, ericTotal;
            char p;
            string strAndrea, strBrittany, strEric;

            //Get salesperson ID as a char
            Console.Write("Enter the salesperson (A, B, or E) (Z to quit): ");
            person = Console.ReadLine().ToUpper();
            p = person[0];

            //If valid salesperson (not 'Z'), get their amount of weekly sales
            if (p != 'Z')
            {
                Console.Write("Enter the amount of weekly sales: ");
                userInput = Console.ReadLine();
                amount = Convert.ToDouble(userInput);
            }
            
            //Keep looping until Z entered
            while (p != 'Z')
            {
                //add amount to appropriate salesperson
                switch (p)
                {
                    case 'A':
                        andreaSales += amount;
                        break;
                    case 'B':
                        brittanySales += amount;
                        break;
                    case 'E':
                        ericSales += amount;
                        break;
                }

                //Get another salesperson ID as a char
                Console.Write("Enter the salesperson (A, B, or E) (Z to quit): ");
                person = Console.ReadLine().ToUpper();
                p = person[0];

                //If valid salesperson (not 'Z'), get their amount of weekly sales
                if (p != 'Z')
                {
                    Console.Write("Enter the amount of weekly sales: ");
                    userInput = Console.ReadLine();
                    amount = Convert.ToDouble(userInput);
                }
            }
            //Calculate Commissions
            andreaCommission = andreaSales * 0.1;
            brittanyCommission = brittanySales * 0.1;
            ericCommission = ericSales * 0.1;

            //Calculate totals
            andreaTotal = andreaSales + andreaCommission;
            brittanyTotal = brittanySales + brittanyCommission;
            ericTotal = ericSales + ericCommission;

            //Print Sales Totals
            Console.WriteLine();
            strAndrea = andreaSales.ToString("C");
            strBrittany = brittanySales.ToString("C");
            strEric = ericSales.ToString("C");
            Console.WriteLine("Andrea Sales            {0}", strAndrea);
            Console.WriteLine("Brittany Sales          {0}", strBrittany);
            Console.WriteLine("Eric Sales              {0}", strEric);

            //Print Sales Commisssions
            strAndrea = andreaCommission.ToString("C");
            strBrittany = brittanyCommission.ToString("C");
            strEric = ericCommission.ToString("C");
            Console.WriteLine("Andrea Commission       {0}", strAndrea);
            Console.WriteLine("Brittany Commission     {0}", strBrittany);
            Console.WriteLine("Eric Commission         {0}", strEric);

            //Print Totals
            strAndrea = andreaTotal.ToString("C");
            strBrittany = brittanyTotal.ToString("C");
            strEric = ericTotal.ToString("C");
            Console.WriteLine("Andrea Total            {0}", strAndrea);
            Console.WriteLine("Brittany Total          {0}", strBrittany);
            Console.WriteLine("Eric Total              {0}", strEric);
        }
    }
}

//Sample Output
//Enter the salesperson (A, B, or E) (Z to quit): a
//Enter the amount of weekly sales: 1234.56
//Enter the salesperson (A, B, or E) (Z to quit): b
//Enter the amount of weekly sales: 2345.67
//Enter the salesperson (A, B, or E) (Z to quit): e
//Enter the amount of weekly sales: 3456.78
//Enter the salesperson (A, B, or E) (Z to quit): z

//Andrea Sales            $1,234.56
//Brittany Sales          $2,345.67
//Eric Sales              $3,456.78
//Andrea Commission       $123.46
//Brittany Commission     $234.57
//Eric Commission         $345.68
//Andrea Total            $1,358.02
//Brittany Total          $2,580.24
//Eric Total              $3,802.46
