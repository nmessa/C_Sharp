//Lab Exercise 2/4/2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayMuliplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 10; i++)
                for (j = 1; j <= 10; j++)
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
        }
    }
}

//Output
//1 x 1 = 1
//1 x 2 = 2
//1 x 3 = 3
//1 x 4 = 4
//1 x 5 = 5
//1 x 6 = 6
//1 x 7 = 7
//1 x 8 = 8
//1 x 9 = 9
//1 x 10 = 10
// ...
//10 x 1 = 10
//10 x 2 = 20
//10 x 3 = 30
//10 x 4 = 40
//10 x 5 = 50
//10 x 6 = 60
//10 x 7 = 70
//10 x 8 = 80
//10 x 9 = 90
//10 x 10 = 100