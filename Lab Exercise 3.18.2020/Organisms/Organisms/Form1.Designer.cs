namespace Organisms
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
            this.lblPop = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.cboGrowth = new System.Windows.Forms.ComboBox();
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.txtIncrease = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPop
            // 
            this.lblPop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPop.Location = new System.Drawing.Point(240, 275);
            this.lblPop.Name = "lblPop";
            this.lblPop.Size = new System.Drawing.Size(304, 29);
            this.lblPop.TabIndex = 23;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(37, 275);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(167, 25);
            this.Label5.TabIndex = 22;
            this.Label5.Text = "Final Population";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(311, 328);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(153, 328);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 19;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // cboGrowth
            // 
            this.cboGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrowth.FormattingEnabled = true;
            this.cboGrowth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboGrowth.Location = new System.Drawing.Point(436, 232);
            this.cboGrowth.Name = "cboGrowth";
            this.cboGrowth.Size = new System.Drawing.Size(121, 34);
            this.cboGrowth.TabIndex = 18;
            // 
            // cboStart
            // 
            this.cboStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboStart.Location = new System.Drawing.Point(436, 122);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(121, 34);
            this.cboStart.TabIndex = 17;
            // 
            // txtIncrease
            // 
            this.txtIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncrease.Location = new System.Drawing.Point(436, 178);
            this.txtIncrease.Name = "txtIncrease";
            this.txtIncrease.Size = new System.Drawing.Size(100, 32);
            this.txtIncrease.TabIndex = 16;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(37, 223);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(159, 25);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Days of Growth";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(37, 171);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(273, 25);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Average Daily Increase (%)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(37, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(392, 25);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Starting Number of Organisms (millions)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(153, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(382, 31);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Organism Growth Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 378);
            this.Controls.Add(this.lblPop);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cboGrowth);
            this.Controls.Add(this.cboStart);
            this.Controls.Add(this.txtIncrease);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Organism Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblPop;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.ComboBox cboGrowth;
        internal System.Windows.Forms.ComboBox cboStart;
        internal System.Windows.Forms.TextBox txtIncrease;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

