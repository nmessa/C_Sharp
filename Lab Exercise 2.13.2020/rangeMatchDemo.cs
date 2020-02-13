using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangeMatch_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfItems, discount;
            Console.Write("Enter the number of items to purchase: ");
            numOfItems = Convert.ToInt32(Console.ReadLine());
            int[] discountRangeLowLimit = { 1, 13, 50, 100, 200 };
            double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            double customerDiscount;
            int index = discountRangeLowLimit.Length - 1;
            while (index >= 0 && numOfItems < discountRangeLowLimit[index])
                index--;
            customerDiscount = discounts[index];
            discount = Convert.ToInt32(customerDiscount * 100);
            Console.WriteLine("Your discount is {0}%", discount);
        }
    }
}
