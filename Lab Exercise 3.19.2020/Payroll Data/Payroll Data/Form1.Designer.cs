namespace Payroll_Data
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
            this.cboFed = new System.Windows.Forms.ComboBox();
            this.btnClearReport = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboFed
            // 
            this.cboFed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFed.FormattingEnabled = true;
            this.cboFed.Items.AddRange(new object[] {
            "10",
            "15",
            "25",
            "28",
            "33",
            "35",
            "39.6"});
            this.cboFed.Location = new System.Drawing.Point(315, 295);
            this.cboFed.Margin = new System.Windows.Forms.Padding(2);
            this.cboFed.Name = "cboFed";
            this.cboFed.Size = new System.Drawing.Size(100, 34);
            this.cboFed.TabIndex = 38;
            // 
            // btnClearReport
            // 
            this.btnClearReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearReport.Location = new System.Drawing.Point(281, 509);
            this.btnClearReport.Name = "btnClearReport";
            this.btnClearReport.Size = new System.Drawing.Size(118, 72);
            this.btnClearReport.TabIndex = 37;
            this.btnClearReport.Text = "Clear Report";
            this.btnClearReport.UseVisualStyleBackColor = true;
            this.btnClearReport.Click += new System.EventHandler(this.btnClearReport_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(411, 509);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(118, 72);
            this.btnQuit.TabIndex = 36;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(151, 509);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 72);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(21, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 72);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 24;
            this.lstOutput.Location = new System.Drawing.Point(551, 19);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(497, 556);
            this.lstOutput.TabIndex = 33;
            // 
            // txtMed
            // 
            this.txtMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMed.Location = new System.Drawing.Point(315, 422);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(100, 31);
            this.txtMed.TabIndex = 32;
            this.txtMed.Text = "1.45";
            // 
            // txtSS
            // 
            this.txtSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSS.Location = new System.Drawing.Point(315, 357);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 31);
            this.txtSS.TabIndex = 31;
            this.txtSS.Text = "6.2";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(315, 227);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 31);
            this.txtState.TabIndex = 30;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(315, 162);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 31);
            this.txtRate.TabIndex = 29;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(315, 97);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 31);
            this.txtHours.TabIndex = 28;
            // 
            // cboNames
            // 
            this.cboNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Items.AddRange(new object[] {
            "John Smith",
            "Mary Jones",
            "Max Headroom",
            "Jimmy Outlaw"});
            this.cboNames.Location = new System.Drawing.Point(315, 41);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(175, 33);
            this.cboNames.TabIndex = 27;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(63, 42);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(169, 25);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Employee Name";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(63, 425);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(140, 25);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "Medicare (%)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(63, 360);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(194, 25);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Social Security (%)";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(63, 295);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(241, 25);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Federal Income Tax (%)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(63, 230);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(218, 25);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "State Income Tax (%)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(63, 165);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(168, 25);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Hourly Pay Rate";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(63, 100);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(149, 25);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Hours Worked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 600);
            this.Controls.Add(this.cboFed);
            this.Controls.Add(this.btnClearReport);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.cboNames);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboFed;
        internal System.Windows.Forms.Button btnClearReport;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ListBox lstOutput;
        internal System.Windows.Forms.TextBox txtMed;
        internal System.Windows.Forms.TextBox txtSS;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtRate;
        internal System.Windows.Forms.TextBox txtHours;
        internal System.Windows.Forms.ComboBox cboNames;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

