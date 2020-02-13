//Lab Exercise 2.6.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            int number1 = 10, number2 = 5, p;

            //Pass 2 integers to Sum function
            Sum(number1, number2);

            //Pass 2 integers to Difference function
            Difference(number1, number2);

            //Pass 2 integers to Product function and store returned value in p
            p = Product(number1, number2);
            Console.WriteLine("{0} x {1} = {2}", number1, number2, p);
        }

        //This function is passed 2 integers and prints their sum
        static void Sum(int n1, int n2)
        {
            int total;
            total = n1 + n2;
            Console.WriteLine("{0} + {1} = {2}", n1, n2, total);
        }

        //This function is passed 2 integers and prints their difference
        static void Difference(int n1, int n2)
        {
            int diff;
            diff = n1 - n2;
            Console.WriteLine("{0} - {1} = {2}", n1, n2, diff);
        }

        ////This function is passed 2 integers and returns their product
        static int Product(int n1, int n2)
        {
            int prod;
            prod = n1 * n2;
            return prod;
        }
    }
}

//Output
//10 + 5 = 15
//10 - 5 = 5
//10 x 5 = 50