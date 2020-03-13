namespace RunnerApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtTimeThree = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.txtTimeTwo = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtTimeOne = new System.Windows.Forms.TextBox();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(398, 539);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 59);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(256, 539);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 59);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(82, 539);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(122, 59);
            this.btnCalc.TabIndex = 29;
            this.btnCalc.Text = "Calculate Results";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblThird);
            this.grpResults.Controls.Add(this.lblSecond);
            this.grpResults.Controls.Add(this.lblFirst);
            this.grpResults.Controls.Add(this.Label10);
            this.grpResults.Controls.Add(this.Label9);
            this.grpResults.Controls.Add(this.Label8);
            this.grpResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResults.ForeColor = System.Drawing.Color.Black;
            this.grpResults.Location = new System.Drawing.Point(30, 314);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(431, 204);
            this.grpResults.TabIndex = 31;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Race Results";
            // 
            // lblThird
            // 
            this.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThird.Location = new System.Drawing.Point(236, 149);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(178, 44);
            this.lblThird.TabIndex = 5;
            // 
            // lblSecond
            // 
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecond.Location = new System.Drawing.Point(236, 89);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(178, 44);
            this.lblSecond.TabIndex = 4;
            // 
            // lblFirst
            // 
            this.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirst.Location = new System.Drawing.Point(236, 32);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(178, 44);
            this.lblFirst.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(98, 150);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 26);
            this.Label10.TabIndex = 2;
            this.Label10.Text = "3rd Place";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(98, 90);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(109, 26);
            this.Label9.TabIndex = 1;
            this.Label9.Text = "2nd Place";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(98, 32);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(102, 26);
            this.Label8.TabIndex = 0;
            this.Label8.Text = "1st Place";
            // 
            // txtTimeThree
            // 
            this.txtTimeThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeThree.Location = new System.Drawing.Point(330, 184);
            this.txtTimeThree.Name = "txtTimeThree";
            this.txtTimeThree.Size = new System.Drawing.Size(199, 32);
            this.txtTimeThree.TabIndex = 28;
            // 
            // txtThree
            // 
            this.txtThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThree.Location = new System.Drawing.Point(125, 183);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(187, 32);
            this.txtThree.TabIndex = 25;
            // 
            // txtTimeTwo
            // 
            this.txtTimeTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeTwo.Location = new System.Drawing.Point(330, 150);
            this.txtTimeTwo.Name = "txtTimeTwo";
            this.txtTimeTwo.Size = new System.Drawing.Size(199, 32);
            this.txtTimeTwo.TabIndex = 24;
            // 
            // txtTwo
            // 
            this.txtTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTwo.Location = new System.Drawing.Point(125, 150);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(187, 32);
            this.txtTwo.TabIndex = 22;
            // 
            // txtTimeOne
            // 
            this.txtTimeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOne.Location = new System.Drawing.Point(330, 115);
            this.txtTimeOne.Name = "txtTimeOne";
            this.txtTimeOne.Size = new System.Drawing.Size(199, 32);
            this.txtTimeOne.TabIndex = 19;
            // 
            // txtOne
            // 
            this.txtOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOne.Location = new System.Drawing.Point(125, 115);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(187, 32);
            this.txtOne.TabIndex = 17;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(367, 87);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(147, 26);
            this.Label7.TabIndex = 30;
            this.Label7.Text = "Finishing time";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(190, 88);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(71, 26);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "Name";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(28, 184);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(101, 26);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Runner 3";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(28, 150);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 26);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Runner 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(28, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(101, 26);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Runner 1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(166, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(239, 24);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "finishing times (hh:mm:sec)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(134, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(303, 24);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Enter the three runners names and";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 617);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.txtTimeThree);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTimeTwo);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtTimeOne);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Marathon Calculator";
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.GroupBox grpResults;
        internal System.Windows.Forms.Label lblThird;
        internal System.Windows.Forms.Label lblSecond;
        internal System.Windows.Forms.Label lblFirst;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtTimeThree;
        internal System.Windows.Forms.TextBox txtThree;
        internal System.Windows.Forms.TextBox txtTimeTwo;
        internal System.Windows.Forms.TextBox txtTwo;
        internal System.Windows.Forms.TextBox txtTimeOne;
        internal System.Windows.Forms.TextBox txtOne;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

