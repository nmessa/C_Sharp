//Lab Exercise 5.6.2020
//Author: nmessa

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Word_Processor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize the RichTextBox to null string
            RichTextBox1.Text = "";

            //Set the text on the form header
            //Add code here

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File Open
            //Add code here

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File Save
            //Add code here

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exit
            //Add code here

        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Font
            //Add code here

        }

        private void CapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Convert to all caps
            //Add code here

        }

        private void CenterJustifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Center Justify
            //Add code here

        }

        private void LeftJustifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Left Justify
            //Add code here

        }

        private void RightJustifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Right Justify
            //Add code here

        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copy
            //Add code here

        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Paste
            //Add code here

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cut
            //Add code here

        }

        private void FontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Font Color
            //Add code here

        }

        private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Background Color
            //Add code here

        }

        //This function displays a MessageBox which displays the number of words in the document
        private void WordCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare variables
            //Add code here


            //Store document text in the string words
            //Add code here


            //Pass string to function wordCount2 which returns how many words are in the text
            //Add code here


            //Build a message
            //Add code here


            //Output the message
            //Add code here

        }

        //Method 1 for determining word count
        //counts the spaces and adds 1
        private int wordCount(string w)
        {
            //Add code here

        }

        //Method 2 for determining word count
        //split the string by spaces and find length of array
        private int wordCount2(string w)
        {
            //Add code here

        }

        //
        private void GradeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare variables
            //Add code here


            //store words in the document
            //Add code here


            //find the number of words by calling wordCount2 or wordCount
            //Add code here


            //Calculate the average word length
            //after spaces removed
            //Add code here
  

            //determine grade level
            //Add code here
  

            //Display information in a message box showing the average word length and the grade level
            //Add code here
  
        }

        private string grade(double avg)
        {
            //Add code here
  
        }

        private void sentenceCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add code here
  

        }

        //returns the number of sentences by counting punctuations
        public int sentenceCount(string w)
        {
            //Add code here
  

        }
    }
}
