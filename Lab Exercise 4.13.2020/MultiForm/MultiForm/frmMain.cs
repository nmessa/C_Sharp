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
    public partial class frmMain : Form
    {
        public static double number1;
        public static double number2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewForm_Click(object sender, EventArgs e)
        {
            frmSecond second = new frmSecond();
            second.ShowDialog();
            lblFirst.Text = number1.ToString();
            lblSecond.Text = number2.ToString();
        }
    }
}
