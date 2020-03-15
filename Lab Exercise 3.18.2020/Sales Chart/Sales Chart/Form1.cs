//Lab Exercise 3.18.2020 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            //Declare variables
            int sales;
            string message, stars;

            //Create an array of TextBox objects
            TextBox[] mySales = new TextBox[] { txt1, txt2, txt3, txt4, txt5 };

            //Process each company with a for loop
            for (int company = 1; company <= 5; company++)
            {
                //Initialize stars to null string
                //Add code here


                //Get the sales from each mySales TextBox
                //Add code here

                
                //Add number of stars to the stars string based on the number of sales
                //One star per 100 in sales
                //Add code here


                //Generate message to add to lstSales items
                //Add code here


                //Add message to lstSales items
                //Add code here

            }
        }
    }
}
