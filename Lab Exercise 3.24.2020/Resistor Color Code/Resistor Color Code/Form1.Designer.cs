namespace Resistor_Color_Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pbTolerance = new System.Windows.Forms.PictureBox();
            this.pbMultiplier = new System.Windows.Forms.PictureBox();
            this.pbDigit2 = new System.Windows.Forms.PictureBox();
            this.pbDigit1 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboTolerance = new System.Windows.Forms.ComboBox();
            this.cboMultiplier = new System.Windows.Forms.ComboBox();
            this.cboDigit2 = new System.Windows.Forms.ComboBox();
            this.cboDigit1 = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDigit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDigit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(709, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 58);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(596, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 58);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(473, 312);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(117, 58);
            this.btnCalc.TabIndex = 39;
            this.btnCalc.Text = "Calculate Resistance";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pbTolerance
            // 
            this.pbTolerance.Location = new System.Drawing.Point(473, 88);
            this.pbTolerance.Name = "pbTolerance";
            this.pbTolerance.Size = new System.Drawing.Size(15, 55);
            this.pbTolerance.TabIndex = 38;
            this.pbTolerance.TabStop = false;
            // 
            // pbMultiplier
            // 
            this.pbMultiplier.Location = new System.Drawing.Point(428, 88);
            this.pbMultiplier.Name = "pbMultiplier";
            this.pbMultiplier.Size = new System.Drawing.Size(15, 55);
            this.pbMultiplier.TabIndex = 37;
            this.pbMultiplier.TabStop = false;
            // 
            // pbDigit2
            // 
            this.pbDigit2.Location = new System.Drawing.Point(398, 88);
            this.pbDigit2.Name = "pbDigit2";
            this.pbDigit2.Size = new System.Drawing.Size(15, 55);
            this.pbDigit2.TabIndex = 36;
            this.pbDigit2.TabStop = false;
            // 
            // pbDigit1
            // 
            this.pbDigit1.Location = new System.Drawing.Point(368, 88);
            this.pbDigit1.Name = "pbDigit1";
            this.pbDigit1.Size = new System.Drawing.Size(15, 55);
            this.pbDigit1.TabIndex = 35;
            this.pbDigit1.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(270, 29);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(368, 157);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 34;
            this.PictureBox1.TabStop = false;
            // 
            // cboTolerance
            // 
            this.cboTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTolerance.FormattingEnabled = true;
            this.cboTolerance.Items.AddRange(new object[] {
            "Gold",
            "Silver",
            "None"});
            this.cboTolerance.Location = new System.Drawing.Point(732, 227);
            this.cboTolerance.Name = "cboTolerance";
            this.cboTolerance.Size = new System.Drawing.Size(121, 34);
            this.cboTolerance.TabIndex = 33;
            this.cboTolerance.SelectedIndexChanged += new System.EventHandler(this.cboTolerance_SelectedIndexChanged);
            // 
            // cboMultiplier
            // 
            this.cboMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMultiplier.FormattingEnabled = true;
            this.cboMultiplier.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White",
            "Gold",
            "Silver"});
            this.cboMultiplier.Location = new System.Drawing.Point(508, 227);
            this.cboMultiplier.Name = "cboMultiplier";
            this.cboMultiplier.Size = new System.Drawing.Size(121, 34);
            this.cboMultiplier.TabIndex = 32;
            this.cboMultiplier.SelectedIndexChanged += new System.EventHandler(this.cboMultiplier_SelectedIndexChanged);
            // 
            // cboDigit2
            // 
            this.cboDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDigit2.FormattingEnabled = true;
            this.cboDigit2.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cboDigit2.Location = new System.Drawing.Point(281, 227);
            this.cboDigit2.Name = "cboDigit2";
            this.cboDigit2.Size = new System.Drawing.Size(121, 34);
            this.cboDigit2.TabIndex = 31;
            this.cboDigit2.SelectedIndexChanged += new System.EventHandler(this.cboDigit2_SelectedIndexChanged);
            // 
            // cboDigit1
            // 
            this.cboDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDigit1.FormattingEnabled = true;
            this.cboDigit1.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Gray",
            "White"});
            this.cboDigit1.Location = new System.Drawing.Point(78, 227);
            this.cboDigit1.Name = "cboDigit1";
            this.cboDigit1.Size = new System.Drawing.Size(121, 34);
            this.cboDigit1.TabIndex = 30;
            this.cboDigit1.SelectedIndexChanged += new System.EventHandler(this.cboDigit1_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(634, 227);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 24);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "Tolerance";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(419, 227);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(85, 24);
            this.Label6.TabIndex = 28;
            this.Label6.Text = "Multiplier";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(212, 227);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(61, 24);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Digit 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(14, 227);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 24);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "Digit 1";
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerance.Location = new System.Drawing.Point(258, 337);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(0, 24);
            this.lblTolerance.TabIndex = 25;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(258, 297);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(0, 24);
            this.lblValue.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(106, 337);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(96, 24);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Tolerance";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(106, 297);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 24);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Resistor Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.pbTolerance);
            this.Controls.Add(this.pbMultiplier);
            this.Controls.Add(this.pbDigit2);
            this.Controls.Add(this.pbDigit1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cboTolerance);
            this.Controls.Add(this.cboMultiplier);
            this.Controls.Add(this.cboDigit2);
            this.Controls.Add(this.cboDigit1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblTolerance);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Resistor Color Decoder";
            ((System.ComponentModel.ISupportInitialize)(this.pbTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDigit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDigit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnCalc;
        internal System.Windows.Forms.PictureBox pbTolerance;
        internal System.Windows.Forms.PictureBox pbMultiplier;
        internal System.Windows.Forms.PictureBox pbDigit2;
        internal System.Windows.Forms.PictureBox pbDigit1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ComboBox cboTolerance;
        internal System.Windows.Forms.ComboBox cboMultiplier;
        internal System.Windows.Forms.ComboBox cboDigit2;
        internal System.Windows.Forms.ComboBox cboDigit1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblTolerance;
        internal System.Windows.Forms.Label lblValue;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

