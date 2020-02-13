//Lab Exercise 2.13.2020 Problem 5
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeeBall
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a 2D integer array of players stats 12x5
            int[,] players = new int[12,5];

            //Declare variables
            int number, bases;

            //Get player number to update stats
            Console.Write("Enter the player number (0 - 11): ");
            number = Convert.ToInt32(Console.ReadLine());

            //enter the stats
            while (number != 99)
            {
                Console.Write("How many bases at this at bat (0 - 4)? ");
                bases = Convert.ToInt32(Console.ReadLine());
                players[number, bases]++;
                Console.Write("Enter the player number (0 - 11): ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            //Display report
            Console.WriteLine("Player   Out  Singles Doubles Triples  Homers");
            for (int p = 0; p < 12; p++)
            {
                Console.Write("Player {0}  ", p);
                for (int b = 0; b < 5; b++)
                {
                    Console.Write(players[p, b] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

//Sample Output
//Enter the player number (0 - 11): 2
//How many bases at this at bat (0 - 4)? 4
//Enter the player number (0 - 11): 1
//How many bases at this at bat (0 - 4)? 3
//Enter the player number (0 - 11): 2
//How many bases at this at bat (0 - 4)? 2
//Enter the player number (0 - 11): 1
//How many bases at this at bat (0 - 4)? 1
//Enter the player number (0 - 11): 99
//Player   Out  Singles Doubles Triples  Homers
//Player 0  0     0       0       0       0
//Player 1  0     1       0       1       0
//Player 2  0     0       1       0       1
//Player 3  0     0       0       0       0
//Player 4  0     0       0       0       0
//Player 5  0     0       0       0       0
//Player 6  0     0       0       0       0
//Player 7  0     0       0       0       0
//Player 8  0     0       0       0       0
//Player 9  0     0       0       0       0
//Player 10  0    0       0       0       0
//Player 11  0    0       0       0       0