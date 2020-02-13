using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDemo2D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two-dimensional array 
            int[, ] intArray = new int[, ] { { 1, 2 }, 
                                         { 3, 4 },  
                                         { 5, 6 },  
                                         { 7, 8 } }; 
  
            // A similar array with string elements. 
            string[, ] str = new string[4, 2] { { "one", "two" },  
                                            { "three", "four" },  
                                            { "five", "six" },  
                                            { "seven", "eight" } }; 
  
            // Accessing array elements. 
            Console.WriteLine("2D array contents");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Console.WriteLine("intArray[{0}][{1}] = {2}", i, j, intArray[i, j]);
            Console.WriteLine();

            //Display array
            Console.WriteLine();
            Console.WriteLine("2D array display");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(intArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // using nested loop show string elements 
            Console.WriteLine("\nString array contents"); 
            for (int i = 0; i < 4; i++) 
                for (int j = 0; j < 2; j++) 
                    Console.WriteLine("str[{0}][{1}] = {2}", i, j, str[i, j]);
            Console.WriteLine();
        } 
    }
}

//Output
//2D array contents
//intArray[0][0] = 1
//intArray[0][1] = 2
//intArray[1][0] = 3
//intArray[1][1] = 4
//intArray[2][0] = 5
//intArray[2][1] = 6
//intArray[3][0] = 7
//intArray[3][1] = 8


//String array contents
//str[0][0] = one
//str[0][1] = two
//str[1][0] = three
//str[1][1] = four
//str[2][0] = five
//str[2][1] = six
//str[3][0] = seven
//str[3][1] = eight