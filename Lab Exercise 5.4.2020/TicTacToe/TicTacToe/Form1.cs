//Lab Exercise 5.4.2020
//Author: 
//A Tic Tac Toe Game

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        //Declare global variables
        //These are all flag variables
        //if player is true then it is playerX turn
        //if player is false the it is playerO turn
        //disabled1 to disabled9 keep track of the state of the 9 buttons
        //Add code here


        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Set initial player state
            //Add code here


            //Reset disabled flags
            //Add code here


            //Enable all buttons
            //Add code here


            //Reset all button text
            //Add code here



            //Reset the winner label
            //Add code here

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize all global variables
            //Add code here

        }

        //This function calls playerX_Win and playerO_Win to see if a winner exists
        private void checkWin()
        {
            //Add code here


        }

        //This function disables all buttons to prevent further play
        private void lockCells()
        {
            //Add code here


        }

        //This function checks to see if playerX has won
        //There are 8 ways to win and we need to check them all
        //Check 3 rows, 3 columns, and 2 diagonals
        //If a win occurs, lock the cells to prevent further play
        private void playerX_Win()
        {
            //Add code here



        }

        //This function checks to see if playerO has won
        //There are 8 ways to win and we need to check them all
        //Check 3 rows, 3 columns, and 2 diagonals
        //If a win occurs, lock the cells to prevent further play
        private void playerO_Win()
        {
            //Add code here


        }

        //This function will put an X or O in btnLeftUpper Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled1 flag
        private void btnLeftUpper_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnMiddleUpper Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled2 flag
        private void btnMiddleUpper_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnRightUpper Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled3 flag
        private void btnRightUpper_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnLeftMiddle Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled4 flag
        private void btnLeftMiddle_Click(object sender, EventArgs e)
        {
            //Add code here

        }

        //This function will put an X or O in btnMiddleMiddle Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled5 flag
        private void btnMiddleMiddle_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnRightMiddle Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled6 flag
        private void btnRightMiddle_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnLeftLower Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled7 flag
        private void btnLeftLower_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnMiddleLower Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled8 flag
        private void btnMiddleLower_Click(object sender, EventArgs e)
        {
            //Add code here


        }

        //This function will put an X or O in btnRightLower Text property
        //and changes player turn as well as set disabled flag for that button
        //it also calls checkWin
        //Uses disabled9 flag
        private void btnRightLower_Click(object sender, EventArgs e)
        {
            //Add code here


        }
    }
}
