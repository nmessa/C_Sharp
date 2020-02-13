//Lab Exercise 2.11.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallAndLarge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a 10 element array of integers
            int[] numbers = new int[10];
            string userInput;

            //Fill the array with 10 user provided integers
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter an integer: ");
                userInput = Console.ReadLine();
                numbers[i] = Convert.ToInt32(userInput);
            }

            //Call the DisplayMaxMin function passing the array as a parameter
            DisplayMaxMin(numbers);

        }


        //This function is passed an integer array as a parameter and displays
        //the largest and smallest value
        static void DisplayMaxMin(int[] nums)
        {
            int max, min;
            max = min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < min)
                    min = nums[i];
                if (nums[i] > max)
                    max = nums[i];
            }
            Console.WriteLine("Max value in array = {0}", max);
            Console.WriteLine("Min value in array = {0}", min);
        }
    }
}

//Sample Output
//Enter an integer: 34
//Enter an integer: 53
//Enter an integer: 21
//Enter an integer: 5
//Enter an integer: 77
//Enter an integer: 66
//Enter an integer: 55
//Enter an integer: 44
//Enter an integer: 33
//Enter an integer: 22
//Max value in array = 77
//Min value in array = 5