//Lab Exercise 3.17.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hotel_Occupanncy
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
            //Add code here

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //Declare variables
            int totalRooms=0, floorRooms;
            double rate, floorRate;
            string message;

            //Create an array of TextBox objects
            TextBox[] floors = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8 };

            //Process each floor from 1 to 8
            for (int floor = 1; floor <= 8; floor++)
            {
                //Get the number of floors used on a single floor
                //Make sure you understand how this line works
                //Why do we subtract 1 from floor before indexing into the floors array
                floorRooms = Convert.ToInt32(floors[floor-1].Text);

                //Calculate the percentage of rooms (floorRate) used on a floor
                //Add code here


                //Build a message to add to lstData items
                message = "Floor " + floor + " Rooms occupied: " + floorRooms + " Occupancy Rate: " + 
                    floorRate.ToString("f2") + "%";

                //Add message to lstData items
                //Add code here


                //add floorRooms to totalRooms
                //Add code here


                //reset floorRooms to 0 in preparation for next floor
                //Add code here

            }
                
            //Calculate the total usage rate of the entire hotel
            //Add code here


            //Output totalRooms to lblRooms
            //Add code here


            //Output rate to lblRate
            //Add code here

        }
    }
}
