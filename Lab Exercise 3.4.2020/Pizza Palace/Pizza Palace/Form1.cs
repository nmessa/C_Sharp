//Lab Exercise 3.4.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Palace
{
    public partial class Form1 : Form
    {
        const double dblSLICE = 14.125;

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
            txtDiameter.Text = "";
            lblSlices.Text = "";
            txtDiameter.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double diameter, area;
            int slices;
            diameter = Convert.ToDouble(txtDiameter.Text);
            area = Math.PI * Math.Pow(diameter / 2, 2);
            slices = Convert.ToInt32(area / dblSLICE);
            lblSlices.Text = slices.ToString();
        }
    }
}
