using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RangeMatch_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfItems, discount;
            Console.Write("Enter the number of items to purchase: ");
            numOfItems = Convert.ToInt32(Console.ReadLine());
            int[] discountRangeUpperLimit = { 12, 49, 99, 199, 9999999 };
            double[] discounts = { 0, 0.10, 0.14, 0.18, 0.20 };
            double customerDiscount;
            int sub = 0;
            while (sub < discountRangeUpperLimit.Length && numOfItems > discountRangeUpperLimit[sub])
                ++sub;
            customerDiscount = discounts[sub];
            discount = Convert.ToInt32(customerDiscount * 100);
            Console.WriteLine("Your discount is {0}%", discount);
        }
    }
}
