namespace Conference_Application
{
    partial class frmOptions
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lstWorkshop = new System.Windows.Forms.ListBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDinner = new System.Windows.Forms.CheckBox();
            this.ckbReg = new System.Windows.Forms.CheckBox();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(437, 257);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(540, 257);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.lstWorkshop);
            this.GroupBox2.Location = new System.Drawing.Point(396, 38);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(269, 190);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Pre-Conference Workshop";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(41, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Select One";
            // 
            // lstWorkshop
            // 
            this.lstWorkshop.FormattingEnabled = true;
            this.lstWorkshop.Items.AddRange(new object[] {
            "Intro to E-Commerce",
            "The Future of the Web",
            "Advanced C#",
            "Network Security"});
            this.lstWorkshop.Location = new System.Drawing.Point(41, 48);
            this.lstWorkshop.Name = "lstWorkshop";
            this.lstWorkshop.Size = new System.Drawing.Size(192, 69);
            this.lstWorkshop.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ckbDinner);
            this.GroupBox1.Controls.Add(this.ckbReg);
            this.GroupBox1.Location = new System.Drawing.Point(37, 38);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(322, 190);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Conference";
            // 
            // ckbDinner
            // 
            this.ckbDinner.AutoSize = true;
            this.ckbDinner.Location = new System.Drawing.Point(39, 98);
            this.ckbDinner.Name = "ckbDinner";
            this.ckbDinner.Size = new System.Drawing.Size(155, 17);
            this.ckbDinner.TabIndex = 1;
            this.ckbDinner.Text = "Opening Night Dinner ($30)";
            this.ckbDinner.UseVisualStyleBackColor = true;
            // 
            // ckbReg
            // 
            this.ckbReg.AutoSize = true;
            this.ckbReg.Location = new System.Drawing.Point(39, 48);
            this.ckbReg.Name = "ckbReg";
            this.ckbReg.Size = new System.Drawing.Size(173, 17);
            this.ckbReg.TabIndex = 0;
            this.ckbReg.Text = "Conference Registration ($895)";
            this.ckbReg.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 308);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmOptions";
            this.Text = "Confernece Options";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox lstWorkshop;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox ckbDinner;
        internal System.Windows.Forms.CheckBox ckbReg;
    }
}