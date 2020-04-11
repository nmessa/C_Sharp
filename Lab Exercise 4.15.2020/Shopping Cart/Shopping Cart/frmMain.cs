//Lab Exercise 4.15.2020
//Author: 
//frmMain.cs

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class frmMain : Form
    {
        //Create variables shared with other forms
        //Add code here


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Declare local variables
            //Add code here


            //Get index of product to remove
            //Add code here


            //Get cost of item to remove
            //Add code here
 

            //Remove item from lstProdcuts
            //Add code here


            //Remove item from lstCost
            //Add code here


            //Decrement number of items in cart
            //Add code here


            //subtract cost from subtotal
            //Add code here


            //recalculate shipping cost
            //Add code here


            //recalculate tax
            //Add code here


            //recalculate total
            //Add code here


            //Update labels
            //Add code here

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void PrintBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Construct a new form print
            //Add code here


            //Declare variables
            //Add code here


            //display new form
            //Add code here


            //Add item to lstProducts
            //Add code here


            //Add cost to lstCost
            //Add code here


            //calculate shipping cost
            //Add code here


            //calculate tax
            //Add code here


            //Calculate total
            //Add code here


            //Put values in labels
            //Add code here

        }

        private void AudioBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Construct a new form audio
            //Add code here


            //Declare variables
            //Add code here


            //display new form
            //Add code here


            //Add item to lstProducts
            //Add code here


            //Add cost to lstCost
            //Add code here


            //calculate shipping cost
            //Add code here


            //calculate tax
            //Add code here


            //calculate total
            //Add code here


            //Put values in labels
            //Add code here

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
