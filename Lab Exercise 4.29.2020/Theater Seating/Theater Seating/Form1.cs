//Lab Exercise 4.29.2020
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theater_Seating
{
    public partial class Form1 : Form
    {
        //Declare 2D array of 15x30 characters
        //Add code here

        
        public Form1()
        {
            InitializeComponent();
        }

        //Note: Environment.NewLine inserts the \n character
        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "";

            //Build the row number message
            //Add code here


            //Fill the 2D array with '-' characters
            //Add code here


            //Display the array
            //Add code here

        }

        private void display()
        {
            //Add code here

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //Declare variables
            //Add code here


            //Get row and column from textboxes
            //Add code here


            //Check to see if seat already reserved
            //If already taken display message box and leave function
            //Add code here


            //Assign reserved character to array (!)
            //Add code here


            //Display the array
            //Add code here


            //Reset the textboxes and put focus on first textbox
            //Add code here


        }
    }
    
}
