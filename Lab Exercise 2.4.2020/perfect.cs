//Lab Exercise 2/4/2020 Problem 5
//Author: nmessa
//Find all perfect numbers less than 1000

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int number, div, sum;
            for (number = 2; number <= 1000; number++)
            {
                sum = 0;
                //Add up all the even divisors for a number
                for (div = 1; div < number; div++)
                {
                    if (number % div == 0)
                        sum += div;
                }

                //if number and sum are equal, print the perfect number
                if (number == sum)
                    Console.WriteLine(number);
            }
        }
    }
}

//Output
//6
//28
//496