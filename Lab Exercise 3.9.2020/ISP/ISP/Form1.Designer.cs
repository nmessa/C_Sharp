namespace ISP
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.radC = new System.Windows.Forms.RadioButton();
            this.radB = new System.Windows.Forms.RadioButton();
            this.radA = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkNonProfit = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(476, 467);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(343, 467);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 33);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(204, 467);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 33);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(505, 172);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 26);
            this.lblAmount.TabIndex = 16;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(363, 172);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(134, 26);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Amount Due";
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(245, 112);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 32);
            this.txtHours.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(116, 115);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(127, 26);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Hours Used";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.radC);
            this.GroupBox1.Controls.Add(this.radB);
            this.GroupBox1.Controls.Add(this.radA);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.GroupBox1.Location = new System.Drawing.Point(121, 163);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 174);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Internet Package";
            // 
            // radC
            // 
            this.radC.AutoSize = true;
            this.radC.Location = new System.Drawing.Point(17, 111);
            this.radC.Name = "radC";
            this.radC.Size = new System.Drawing.Size(137, 30);
            this.radC.TabIndex = 2;
            this.radC.Text = "Package C";
            this.radC.UseVisualStyleBackColor = true;
            // 
            // radB
            // 
            this.radB.AutoSize = true;
            this.radB.Location = new System.Drawing.Point(17, 75);
            this.radB.Name = "radB";
            this.radB.Size = new System.Drawing.Size(136, 30);
            this.radB.TabIndex = 1;
            this.radB.Text = "Package B";
            this.radB.UseVisualStyleBackColor = true;
            // 
            // radA
            // 
            this.radA.AutoSize = true;
            this.radA.Checked = true;
            this.radA.Location = new System.Drawing.Point(17, 38);
            this.radA.Name = "radA";
            this.radA.Size = new System.Drawing.Size(136, 30);
            this.radA.TabIndex = 0;
            this.radA.TabStop = true;
            this.radA.Text = "Package A";
            this.radA.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(247, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(304, 31);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Internet Bill Calculator";
            // 
            // chkNonProfit
            // 
            this.chkNonProfit.AutoSize = true;
            this.chkNonProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNonProfit.Location = new System.Drawing.Point(121, 360);
            this.chkNonProfit.Name = "chkNonProfit";
            this.chkNonProfit.Size = new System.Drawing.Size(248, 30);
            this.chkNonProfit.TabIndex = 11;
            this.chkNonProfit.Text = "Nonprofit Organization";
            this.chkNonProfit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.chkNonProfit);
            this.Name = "Form1";
            this.Text = "ISP";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.Label lblAmount;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtHours;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton radC;
        internal System.Windows.Forms.RadioButton radB;
        internal System.Windows.Forms.RadioButton radA;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkNonProfit;
    }
}

