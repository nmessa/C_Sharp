//Lab Exercise 3.31.2020 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Falling
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
            //set txtTime and lblDistance to ""
            //Add code here


            //put Focus on txtTime
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables
            int t;
            double distance;

            //Get falling time from txtTime and store in t as an integer
            //Add code here


            //Call fallingDistance with t as a parameter
            //Store returned value in distance
            distance = fallingDistance(t);

            //Output the distance to lblDistance to 2 decimal places
            //Add code here

        }

        private double fallingDistance(int t)
        {
            //Declare variables
            const double G = 9.81;
            double dist;

            //Calculate falling distance and store in dist
            //Add code here


            //return the distance
            return dist;
        }
    }
}
