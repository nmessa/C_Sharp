//Lab Exercise 3.31.2020 Problem 1
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Password_Verifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValid(string pw)
        {
            //Declare variables
            int length, count=0, count2=0;

            //Get Length of pw and store in length
            //Add code here



            //Check if password is long enough if not return false
            //Add code here


            //Check each character in pw string
            for (int i = 0 ; i < length; i++)
            {
                //if numeric add 1 to count
                //Add code here


                //if a letter add 1 to count2
                //Add code here

            }

            //if count and count2 are greater that 1 then valid and return true
            //else invalid and return false
            //Add code here

        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //Declare variable
            string password;

            //Get proposed password from txtPassword
            password = txtPassword.Text;

            //Reset txtPassword to null string
            txtPassword.Text = "";

            //Put Focus back on txtPassword
            txtPassword.Focus();

            //set lblValid to appropriate message it password is valid or not
            if (isValid(password))
                lblValid.Text = "Password is valid";
            else
                lblValid.Text = "Password is not valid";
        }
    }
}
