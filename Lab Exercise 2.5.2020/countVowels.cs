//Lab Exercise 2.5.2020 Problem 3
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            string vowels = "aeiouAEIOU";
            string phrase;
            int count = 0;

            //Get phrase from user
            Console.Write("Enter a phrase: ");
            phrase = Console.ReadLine();

            //Parse the phrase and count vowels
            for (int i = 0; i < phrase.Length; i++)
            {
                if (vowels.Contains(phrase[i]))
                    count++;
            }

            //Output result
            Console.WriteLine("Your phrase contains {0} vowels", count);
        }
    }
}

//Sample Output
//Enter a phrase: Now is the time for all good men to come to the aid of their country
//Your phrase contains 22 vowels