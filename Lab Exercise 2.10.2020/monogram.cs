//Lab Exercise 2.10.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            char first = 'N', middle = 'C', last = 'M', first2 = 'P', middle2 = 'A', last2 = 'M';

            //Call the DisplayMonogram twice
            DisplayMonogram(first, middle, last);
            DisplayMonogram(first2, middle2, last2);
        }

        //This function is passed 3 characters as parameters and displays a formatted monogram
        static void DisplayMonogram(char f, char m, char l)
        {
            string monogram;
            monogram = "** " + f + ". " + m + ". " + l + ". **";
            Console.WriteLine(monogram);
        }
    }
}

//Output
//** N. C. M. **
//** P. A. M. **