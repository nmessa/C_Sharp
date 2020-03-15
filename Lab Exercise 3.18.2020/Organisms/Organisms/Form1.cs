//Lab Exercise 3.18.2020 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Organisms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //declare variables
            double start, increase, population;
            int days, day;
            string message = "";

           //get input cboStart and store in start - this is a ComboBox and is similar to a TextBox
            //except that it has a dropdown
            //You can think of it as a combination TextBox and ListBox
            //Add code here

            //Get the percentage to increase from txtIncrease
            //Don't forget to convert the percent to a decimal value by dividing by 100.0
            //Add code here


            //Get the number of days growth has been growing from cboGrowth
            //Add code here


           //calculate population and generate output message
            //Initialize population to start
            //Add code here


            //Process each day with a for loop
            for (day = 1; day < days; day++)
            {
                //Build message to put in MessageBox
                //Notice that this message ends in a newline character
                //What does that do?
                message += "Day " + day + " Population = " + population.ToString("n2") + " million" + "\n";

                //Calculate new population (multiply current population by (1 + the increase)
                //Add code here

            }
            //Why is this message not in the loop?
            message += "Day " + day + " Population = " + population.ToString("n2") + " million" + "\n";

            //output result to MessageBox
            //Add code here


            //Output the final population into lblPop
            //Add code here


        }
    }
}
