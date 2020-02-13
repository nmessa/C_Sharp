//Format String Demo
//Author: nmessa
//Date: 1.29.2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            string strNumber, userInput;

            //Demo for rounding floating point number
            //Get input from user
            Console.Write("Enter a floating point number: ");
            userInput = Console.ReadLine();
            number = Convert.ToDouble(userInput);

            //Convert number to a formatted string
            strNumber = number.ToString("F3");   //3 decimal places
            Console.WriteLine(strNumber);

            //Demo for currency formatting
            //Get input from user
            Console.Write("Enter a money value: ");
            userInput = Console.ReadLine();
            number = Convert.ToDouble(userInput);

            //Convert number to a formatted string
            strNumber = number.ToString("C");   // currency format
            Console.WriteLine(strNumber);

        }
    }
}
