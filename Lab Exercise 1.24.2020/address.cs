//Lab Exercise 1.24.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Address
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string name, address, city, state, zipcode;

            //Get input from user
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your address: ");
            address = Console.ReadLine();
            Console.Write("Enter your city: ");
            city = Console.ReadLine();
            Console.Write("Enter your state: ");
            state = Console.ReadLine();
            Console.Write("Enter your zipcode: ");
            zipcode = Console.ReadLine();

            //Output results
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine("{0}, {1}   {2}", city, state, zipcode);
        }
    }
}

//Output
//Enter your name: Herman Munster
//Enter your address: 13 Mockingbird Lane
//Enter your city: Exeter
//Enter your state: NH
//Enter your zipcode: 03833
//Herman Munster
//13 Mockingbird Lane
//Exeter, NH   03833