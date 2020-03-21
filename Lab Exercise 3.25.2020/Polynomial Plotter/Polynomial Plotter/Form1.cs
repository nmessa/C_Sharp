//Lab Exercise 3.25.2020 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polynomial_Plotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            //Declare variables
            //Add code here


            //If any TextBox is empty (contains "") assign "0" to TextBox
            //Add code here

            
            //Convert all TextBoxes Text to double and store in x0, x1, x2, x3, x4, and x5
            //Add code here


            //Generate 1001 points at intervals of 0.02
            //Add code here

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
