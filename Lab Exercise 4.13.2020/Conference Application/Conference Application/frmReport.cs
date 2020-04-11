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
    public partial class frmReport : Form
    {
        //Form constructor that recieves value parameters from main form
        public frmReport(TextBox txtName ,TextBox txtAddress, TextBox txtCity, TextBox txtState, 
            TextBox txtZip, TextBox txtPhone, TextBox txtEmail, TextBox txtCompany, 
            Label lblTotal, string workshop)
        {
            InitializeComponent();

            //Put all information passed to this form into the report fields for printing
            lblName.Text = txtName.Text;
            lblAddress.Text = txtAddress.Text;
            lblCity.Text = txtCity.Text;
            lblState.Text = txtState.Text;
            lblZIP.Text = txtZip.Text;
            lblPhone.Text = txtPhone.Text;
            lblEmail.Text = txtEmail.Text;
            lblCompany.Text = txtCompany.Text;
            lblWorkshop.Text = workshop;
            lblCost.Text = lblTotal.Text;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
