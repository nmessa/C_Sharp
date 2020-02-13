//Lab Exercise 1.29.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            Random r = new Random();
            int rNumber = r.Next(1, 11);
            int guess;
            string userInput;

            //Get guess from user and convert to 32 bit integer
            Console.Write("Enter your guess (1 - 10): ");
            userInput = Console.ReadLine();
            guess = Convert.ToInt32(userInput);

            //Determine if the guess was correct, too high, or too low
            if (guess > rNumber)
                Console.WriteLine("You guessed high");
            else if (guess < rNumber)
                Console.WriteLine("You guessed low");
            else
                Console.WriteLine("You guessed the number");
        }
    }
}

//Sample Output
//Enter your guess (1 - 10): 7
//You guessed high