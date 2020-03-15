//Lab Exercise 3.16.2020 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Distance_Calculator
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables
            int speed, distance, hours;
            string message;

            //Get speed and hours from the txtSpeed and txtHours
            speed = Convert.ToInt32(txtSpeed.Text);
            hours = Convert.ToInt32(txtHours.Text);

            //Write heading to lstOutput
            lstOutput.Items.Add("Vehicle Speed: " + speed + " MPH");
            lstOutput.Items.Add("Time Traveled: " + hours + " hours");
            lstOutput.Items.Add("Hours:     Distance Traveled");
            lstOutput.Items.Add("____________________________");

            //Generate hours entries
            for (int hour = 1; hour <= hours; hour++)
            {
                //Calculate the distance traveled
                //Hint distance = rate * time
                //Add code here


                //Build a message to add to lstOutput
                //Add code here


                //Add the message to lstOutput
                //Add code here

            }
        }
    }
}
