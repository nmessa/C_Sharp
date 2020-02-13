//Lab Exercise 1.29.2020 Problem 4
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            Random r = new Random();
            string rps = "rps";
            char computer, player;
            string temp;

            //Get computer choice (r, p, or s)
            computer = rps[r.Next(3)];

            //Get player choice
            Console.WriteLine("Choose r, p, or s: ");
            temp = Console.ReadLine();
            player = temp[0];

            //Output the players choices
            Console.WriteLine("Player has {0} and computer has {1}", player, computer);
            
            //Determine who won or if it is a tie
            if (player == 'p' && computer == 'r')
                Console.WriteLine("Player wins");
            else if (player == 'r' && computer == 's')
                Console.WriteLine("Player wins");
            else if (player == 's' && computer == 'p')
                Console.WriteLine("Player wins");
            else if (player == 'r' && computer == 'p')
                Console.WriteLine("Computer wins");
            else if (player == 's' && computer == 'r')
                Console.WriteLine("Computer wins");
            else if (player == 'p' && computer == 's')
                Console.WriteLine("Computer wins");
            else
                Console.WriteLine("It's a tie");
        }
    }
}

//Sample Output
//Choose r, p, or s:
//r
//Player has r and computer has s
//Player wins