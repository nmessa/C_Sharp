//Lab Exercise 3.25.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Polynomial_Plotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            //Declare variables
            double[] x = new double[1001];
            double[] y = new double[1001];
            int ex;
            double x0, x1, x2, x3, x4;

            //If any TextBox is empty (contains "") assign "0" to TextBox
            if (txtX0.Text == "")
                txtX0.Text = "0";
            if (txtX1.Text == "")
                txtX1.Text = "0";
            if (txtX2.Text == "")
                txtX2.Text = "0";
            if (txtX3.Text == "")
                txtX3.Text = "0";
            if (txtX4.Text == "")
                txtX4.Text = "0";
            
            //Convert all TextBoxes Text to double and store in x0, x1, x2, x3, x4, and x5
            x0 = Convert.ToDouble(txtX0.Text);
            x1 = Convert.ToDouble(txtX1.Text);
            x2 = Convert.ToDouble(txtX2.Text);
            x3 = Convert.ToDouble(txtX3.Text);
            x4 = Convert.ToDouble(txtX4.Text);

            //Generate 1001 points at intervals of 0.02
            for (int i = 0; i <= 1000; i++)
            {
                ex = (i - 500) / 50;
                x[i] = ex;
                y[i] = x4 * Math.Pow(ex,  4) + x3 * Math.Pow(ex, 3) + x2 * ex * ex + x1 * ex + x0;
                chart1.Series[0].Points.AddXY(x[i], y[i]);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX0.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
            txtX3.Text = "";
            txtX4.Text = "";
            chart1.Series[0].Points.Clear();
            txtX4.Focus();
        }
    }
}
