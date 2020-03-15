//Lab Exercise 3.17.2020 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Temperature_Converter
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
            //Clear lstTemp items
            //Add code here

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Declare variables
            double f;
            string message;

            //Convert centigrade values from 0 to 20 to fahrenheit values
            for (int c = 0; c <= 20; c++)
            {
                //Calculate f value
                //Add code here


                //Build message to add to lstTemp items
                //Add code here


                //Add message to lstTemp items
                //Add code here

            }
        }
    }
}
