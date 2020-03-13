//Lab Exercise 3.3.2020 Problem 2
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Currency_Converter
{
    public partial class Form1 : Form
    {
        const double dblYEN_FACTOR = 110.81;
        const double dblEURO_FACTOR = 0.88;
        const double dblPOUND_FACTOR = 0.76;
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
            txtDollars.Text = "";
            txtDollars.Focus();
            lblEuros.Text = "";
            lblPounds.Text = "";
            lblYen.Text = "";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double dollars, pounds, euros, yen;
            dollars = Convert.ToDouble(txtDollars.Text);
            pounds = dollars * dblPOUND_FACTOR;
            euros = dollars * dblEURO_FACTOR;
            yen = dollars * dblYEN_FACTOR;
            lblEuros.Text = euros.ToString("c", CultureInfo.CreateSpecificCulture("de-DE"));
            lblPounds.Text = pounds.ToString("c", CultureInfo.CreateSpecificCulture("en-GB"));
            lblYen.Text = yen.ToString("c", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
    }
}
