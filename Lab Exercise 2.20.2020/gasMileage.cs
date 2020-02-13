using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gas_Mileage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double gallons, miles, mpg;
            gallons = Convert.ToDouble(txtGallons.Text);
            miles = Convert.ToDouble(txtMiles.Text);
            mpg = miles / gallons;
            lblMPG.Text = mpg.ToString("f2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGallons.Text = "";
            txtMiles.Text = "";
            lblMPG.Text = "";
            txtMiles.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
