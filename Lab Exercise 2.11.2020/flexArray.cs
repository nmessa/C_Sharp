//Lab Exercise 2.11.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize 3 arrays of integers
            int[] one = new int[] { 4, 6, 8, 9};
            int[] two = new int[] { 24,31,12,27,42};
            int[] three = new int[] { 98,23,45,12,6,38,45,67};

            //Call the ShowArray function to display each array and
            //their sum
            ShowArray(one);
            ShowArray(two);
            ShowArray(three);
        }

        static void ShowArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum += arr[i];
            }
            Console.WriteLine();
            Console.WriteLine("Sum of array = {0}", sum);
        }
    }
}

//Sample Output
//4 6 8 9
//Sum of array = 27
//24 31 12 27 42
//Sum of array = 136
//98 23 45 12 6 38 45 67
//Sum of array = 334