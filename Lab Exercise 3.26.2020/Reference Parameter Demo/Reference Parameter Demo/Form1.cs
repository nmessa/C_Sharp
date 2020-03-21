//Reference parameter passing demo
//Author: nmessa
//Date: 3/19/2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reference_Parameter_Demo
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            lblTotal.Text = "";
            txtNum1.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, total=0;
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            num3 = Convert.ToInt32(txtNum3.Text);
            addEmUp(num1, num2, num3, ref total);
            lblTotal.Text = total.ToString();
        }

        void addEmUp(int n1, int n2, int n3, ref int tot)
        {
            tot = n1 + n2 + n3;
        }
    }
}
