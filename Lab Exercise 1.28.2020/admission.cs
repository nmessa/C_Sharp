//Lab Exercise 1.28.2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double gpa;
            int testScore;
            string userInput;

            //Get GPA from user and conver to double
            Console.Write("Enter your high school GPA: ");
            userInput = Console.ReadLine();
            gpa = Convert.ToDouble(userInput);

            //Get admission test score from user and convert to 32 bit integer
            Console.Write("Enter your admission test score: ");
            userInput = Console.ReadLine();
            testScore = Convert.ToInt32(userInput);

            //Determine if accepted or rejected
            if (gpa >= 3.0 && testScore >= 60)
                Console.WriteLine("Accept");
            else if (gpa < 3.0 && testScore >= 80)
                Console.WriteLine("Accept");
            else
                Console.WriteLine("Reject");
        }
    }
}
