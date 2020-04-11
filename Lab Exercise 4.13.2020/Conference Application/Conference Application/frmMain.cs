//Lab Exercise 4.13.2020
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conference_Application
{
    public partial class frmMain : Form
    {
        //Global variables shared with other forms
        //Add code here


        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Create a new form that generates a report to be printed
            //Add code here

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //Create a new form that allows selection of conference options
            //Add code here

        }
    }
}
