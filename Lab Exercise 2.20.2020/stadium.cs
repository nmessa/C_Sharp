using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Stadium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lblA.Text = "";
            lblB.Text = "";
            lblC.Text = "";
            lblTotal.Text = "";
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numA, numB, numC;
            double revA, revB, revC, revTotal;
            numA = Convert.ToInt32(txtA.Text);
            numB = Convert.ToInt32(txtB.Text);
            numC = Convert.ToInt32(txtC.Text);
            revA = numA * 15.0;
            revB = numB * 12.0;
            revC = numC * 9.0;
            revTotal = revA + revB + revC;
            lblA.Text = revA.ToString("c");
            lblB.Text = revB.ToString("c");
            lblC.Text = revC.ToString("c");
            lblTotal.Text = revTotal.ToString("c");
        }
    }
}
