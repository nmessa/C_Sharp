//Lab Exercise 4.27.2020 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rainfall_Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Declare variables including a 12 element array of strings to hold the names of months
            //and a 12 element integer array to hold monthly rainfall totals
            //This is an example of parallel arrays
            //Add code here


            //Create a random number generator
            //Add code here


            //Generate data and store in arrays as well as ListBox
            //Add code here



            //Find total rainfall
            //Add code here



            //Find the average rainfall
            //Add code here


            //Find the max rainfall
            //Add code here



            //Find the min rainfall
            //Add code here


            //Put values in labels
            //Add code here


        }
    }
}
