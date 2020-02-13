//Lab Exercise 2.4.2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int i, sum=0;

            //Add up the integers from 1 to 50
            for (i = 1; i <= 50; i++)
                sum += i;

            //Output the sum
            Console.WriteLine(sum);
        }
    }
}

//Output
//1275