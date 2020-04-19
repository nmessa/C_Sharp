namespace Dorm_and_Meal_Cost
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblMealplan = new System.Windows.Forms.Label();
            this.lblDorm = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnDorm = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblCollege = new System.Windows.Forms.Label();
            this.cboMajor = new System.Windows.Forms.ComboBox();
            this.cboCollege = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMealplan
            // 
            this.lblMealplan.AutoSize = true;
            this.lblMealplan.Location = new System.Drawing.Point(368, 183);
            this.lblMealplan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMealplan.Name = "lblMealplan";
            this.lblMealplan.Size = new System.Drawing.Size(0, 13);
            this.lblMealplan.TabIndex = 45;
            // 
            // lblDorm
            // 
            this.lblDorm.AutoSize = true;
            this.lblDorm.Location = new System.Drawing.Point(368, 161);
            this.lblDorm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDorm.Name = "lblDorm";
            this.lblDorm.Size = new System.Drawing.Size(0, 13);
            this.lblDorm.TabIndex = 44;
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.Location = new System.Drawing.Point(380, 120);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(100, 23);
            this.lblCost.TabIndex = 43;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(326, 124);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 42;
            this.Label9.Text = "Cost";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(508, 217);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(83, 37);
            this.btnQuit.TabIndex = 41;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(416, 217);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 37);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(318, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 37);
            this.btnReset.TabIndex = 39;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMeal
            // 
            this.btnMeal.Location = new System.Drawing.Point(216, 217);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(83, 37);
            this.btnMeal.TabIndex = 38;
            this.btnMeal.Text = "Choose Meal Plan";
            this.btnMeal.UseVisualStyleBackColor = true;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // btnDorm
            // 
            this.btnDorm.Location = new System.Drawing.Point(114, 217);
            this.btnDorm.Name = "btnDorm";
            this.btnDorm.Size = new System.Drawing.Size(83, 37);
            this.btnDorm.TabIndex = 37;
            this.btnDorm.Text = "Choose Dormitory";
            this.btnDorm.UseVisualStyleBackColor = true;
            this.btnDorm.Click += new System.EventHandler(this.btnDorm_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 217);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(83, 37);
            this.btnGen.TabIndex = 36;
            this.btnGen.Text = "Generate Student ID";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.SystemColors.Window;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblID.Location = new System.Drawing.Point(93, 171);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(193, 23);
            this.lblID.TabIndex = 35;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(27, 176);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(58, 13);
            this.Label8.TabIndex = 34;
            this.Label8.Text = "Student ID";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(366, 64);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(0, 13);
            this.lblMajor.TabIndex = 33;
            this.lblMajor.Visible = false;
            // 
            // lblCollege
            // 
            this.lblCollege.AutoSize = true;
            this.lblCollege.Location = new System.Drawing.Point(366, 33);
            this.lblCollege.Name = "lblCollege";
            this.lblCollege.Size = new System.Drawing.Size(0, 13);
            this.lblCollege.TabIndex = 32;
            this.lblCollege.Visible = false;
            // 
            // cboMajor
            // 
            this.cboMajor.FormattingEnabled = true;
            this.cboMajor.Location = new System.Drawing.Point(366, 64);
            this.cboMajor.Name = "cboMajor";
            this.cboMajor.Size = new System.Drawing.Size(225, 21);
            this.cboMajor.TabIndex = 31;
            this.cboMajor.SelectedIndexChanged += new System.EventHandler(this.cboMajor_SelectedIndexChanged);
            // 
            // cboCollege
            // 
            this.cboCollege.FormattingEnabled = true;
            this.cboCollege.Items.AddRange(new object[] {
            "College of Engineering and Physical Sciences",
            "College of Liberal Arts",
            "College of Life Sciences and Agriculture",
            "College of Business and Economics"});
            this.cboCollege.Location = new System.Drawing.Point(366, 28);
            this.cboCollege.Name = "cboCollege";
            this.cboCollege.Size = new System.Drawing.Size(225, 21);
            this.cboCollege.TabIndex = 30;
            this.cboCollege.SelectedIndexChanged += new System.EventHandler(this.cboCollege_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(246, 65);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(33, 13);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "Major";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(246, 34);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(92, 13);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "College of Studies";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(88, 65);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(100, 20);
            this.txtLast.TabIndex = 25;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(88, 34);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 23;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtYear);
            this.GroupBox1.Controls.Add(this.txtDay);
            this.GroupBox1.Controls.Add(this.txtMonth);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(27, 98);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(280, 59);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Date of Birth";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(218, 22);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(41, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(126, 22);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(30, 20);
            this.txtDay.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(46, 22);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(30, 20);
            this.txtMonth.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(181, 26);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Year";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(99, 26);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(26, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "Day";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Month";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Last Name";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "First Name";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 274);
            this.Controls.Add(this.lblMealplan);
            this.Controls.Add(this.lblDorm);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.btnDorm);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblCollege);
            this.Controls.Add(this.cboMajor);
            this.Controls.Add(this.cboCollege);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmMain";
            this.Text = "University Registration";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblMealplan;
        internal System.Windows.Forms.Label lblDorm;
        internal System.Windows.Forms.Label lblCost;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnMeal;
        internal System.Windows.Forms.Button btnDorm;
        internal System.Windows.Forms.Button btnGen;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label lblMajor;
        internal System.Windows.Forms.Label lblCollege;
        internal System.Windows.Forms.ComboBox cboMajor;
        internal System.Windows.Forms.ComboBox cboCollege;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtLast;
        internal System.Windows.Forms.TextBox txtFirst;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtYear;
        internal System.Windows.Forms.TextBox txtDay;
        internal System.Windows.Forms.TextBox txtMonth;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

