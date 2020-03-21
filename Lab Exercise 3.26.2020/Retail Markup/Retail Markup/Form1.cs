//Lab Exercise 3.26.2020 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Retail_Markup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            displayRetail();
        }

        private void displayRetail()
        {
            //Declare variables
            double wholesale, retail, markup;

            //Get wholesale cost from txtWholesale TextBox
            //Add code here


            //Get markup from txtMarkup TextBox (be sure to convert percent to decimal)
            //Add code here


            //Calculate retail cost by multiplying wholesale cost by (1 + markup)
            //Add code here


            //Output retail cost to lblRetail as a currency string
            //Add code here

        }
    }
}
