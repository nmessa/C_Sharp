using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Math_Tutor_2
{
    public partial class Form1 : Form
    {
        int num1, num2;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            num1 = r.Next(10);
            num2 = r.Next(10);
            lblAnswer.Text = num1 + " + " + num2 + " = ?";
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = num1 + " + " + num2 + " = " + (num1 + num2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
