//Lab Exercise 3.3.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Widget
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
            txtGross.Text = "";
            txtTare.Text = "";
            lblWidgets.Text = "";
            txtGross.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int gross, tare, widgets;
            gross = Convert.ToInt32(txtGross.Text);
            tare = Convert.ToInt32(txtTare.Text);
            widgets = Convert.ToInt32((gross - tare) / 9.2);
            lblWidgets.Text = widgets.ToString();
        }
    }
}
