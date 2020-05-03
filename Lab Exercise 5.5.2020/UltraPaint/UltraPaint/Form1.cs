//Lab Exercise 5.5.2020
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UltraPaint
{
    public partial class Form1 : Form
    {
        //Declare global variables
        //Add code here


        //nullable int variables capable storing null value
        //Add code here


        //Constructor
        public Form1()
        {
            InitializeComponent();

            //Create graphics object at same location as pbDraw
            //Add code here


            //Create Bitmap object same size as as pbDraw
            //Add code here


            //Associate bitmap object with picturebox
            //Add code here

        }

        //Button for Setting pen Color
        private void btnPenColor_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of btnPenColor if user clicks on OK
            //Add code here


        }

        //Button for setting the Canvas Color
        private void btnCanvasColor_Click(object sender, EventArgs e)
        {
            //Open Color Dialog and Set BackColor of canvas (pbDraw) if user clicks on OK
            //Add code here


        }

        //Event Fired when the mouse pointer is over Picturebox and a mouse button is pressed
        private void pbDraw_MouseDown(object sender, MouseEventArgs e)
        {
            //Add code here

        }

        //Event fired when the mouse pointer is moved over the Picturebox(pbDraw).
        private void pbDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                //Setting the Pen BackColor and line Width
                //Add code here


                //Associate graphics object to bitmap
                //Add code here


                //Drawing the line.
                //Add code here


                //Copy bitmap to picturebox
                //Add code here


                //set beginning point for next line
                //Add code here

            }
        }

        //Fired when the mouse pointer is over the ppbDraw and a mouse button is released.
        private void pbDraw_MouseUp(object sender, MouseEventArgs e)
        {
            //Add code here

        }

        //New canvas
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clearing the graphics from the picturebox(pbDraw)
            //Add code here


            //Create graphics object from bitmap
            //Add code here


            //Setting the BackColor of pbDraw and btnCanvasColor to White on Clicking New under File Menu
            //Add code here


            //Color all pixels in the bitmap with background color
            //Add code here


            //Associate picturebox image with bitmap
            //Add code here

        }

        //Save image
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //Open image
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //About under Help Menu
        private void aboutUltraPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        
        

        

        

        

        

        

        

        

        

        

        

        


    }
}
