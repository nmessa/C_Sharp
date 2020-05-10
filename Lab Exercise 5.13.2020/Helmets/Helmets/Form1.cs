//Lab Exercise 5.13.2020 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Helmets
{
    public partial class Form1 : Form
    {
        //Global array to keep track of helmet status
        //Global array initialized to 0 in all elements
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            //Declare local variables
            //Add code here


            //Keep looping until you have bought 32 unique helmets
            while (total != 32)
            {
                //Buy a helmet (add 0.25 to amount)
                //Add code here


                //Find which helmet you bought
                //Add code here


                //Only increment if 0 in element
                //Add code here


                //Find the total of unique helmets you have purchased
                //Add code here

            }
            //Output the amount spent
            //Add code here


            //Reset array for next simulation
            //Add code here

        }

        //Adds up all of the elements
        //If the sum is 32 that means you have purchased one of each
        private int calcTotal()
        {
            //Declare and itiialize variable
            //Add code here


            //Add up the values in the array elements
            //Add code here


            return sum;
        }
    }
}
