using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                label1.Text = "Left";
            else if (e.KeyCode == Keys.Right)
                label1.Text = "Right";
            else if (e.KeyCode == Keys.Up)
                label1.Text = "Up";
            else if (e.KeyCode == Keys.Down)
                label1.Text = "Down";
        }
    }
}
