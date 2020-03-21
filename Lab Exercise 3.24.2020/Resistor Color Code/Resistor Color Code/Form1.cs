//Lab Exercise 3.24.2020 Problem 1
//Author: nmessa

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
            cboDigit1.Text = "";
            cboDigit2.Text = "";
            cboMultiplier.Text = "";
            cboTolerance.Text = "";
            lblValue.Text = "";
            lblTolerance.Text = "";
            pbDigit1.BackColor = Color.LightGray;
            pbDigit2.BackColor = Color.LightGray;
            pbMultiplier.BackColor = Color.LightGray;
            pbTolerance.BackColor = Color.LightGray;
        }

        private void cboDigit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the digit 1 picture box and assign a value to digit 1
            digit1 = cboDigit1.SelectedIndex;
            switch (cboDigit1.SelectedIndex)
            {
                case 0:
                    pbDigit1.BackColor = Color.Black;
                    break;
                case 1:
                    pbDigit1.BackColor = Color.Brown;
                    break;
                case 2:
                    pbDigit1.BackColor = Color.Red;
                    break;
                case 3:
                    pbDigit1.BackColor = Color.Orange;
                    break;
                case 4:
                    pbDigit1.BackColor = Color.Yellow;
                    break;
                case 5:
                    pbDigit1.BackColor = Color.Green;
                    break;
                case 6:
                    pbDigit1.BackColor = Color.Blue;
                    break;
                case 7:
                    pbDigit1.BackColor = Color.Violet;
                    break;
                case 8:
                    pbDigit1.BackColor = Color.Gray;
                    break;
                case 9:
                    pbDigit1.BackColor = Color.White;
                    break;
            }
        }

        private void cboDigit2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the digit 2 picture box and assign a value to digit 2
            digit2 = cboDigit2.SelectedIndex;
            switch (cboDigit2.SelectedIndex)
            {
                case 0:
                     pbDigit2.BackColor = Color.Black;
                     break;
                case 1:
                     pbDigit2.BackColor = Color.Brown;
                     break;
                case 2:
                    pbDigit2.BackColor = Color.Red;
                     break;
                case 3:
                     pbDigit2.BackColor = Color.Orange;
                     break;
                case 4:
                     pbDigit2.BackColor = Color.Yellow;
                     break;
                case 5:
                     pbDigit2.BackColor = Color.Green;
                     break;
                case 6:
                     pbDigit2.BackColor = Color.Blue;
                     break;
                case 7:
                     pbDigit2.BackColor = Color.Violet;
                     break;
                case 8:
                     pbDigit2.BackColor = Color.Gray;
                     break;
                case 9:
                     pbDigit2.BackColor = Color.White;
                     break;
            }
        }

        private void cboMultiplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the multiplier picture box and assign a value to the multiplier
            multiplier = Math.Pow(10, cboMultiplier.SelectedIndex);
            switch (cboMultiplier.SelectedIndex)
            {
                case 0:
                    pbMultiplier.BackColor = Color.Black;
                    break;
                case 1:
                    pbMultiplier.BackColor = Color.Brown;
                    break;
                case 2:
                    pbMultiplier.BackColor = Color.Red;
                    break;
                case 3:
                    pbMultiplier.BackColor = Color.Orange;
                    break;
                case 4:
                    pbMultiplier.BackColor = Color.Yellow;
                    break;
                case 5:
                    pbMultiplier.BackColor = Color.Green;
                    break;
                case 6:
                    pbMultiplier.BackColor = Color.Blue;
                    break;
                case 7:
                    pbMultiplier.BackColor = Color.Violet;
                    break;
                case 8:
                    pbMultiplier.BackColor = Color.Gray;
                    break;
                case 9:
                    pbMultiplier.BackColor = Color.White;
                    break;
                case 10:
                    pbMultiplier.BackColor = Color.Gold;
                    multiplier = Math.Pow(10, -1);
                    break;
                case 11:
                    pbMultiplier.BackColor = Color.Silver;
                    multiplier = Math.Pow(10, -2);
                    break;
            }
        }

        private void cboTolerance_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this procedure will paint the tolerance picture box and assign a value to the tolerance
            switch (cboTolerance.SelectedIndex)
            {
                case 0:
                    pbTolerance.BackColor = Color.Gold;
                    tolerance = 5;
                    break;
                case 1:
                    pbTolerance.BackColor = Color.Silver;
                    tolerance = 10;
                    break;
                case 2:
                    pbTolerance.BackColor = Color.LightGray;
                    tolerance = 20;
                    break;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            calcValue();
        }


        private void calcValue()
        {
            //this function will calculate the value of the resistor and place the value in the label
            double value;
            value = (10 * digit1 + digit2) * multiplier;
            if (value > 1000000000.0)
                lblValue.Text = (value / 1000000000.0).ToString() + " G Ohms";
            else if (value > 1000000.0)
                lblValue.Text = (value / 1000000.0).ToString() + " M Ohms";
            else if (value > 1000.0)
                lblValue.Text = (value / 1000.0).ToString() + " K Ohms";
            else
                lblValue.Text = value.ToString() + " Ohms";

            lblTolerance.Text = tolerance + "%";
        }
    }
}
