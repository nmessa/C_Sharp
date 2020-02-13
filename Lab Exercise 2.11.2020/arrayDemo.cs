//Array demonstration program
//Author: nmessa
//Date: 2.10.2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            // defining array with size 5. Does not assign values
            int[] intArray1 = new int[5];

            // defining array with size 5 and assigning values at the same time
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

            // defining array with 5 elements which indicates the size of an array
            int[] intArray3 = { 1, 2, 3, 4, 5 };

            //Fill intArray1 with random integers from 1 to 1000
            for (int i = 0; i < intArray1.Length; i++)
            {
                intArray1[i] = r.Next(1, 1001);
            }

            //Display intArray1
            for (int i = 0; i < intArray1.Length; i++)
            {
                Console.WriteLine("intArray1[{0}] = {1}", i, intArray1[i]);
            }

            //Create an array to hold 5 names
            String[] names = new String[5];

            //Fill the names array with 5 names
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter a name: ");
                names[i] = Console.ReadLine();
            }

            //Display the contents of the names array
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("names[{0}] = {1}", i, names[i]);
            }
        }
    }
}

//Sample output
//intArray1[0] = 839
//intArray1[1] = 484
//intArray1[2] = 746
//intArray1[3] = 938
//intArray1[4] = 139
//Enter a name: Joe
//Enter a name: Fred
//Enter a name: Mary
//Enter a name: Alice
//Enter a name: Jack
//names[0] = Joe
//names[1] = Fred
//names[2] = Mary
//names[3] = Alice
//names[4] = Jack
