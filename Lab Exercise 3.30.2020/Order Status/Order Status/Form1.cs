//Lab Exercise 3.30.2020
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call resetSpools
            resetSpools();
  
            //Call resetDelivery
            resetDelivery();

            //Set txtNumber and txtStock to ""
            txtNumber.Text = "";
            txtStock.Text = "";

            //Put Focus on txtNumber
            txtNumber.Focus();
        }

        private void resetSpools()
        {
            //Set txtNumber to null string and ckbRush to unchecked
            //Add code here

        }

        private void resetDelivery()
        {
            //set lblBackorder, lblShip, lblShipping, and lblTotal to null string
            //Add code here

        }

        private int getInstock()
        {
            //return contents of txtStock as an integer
            //Add code here

        }

        private int readyToShip(int spools, int inStock)
        {
            //This function returns the number of spools that are ready to ship
            //Hint: the amount to return is either spools or inStock
            int amount;
            //Add code here

            return amount;
        }

        private int backOrdered(int inStock, int spools)
        {
            //This function returns the number of spools that are backordered
            //Hint: the amount returned is either 0 or the difference between spools and inStock
            int amount;
            //Add code here

            return amount;
        }

        private int shippingCharges(int ready, int shipping)
        {
            //this function returns the shipping charges
            //Add code here

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare variables
            int spools, shipping, ready, backorder, total, inStock;

            //get the number of spools from txtNumber and store in spools as an integer
            //Add code here


            //Determine the per spool shipping charge and store in shipping
            //Hint: it is either 10 or 15 per spool depending on the status of ckbRush
            //Add code here


            //Call getInstock and store returned value in inStock
            inStock = getInstock();

            //Call readyToShip passing spools and inStock as parameters
            //Store returned value in ready
            //Add code here


            //Call backOrdered passing inStock and spools as parameters
            //Store returned value in backorder
            //Add code here


            //Call shippingCharges passing ready and shipping as parameters
            //Store returned value in shipping
            //Add code here


            //Calculate total cost to bill
            total = ready * 100 + shipping;

            //Output the results into lblShip, lblBackorder, lblShipping, and lblTotal
            //Add code here

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //This function prints the form to the default printer using the printForm1 control
            //Add code here

        }
    }
}
