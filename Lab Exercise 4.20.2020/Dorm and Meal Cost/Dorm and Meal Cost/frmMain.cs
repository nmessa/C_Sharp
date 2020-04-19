//Lab Exercise 4.20.2020 
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dorm_and_Meal_Cost
{
    public partial class frmMain : Form
    {
        //Global variables shared with other forms
        //Add code here


        //Global Variable
        //Add code here

        public frmMain()
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        //This function generates the student ID
        private void btnGen_Click(object sender, EventArgs e)
        {
            //Declare variables
            string first, last, studentID;
            int m, d, y, sum1, sum2;
            Int64 number;  //Need 64 bit integer


            //Get data from text boxes
            //Add code here


            //Initialize sum1 and sum2 to 0
            //Add code here


            //Add all of the letter ASCII values for first name
            //Add code here


            //Add all of the letter ASCII values for last name
            //Add code here

           
            //Calculate the number
            //Add code here


            //Convert number to a string
            //Add code here


            //Put student ID in label
            //Add code here


            //Disable the Generate Student ID button
            //Add code here

        }

        //This function will allow dorm selection
        private void btnDorm_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        //This function will allow meal plan selection
        private void btnMeal_Click(object sender, EventArgs e)
        {
            //Add code here

        }


        //This function will will dynamically populate cboMajor based on cboCollege selection
        private void cboCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will display the major, hide cboMajor, and display lblMajor
        private void cboMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
