//Lab Exercise 3.9.2020 Problem 2
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISP
{
    public partial class Form1 : Form
    {
        const double dblDiscount = 0.2;

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
            //Declare variables
            int hours;
            double total = 0, discount;

            //Find discount
            //Add code here



            //get hours from user
            hours = Convert.ToInt32(txtHours.Text);

            //determine bill
            //Add code here



            //Output bill
            //Add code here

        }
    }
}
