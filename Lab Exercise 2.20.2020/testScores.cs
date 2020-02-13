using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestScores
{
    public partial class Form1 : Form
    {
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
            txtOne.Text = "";
            txtTwo.Text = "";
            txtThree.Text = "";
            txtFour.Text = "";
            txtFive.Text = "";
            lblAnswer.Text = "";
            txtOne.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int score1, score2, score3, score4, score5;
            double average;
            score1 = Convert.ToInt32(txtOne.Text);
            score2 = Convert.ToInt32(txtTwo.Text);
            score3 = Convert.ToInt32(txtThree.Text);
            score4 = Convert.ToInt32(txtFour.Text);
            score5 = Convert.ToInt32(txtOne.Text);
            average = (score1 + score2 + score3 + score4 + score5) / 5.0;
            lblAnswer.Text = average.ToString("F2");
        }
    }
}
