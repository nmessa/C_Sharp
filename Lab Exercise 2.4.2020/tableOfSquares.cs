//Lab Exercise 2.4.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int number, square;

            //Create a table of numbers 1 to 20 and their squares
            for (number = 1; number <= 20; number++)
            {   
                square = number * number;
                Console.WriteLine("{0}   {1}", number, square);
            }
        }
    }
}
//Output
//1   1
//2   4
//3   9
//4   16
//5   25
//6   36
//7   49
//8   64
//9   81
//10   100
//11   121
//12   144
//13   169
//14   196
//15   225
//16   256
//17   289
//18   324
//19   361
//20   400