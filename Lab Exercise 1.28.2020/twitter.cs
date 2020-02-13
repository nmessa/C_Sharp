//Lab Exercise 1.28.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variable
            string message;

            //Get message to send from user
            Console.Write("Enter your message: ");
            message = Console.ReadLine();

            //Determine if message is acceptable length
            if (message.Length <= 280)
                Console.WriteLine("Your message is acceptable length");
            else
                Console.WriteLine("Your message is too long");
        }
    }
}
