//Lab Exercise 2.12.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of zip codes
            string[] zips = new string[] {"03833", "03834", "03835", "03836", "03837",
                "03838", "03839", "03830", "03831", "03832"};
            string zipCode;

            //Get zip code from user
            Console.Write("Enter a zip code: ");
            zipCode = Console.ReadLine();

            //Check to see if zip code is in delivery area
            if (zips.Contains(zipCode))
                Console.WriteLine("{0} found", zipCode);
            else
                Console.WriteLine("{0} not found", zipCode);

        }
    }
}

//Sample outputs
//Enter a zip code: 03833
//03833 found

//Enter a zip code: 03909
//03909 not found