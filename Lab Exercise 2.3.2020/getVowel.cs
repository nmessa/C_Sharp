//Lab Exercise 2.3.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string vowels = "aeiouAEIOU";
            int index;
            string letter;
            
            //Prime the while loop
            Console.Write("Enter a vowel (! to quit): ");
            letter = Console.ReadLine();

            //Keep looping until ! is entered
            while (letter != "!")
            {
                //check to see if a vowel
                index = vowels.IndexOf(letter);
                if (index != -1)
                    Console.WriteLine("OK");
                else
                    Console.WriteLine("This is not a vowel");

                //Enter another vowel
                Console.Write("Enter a vowel (! to quit): ");
                letter = Console.ReadLine();
            }
        }
    }
}

//Sample Output
//Enter a vowel (! to quit): a
//OK
//Enter a vowel (! to quit): e
//OK
//Enter a vowel (! to quit): I
//OK
//Enter a vowel (! to quit): f
//This is not a vowel
//Enter a vowel (! to quit): J
//This is not a vowel
//Enter a vowel (! to quit): !