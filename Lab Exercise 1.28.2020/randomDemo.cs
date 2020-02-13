using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int num;
            double dnum;

            num = r.Next();
            Console.WriteLine(num);

            num = r.Next(9);
            Console.WriteLine(num);

            num = r.Next(1,6);
            Console.WriteLine(num);

            dnum = r.NextDouble();
            Console.WriteLine(dnum);
        }
    }
}
//Output
//1764071435
//3
//5
//0.455846664708036
