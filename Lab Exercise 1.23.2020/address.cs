//Lab Exercise 1.23.2020 Problem 1
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

            //Assign values
            name = "John Smith";
            address = "12 Main Street";
            city = "Exeter";
            state = "NH";
            zipcode = "03833";

            //Output the result
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine("{0}, {1}   {2}", city, state, zipcode);
        }
    }
}

//Output
//John Smith
//12 Main Street
//Exeter, NH   03833
