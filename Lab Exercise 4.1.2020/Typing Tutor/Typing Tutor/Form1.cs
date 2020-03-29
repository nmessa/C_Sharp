//Lab Exercise 4.1.2020
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Typing_Tutor
{
    public partial class Form1 : Form
    {
        int score;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Control the text on the Start button
            if (btnStart.Text == "Start")
            {
                //Set text to "Stop"
                //Add code here

                //Set the score to 0 and update score label
                //Add code here


                //Turn on the timer
                //Add code here


                //Set the focus to the textbox
                //Add code here

            }
            else
            {
                //set text to "Start"
                //Add code here


                //Turn of the timer
                //Add code here


                //put all of the labels back to top
                //Add code here

            }
        }

        private void txtEntry_TextChanged(object sender, EventArgs e)
        {
            //check for any text in textbox
            if (txtEntry.Text != "")
            {
                //Add code here

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
