//Lab Exercise 3.23.2020
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Jackson_Pollack
{
    public partial class Form1 : Form
    {
        //Create global random number generator object
        Random r = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            //Hide form controls
            lblShapes.Visible = false;
            txtShapes.Visible = false;
            ckbPrint.Visible = false;
            btnDraw.Visible = false;

            //Declare local variables
            int intTimes, rShape, rX, rY, rWidth, rHeight, rColor, index;
            bool printPainting = false;

            //Create a white graphics surface to draw on
            Graphics FormSurface = CreateGraphics();
            FormSurface.Clear(Color.White);

            //Get the number of shapes to draw
            intTimes = Convert.ToInt32(txtShapes.Text);

            //Create drawing objects
            Pen myPen =  new Pen(Color.Red, 5);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Color myColor = new Color();

            //Create the shapes
            for (index = 1; index <= intTimes; index++)
            {
                //pick randon shape, color, location, 
                rShape = r.Next(1,5);
                rColor = r.Next(1,5);
                rX = r.Next(0, 800);
                rY = r.Next(0, 800);
                rWidth = r.Next(100,300);
                rHeight = r.Next(100, 300);
                switch (rColor)
                {
                    case 1:
                        myColor = Color.Red;
                        break;
                    case 2:
                        myColor = Color.Green;
                        break;
                    case 3:
                        myColor = Color.Blue;
                        break;
                    case 4:
                        myColor = Color.Yellow;
                        break;
                    case 5:
                        myColor = Color.Orange;
                        break;
                }

                myPen.Color = myColor;
                myBrush.Color = myColor;
                switch (rShape)
                {
                    case 1:
                        FormSurface.DrawLine(myPen, rX, rY, rX + rWidth, rY + rHeight);
                        break;
                    case 2:
                        FormSurface.DrawEllipse(myPen, rX, rY, rWidth, rHeight);
                        break;
                    case 3:
                        FormSurface.DrawRectangle(myPen, rX, rY, rWidth, rHeight);
                        break;
                    case 4:
                        FormSurface.FillRectangle(myBrush, rX, rY, rWidth, rHeight);
                        break;
                    case 5:
                        FormSurface.FillEllipse(myBrush, rX, rY, rWidth, rHeight);
                        break;
                }
            }

            //Check if print desired
            if (ckbPrint.Checked)
                printPainting = true;

            //Send image to default printer
            if (printPainting)
                printForm1.Print();

            //Pause program for 5 seconds
            Thread.Sleep(5000);

            //Restore the form to it's starting state
            btnDraw.Visible = true;
            lblShapes.Visible = true;
            txtShapes.Visible = true;
            ckbPrint.Visible = true;
            ckbPrint.Checked = false;
            txtShapes.Text = "";
            txtShapes.Focus();
            FormSurface.Clear(Color.White);
        }
    }
}
