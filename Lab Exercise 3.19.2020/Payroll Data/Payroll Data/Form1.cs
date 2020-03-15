//Lab Exercise 3.19.2020
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_Data
{
    public partial class Form1 : Form
    {
        //Create global variable count
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            //Clear the items in lstOutput
            //Add code here


            //reset count to 0
            //Add code here


            //Enable btnAdd
            //Add code here

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Declare variables
            string name, message;
            int hours;
            double fed, med, ss, state, rate, pay, takeHome;
            double fedTax, stateTax, ssTax, medTax;

            //Get data from ComboBoxes and TextBoxes, convert to double and divide
            //percentages by 100 store in name, fed, hours, med, ss, state, rate as doubles
            //Add code here


            //calculate pay, fedTax, stateTax, ssTax, medTax, and takeHome
            //Add code here



            //Generate report and put in lstOutput
            message = "Name: " + name;
            lstOutput.Items.Add(message);
            message = "Hours worked: " + hours;
            lstOutput.Items.Add(message);
            message = "Hourly rate: " + rate.ToString("c");
            lstOutput.Items.Add(message);
            message = "Gross Pay: " + pay.ToString("c");
            lstOutput.Items.Add(message);
            message = "Federal Income Tax withheld: " + fedTax.ToString("c");
            lstOutput.Items.Add(message);
            message = "State Income Tax withheld: " + stateTax.ToString("c");
            lstOutput.Items.Add(message);
            message = "Social Security Tax withheld: " + ssTax.ToString("c");
            lstOutput.Items.Add(message);
            message = "Medicare Tax withheld: " + medTax.ToString("c");
            lstOutput.Items.Add(message);
            message = "Net Pay: " + takeHome.ToString("c");
            lstOutput.Items.Add(message);
            lstOutput.Items.Add("");

            //add one to count
            //Add code here


            //if all employees processed (count = 4), disable add employee button
            //Add code here


        }
    }
}
