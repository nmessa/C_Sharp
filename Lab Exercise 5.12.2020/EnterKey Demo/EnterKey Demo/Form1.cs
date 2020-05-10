using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnterKey_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtOperand2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double number1 = Convert.ToDouble(txtOperand1.Text);
                double number2 = Convert.ToDouble(txtOperand2.Text);
                char op = cboOperator.SelectedItem.ToString()[0];
                switch (op)
                {
                    case '+':
                        lblAnswer.Text = (number1 + number2).ToString();
                        break;
                    case '-':
                        lblAnswer.Text = (number1 - number2).ToString();
                        break;
                    case 'x':
                        lblAnswer.Text = (number1 * number2).ToString();
                        break;
                    case '/':
                        lblAnswer.Text = (number1 / number2).ToString();
                        break;
                }
            }
        }

        
    }
}
