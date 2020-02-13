//Lab Exercise 1.29.2020 Problem 5
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int n1, n2, n3, g1, g2, g3, count = 0, award;
            string temp;
            Random r = new Random();

            //Generate 3 random numbers
            n1 = r.Next(1, 5);
            n2 = r.Next(1, 5);
            n3 = r.Next(1, 5);

            //Get 3 numbers from user and convert them to 32 bit integers
            Console.WriteLine("Enter 3 numbers: ");
            temp = Console.ReadLine();
            g1 = Convert.ToInt32(temp);
            temp = Console.ReadLine();
            g2 = Convert.ToInt32(temp);
            temp = Console.ReadLine();
            g3 = Convert.ToInt32(temp);

            //Determine number of matches
            if (n1 == g1)
                count++;
            if (n2 == g2)
                count++;
            if (n3 == g3)
                count++;

            //Determine the amount of award
            if (count == 0)
                award = 0;
            else
                award = Convert.ToInt32(Math.Pow(10, count));

            //Output award infomration
            Console.WriteLine("Your award is {0}", award);
        }
    }
}

//Sample Output
//Enter 3 numbers:
//3
//3
//3
//Your award is 10