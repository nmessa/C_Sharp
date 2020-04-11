using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class frmSecond : Form
    {
        public frmSecond()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //declare variables
            double num1, num2;

            //Get data from textboxes
            num1 = Convert.ToDouble(txtFirst.Text);
            num2 = Convert.ToDouble(txtSecond.Text);

            //Send data back to frmMain
            frmMain.number1 = num1;
            frmMain.number2 = num2;

            //Close the form
            this.Close();
        }
    }
}
