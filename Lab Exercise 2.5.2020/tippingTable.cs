//Lab Exercise 2.5.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TippingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int lowTip, highTip, lowBill, highBill;
            double myTip;
            string userInput, strTip;

            //Get input from user
            Console.Write("Enter the lowest restaurant bill: ");
            userInput = Console.ReadLine();
            lowBill = Convert.ToInt32(userInput);
            Console.Write("Enter the highest restaurant bill: ");
            userInput = Console.ReadLine();
            highBill = Convert.ToInt32(userInput);
            Console.Write("Enter the lowest tip: ");
            userInput = Console.ReadLine();
            lowTip = Convert.ToInt32(userInput);
            Console.Write("Enter the highest tip: ");
            userInput = Console.ReadLine();
            highTip = Convert.ToInt32(userInput);


            //Create heading
            Console.WriteLine();
            Console.Write("Bill ");
            for (int tip = lowTip; tip <= highTip; tip += 5)
                Console.Write("{0}%     ", tip);
            Console.WriteLine();

            //Generate and display table
            for (int bill = lowBill; bill <= highBill; bill++)
            {
                Console.Write("{0}  ", bill);
                for (int tip = lowTip; tip <= highTip; tip += 5)
                {
                    myTip = bill * (tip/100.0);
                    strTip = myTip.ToString("C");
                    Console.Write("{0}   ", strTip);
                }
                Console.WriteLine();
            }
        }
    }
}

//Sample Output
//Enter the lowest restaurant bill: 20
//Enter the highest restaurant bill: 60
//Enter the lowest tip: 10
//Enter the highest tip: 30
//
//Bill 10%     15%     20%     25%     30%
//20  $2.00   $3.00   $4.00   $5.00   $6.00
//21  $2.10   $3.15   $4.20   $5.25   $6.30
//22  $2.20   $3.30   $4.40   $5.50   $6.60
//23  $2.30   $3.45   $4.60   $5.75   $6.90
//24  $2.40   $3.60   $4.80   $6.00   $7.20
//25  $2.50   $3.75   $5.00   $6.25   $7.50
//26  $2.60   $3.90   $5.20   $6.50   $7.80
//27  $2.70   $4.05   $5.40   $6.75   $8.10
//28  $2.80   $4.20   $5.60   $7.00   $8.40
//29  $2.90   $4.35   $5.80   $7.25   $8.70
//30  $3.00   $4.50   $6.00   $7.50   $9.00
//31  $3.10   $4.65   $6.20   $7.75   $9.30
//32  $3.20   $4.80   $6.40   $8.00   $9.60
//33  $3.30   $4.95   $6.60   $8.25   $9.90
//34  $3.40   $5.10   $6.80   $8.50   $10.20
//35  $3.50   $5.25   $7.00   $8.75   $10.50
//36  $3.60   $5.40   $7.20   $9.00   $10.80
//37  $3.70   $5.55   $7.40   $9.25   $11.10
//38  $3.80   $5.70   $7.60   $9.50   $11.40
//39  $3.90   $5.85   $7.80   $9.75   $11.70
//40  $4.00   $6.00   $8.00   $10.00   $12.00
//41  $4.10   $6.15   $8.20   $10.25   $12.30
//42  $4.20   $6.30   $8.40   $10.50   $12.60
//43  $4.30   $6.45   $8.60   $10.75   $12.90
//44  $4.40   $6.60   $8.80   $11.00   $13.20
//45  $4.50   $6.75   $9.00   $11.25   $13.50
//46  $4.60   $6.90   $9.20   $11.50   $13.80
//47  $4.70   $7.05   $9.40   $11.75   $14.10
//48  $4.80   $7.20   $9.60   $12.00   $14.40
//49  $4.90   $7.35   $9.80   $12.25   $14.70
//50  $5.00   $7.50   $10.00   $12.50   $15.00
//51  $5.10   $7.65   $10.20   $12.75   $15.30
//52  $5.20   $7.80   $10.40   $13.00   $15.60
//53  $5.30   $7.95   $10.60   $13.25   $15.90
//54  $5.40   $8.10   $10.80   $13.50   $16.20
//55  $5.50   $8.25   $11.00   $13.75   $16.50
//56  $5.60   $8.40   $11.20   $14.00   $16.80
//57  $5.70   $8.55   $11.40   $14.25   $17.10
//58  $5.80   $8.70   $11.60   $14.50   $17.40
//59  $5.90   $8.85   $11.80   $14.75   $17.70
//60  $6.00   $9.00   $12.00   $15.00   $18.00