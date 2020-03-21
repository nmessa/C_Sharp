//Lab Exercise 3.25.2020 Problem 1
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sin_Plotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            double[] x = new double[360];
            double[] y = new double[360];
            double[] y2 = new double[360];

            for (int i = 0; i <= 359; i++)
            {
                x[i] = Convert.ToDouble((i * Math.PI / 180).ToString("f2"));
                y[i] = Math.Sin(x[i]);
                chart1.Series[0].Points.AddXY(x[i], y[i]);
                y2[i] = Math.Cos(x[i]);
                chart1.Series[1].Points.AddXY(x[i], y2[i]);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
