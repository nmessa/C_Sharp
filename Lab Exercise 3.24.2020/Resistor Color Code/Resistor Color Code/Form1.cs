//Lab Exercise 3.24.2020 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Resistor_Color_Code
{
    public partial class Form1 : Form
    {
        //Global variables
        int digit1, digit2, tolerance;
        double multiplier;

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

        private void cboDigit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the digit 1 picture box and assign a value to digit 1
            //Add code here

        }

        private void cboDigit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the digit 2 picture box and assign a value to digit 2
            //Add code here

        }

        private void cboMultiplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the multiplier picture box and assign a value to the multiplier
            //Add code here

        }

        private void cboTolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the tolerance picture box and assign a value to the tolerance
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calcValue();
        }


        private void calcValue()
        {
            //this function will calculate the value of the resistor and place the value in the label
            //Add code here

        }
    }
}
