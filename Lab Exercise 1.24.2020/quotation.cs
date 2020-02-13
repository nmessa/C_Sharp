//Lab Exercise 1.24.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string quote, author;

            //Get user input
            Console.WriteLine("Enter your favorite quotation: ");
            quote = Console.ReadLine();
            Console.Write("Enter the author: ");
            author = Console.ReadLine();

            //Output the results
            Console.WriteLine(quote);
            Console.WriteLine("\t\t\t\t\t--{0}", author);

        }
    }
}

//Output
//Enter your favorite quotation:
//Get your facts first, then you can distort them as you wish.
//Enter the author: Mark Twain
//Get your facts first, then you can distort them as you wish.
//                                        --Mark Twain