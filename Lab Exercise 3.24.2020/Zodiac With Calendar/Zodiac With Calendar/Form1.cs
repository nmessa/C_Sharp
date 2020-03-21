//Lab Exercise 3.24.2020 Problem 3
//Author: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zodiac_With_Calendar
{
    public partial class Form1 : Form
    {
        //define dates

        DateTime startAqarius = new DateTime(DateTime.Now.Year, 1, 20);
        DateTime endAqarius = new DateTime(DateTime.Now.Year, 2, 18);
        DateTime startPisces = new DateTime(DateTime.Now.Year, 2, 19);
        DateTime endPisces = new DateTime(DateTime.Now.Year, 3, 20);
        DateTime startAries = new DateTime(DateTime.Now.Year, 3, 21);
        DateTime endAries = new DateTime(DateTime.Now.Year, 4, 19);
        DateTime startTaurus = new DateTime(DateTime.Now.Year, 4, 20);
        DateTime endTaurus = new DateTime(DateTime.Now.Year, 5, 20);
        DateTime startGemini = new DateTime(DateTime.Now.Year, 5, 21);
        DateTime endGemini = new DateTime(DateTime.Now.Year, 6, 20);
        DateTime startCancer = new DateTime(DateTime.Now.Year, 6, 21);
        DateTime endCancer = new DateTime(DateTime.Now.Year, 7, 22);
        DateTime startLeo = new DateTime(DateTime.Now.Year, 7, 23);
        DateTime endLeo = new DateTime(DateTime.Now.Year, 8, 22);
        DateTime startVirgo = new DateTime(DateTime.Now.Year, 8, 23);
        DateTime endVirgo = new DateTime(DateTime.Now.Year, 9, 22);
        DateTime startLibra = new DateTime(DateTime.Now.Year, 9, 23);
        DateTime endLibra = new DateTime(DateTime.Now.Year, 10, 22);
        DateTime startScorpio = new DateTime(DateTime.Now.Year, 10, 23);
        DateTime endScorpio = new DateTime(DateTime.Now.Year, 11, 21);
        DateTime startSagittarius = new DateTime(DateTime.Now.Year, 11, 23);
        DateTime endSagittarius = new DateTime(DateTime.Now.Year, 12, 21);
        DateTime startCapricorn = new DateTime(DateTime.Now.Year, 12, 22);
        DateTime endCapricorn = new DateTime(DateTime.Now.Year+1, 1, 19);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add code here

        }
    }
}
