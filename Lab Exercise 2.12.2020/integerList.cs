//Lab Exercise 2.12.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize array of integers
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Print array elements forward
            for (int i = 0; i < numbers.Length; i++)
                Console.Write("{0} ", numbers[i]);
            Console.WriteLine();

            //Print array elements backward
            for (int i = numbers.Length - 1; i >= 0; i--)
                Console.Write("{0} ", numbers[i]);
            Console.WriteLine();
        }
    }
}

//Output
//1 2 3 4 5
//5 4 3 2 1
