//Lab Exercise 4.28.2020
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Drivers_License_Exam
{
    public partial class Form1 : Form
    {
        int numCorrect = 0;
        int valid = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset the array of ComboBoxes
            //Add code here


            //Reset the state of all ComboBoxes
            //Add code here



            //Reset variables and controls
            //Add code here


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            //Create an array of Comboboxes
            //Add code here

            
            //Define an array to hold the answer key
            //Add code here


            //traverse the combobox array
            for (int index = 0; index <= 19; index++)
            {
                //check if answer is valid
                if (scores[index].Text != "")
                {
                    //Add code here

                }
                else
                    //Add code here


                //Check if valid answer is correct
                if (scores[index].Text == correct[index])
                {
                    //Add code here


                }
                //check if answer is wrong
                else
                {
                    //Add code here

                }
            }

            //check for all questions answered
            if (valid == 20)
            {
                //check for pass
                if (numCorrect >= 15)
                    //Add code here

                //check for fail
                else
                    //Add code here

                //Disable btnScore
                //Add code here

            }
            else
            {
                //Add code here

            }
       }
    }
}
