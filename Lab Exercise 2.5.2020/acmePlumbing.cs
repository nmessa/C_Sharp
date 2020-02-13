//Lab Exercise 2.5.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcmePlumbingandSupply
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            string name, webURL = "www.";

            //Get name of company from user;
            Console.Write("Enter the name of the company: ");
            name = Console.ReadLine();

            //Build the web url of company (remove spaces in company name)
            for (int index = 0; index < name.Length; index++)
            {
                if (name[index] != ' ')
                    webURL += name[index];
            }

            //Add .com to web url
            webURL += ".com";
            Console.WriteLine("Your web address is {0}", webURL);
        }
    }
}

//Sample Output
//Enter the name of the company: Acme Plumbing and Supply
//Your web address is www.AcmePlumbingandSupply.com