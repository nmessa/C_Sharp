//Lab Exercise 2.13.2020 Probelm 2b
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaPrices2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create 2 arrays of sizes and prices
            string[] sizes = new string[] { "S", "M", "L", "X" };
            double[] prices = new double[] { 6.99, 8.99, 12.50, 15.00 };

            //Declare variables
            string size, strCost, strTotal, strFinal;
            int index, number, discount;
            double cost, total, final;

            //Get size of pizza
            Console.Write("Enter the size of the pizza(S, M, L, of X): ");
            size = Console.ReadLine().ToUpper();

            //Find the index of the size
            index = Array.IndexOf(sizes, size);

            //Get number of pizza's
            Console.Write("How many pizza's do you wish? ");
            number = Convert.ToInt32(Console.ReadLine());

            if (index != -1)  //Valid size entered
            {
                //get cost of 1 pizza
                cost = prices[index];

                //calculate total cost
                total = cost * number;

                //Find discount
                switch (number)
                {
                    case 1:
                        discount = 0;
                        break;
                    case 2:
                        discount = 10;
                        break;
                    case 3:
                        discount = 15;
                        break;
                    case 4:
                        discount = 15;
                        break;
                    default:
                        discount = 20;
                            break;
                }

                //Calculate final cost
                final = total * (1.0 - discount / 100.0);

                //Convert cost, total, and final to currency strings
                strCost = cost.ToString("C");
                strTotal = total.ToString("C");
                strFinal = final.ToString("C");

                //Output report
                Console.WriteLine("Your {0} pizza normally costs {1}", size, strCost);
                Console.WriteLine("The total would normally be {0}", strTotal);
                Console.WriteLine("Because you ordered {0}, your discount is {1}%", number, discount);
                Console.WriteLine("For a final total of {0}", strFinal);
            }
            else  //Invalid size entered
            {
                Console.WriteLine("You have entered an invalid size");
            }
        }
    }
}

//Sample Output
//Enter the size of the pizza(S, M, L, of X): L
//How many pizza's do you wish? 4
//Your L pizza normally costs $12.50
//The total would normally be $50.00
//Because you ordered 4, your discount is 15%
//For a final total of $42.50