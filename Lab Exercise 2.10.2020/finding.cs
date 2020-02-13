using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Finding
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "abcde";
            string toFind;
            char ch;
            int index;
            Console.Write("Enter a letter: ");
            toFind = Console.ReadLine();
            if (testString.Contains(toFind))
                Console.WriteLine("Found the letter");
            else
                Console.WriteLine("Letter not found");

            ch = toFind[0];
            index = testString.IndexOf(ch);
            if (index != -1)
                Console.WriteLine("Found {0} at location {1}", ch, index);
            else
                Console.WriteLine("{0} not found", ch);
        }
    }
}
