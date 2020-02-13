using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace State_Abbreviatiom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVA_Click(object sender, EventArgs e)
        {
            lblState.Text = "VA";
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            lblState.Text = "NC";
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            lblState.Text = "SC";
        }

        private void btnGA_Click(object sender, EventArgs e)
        {
            lblState.Text = "GA";
        }

        private void btnAL_Click(object sender, EventArgs e)
        {
            lblState.Text = "AL";
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            lblState.Text = "FL";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
