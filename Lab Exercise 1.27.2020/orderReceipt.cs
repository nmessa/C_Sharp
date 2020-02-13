//Lab Exercise 1.27.2020 Problem 5
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string name, address, city, state, zipcode, userInput;
            int quantity;
            double tax, total, net;
            const double COST = 39.95;
            const double SALES_TAX = 0.07;
            string strTax, strTotal, strNet;

            //Get input from user
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter address: ");
            address = Console.ReadLine();
            Console.Write("Enter city: ");
            city = Console.ReadLine();
            Console.Write("Enter state: ");
            state = Console.ReadLine();
            Console.Write("Enter zipcode: ");
            zipcode = Console.ReadLine();
            Console.Write("Enter number of blender to purchase: ");
            userInput = Console.ReadLine();
            quantity = Convert.ToInt32(userInput);

            //Calculate total cost
            total = quantity * COST;

            //Calculate sales tax
            tax = total * SALES_TAX;

            //Calculate the net cost
            net = total + tax;

            //Create currency strings
            strTax = tax.ToString("C");
            strTotal = total.ToString("C");
            strNet = net.ToString("C");

            //Output report
            Console.WriteLine("Receipt for:");
            Console.WriteLine(name);
            Console.WriteLine(address);
            Console.WriteLine("{0}, {1}   {2}", city, state, zipcode);
            Console.WriteLine();
            Console.WriteLine("{0} blenders ordered at {1} each", quantity, COST);
            Console.WriteLine();
            Console.WriteLine("Total:   {0}", strTotal);
            Console.WriteLine("Tax      {0}", strTax);
            Console.WriteLine("---------------");
            Console.WriteLine("Due:     {0}", strNet);
        }
    }
}

//Sample Output
//Enter name: Mason Williams
//Enter address: 1234 Main Street
//Enter city: Exeter
//Enter state: NH
//Enter zipcode: 03833
//Enter number of blender to purchase: 5
//Receipt for:
//Mason Williams
//1234 Main Street
//Exeter, NH   03833

//5 blenders ordered at 39.95 each

//Total:   $199.75
//Tax      $13.98
//---------------
//Due:     $213.73