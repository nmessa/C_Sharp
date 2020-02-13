//Lab Exercise 2.11.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int drawers;
            char woodType;
            int cost;

            //Get the number of drawers the desk will have
            drawers = NumberOfDrawers();

            //Get the type of wood the desk will have
            woodType = TypeOfWood();

            //Call CalcCosts function to the cost of the desk based on number of 
            //drawers and type of wood which are passed as parameters
            cost = CalcCosts(drawers, woodType);

            //Call the DisplayDesk function passing type of wood, number of drawers
            //and cost as parameters
            DisplayDesk(woodType, drawers, cost);
        }

        //This function gets the number of drawers and returns that value as an integer
        static int NumberOfDrawers()
        {
            int numDrawers;
            string userInput;
            Console.Write("How many drawers does the desk have? ");
            userInput = Console.ReadLine();
            numDrawers = Convert.ToInt32(userInput);
            return numDrawers;
        }

        //This function gets the type of wood and returns that value as a char
        static char TypeOfWood()
        {
            string wood;
            Console.WriteLine("What type of wood? ('m' = mahogany 'o' = oak 'p' = pine ");
            wood = Console.ReadLine();
            return wood[0];
        }

        //This function is passed the number of drawers ad type of wood as parameters
        //and returns cost of desk
        static int CalcCosts(int numDrawers, char woodType)
        {
            int cost;
            const int DRAWER_COST = 30;

            //Get base cost
            switch (woodType)
            {
                case 'p':
                    cost = 100;
                    break;
                case 'o':
                    cost = 140;
                    break;
                default:
                    cost = 180;
                    break;
            }

            //Add drawer surcharge
            cost += numDrawers * DRAWER_COST;
            return cost;
        }

        //This function displays desk information based on the parameters
        //passed to it (type of wood, number of drawers, and cost)
        static void DisplayDesk(char woodType, int numDrawers, int cost)
        {
            string wood = "";
            string strCost;
            switch (woodType)
            {
                 case 'p':
                    wood = "Pine";
                    break;
                case 'o':
                    wood = "Oak";
                    break;
                 case 'm':
                    wood = "Mahogany";
                    break;
            }

            strCost = cost.ToString("C");
            Console.WriteLine("Wood Type             {0}", wood);
            Console.WriteLine("Number of drawers     {0}", numDrawers);
            Console.WriteLine("Final Price           {0}", strCost);
        }
    }
}
//Sample Output
//How many drawers does the desk have? 4
//What type of wood? ('m' = mahogany 'o' = oak 'p' = pine
//o
//Wood Type             Oak
//Number of drawers     4
//Final Price           $260.00