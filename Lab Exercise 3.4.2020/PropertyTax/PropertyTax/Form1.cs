//Lab Exercise 3.4.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PropertyTax
{
    public partial class Form1 : Form
    {
        const double dblMIL_RATE = 6.4;
        const double dblFACTOR = 0.6;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
            lblTax.Text = "";
            lblValue.Text = "";
            txtValue.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double market, value, tax;
            market = Convert.ToDouble(txtValue.Text);
            value = market * dblFACTOR;
            tax = (value / 1000) * dblMIL_RATE;
            lblValue.Text = value.ToString("c");
            lblTax.Text = tax.ToString("c");
        }
    }
}
