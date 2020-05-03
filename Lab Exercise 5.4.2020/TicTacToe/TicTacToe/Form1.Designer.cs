namespace TicTacToe
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
            this.lblWin = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRightLower = new System.Windows.Forms.Button();
            this.btnMiddleLower = new System.Windows.Forms.Button();
            this.btnLeftLower = new System.Windows.Forms.Button();
            this.btnRightMiddle = new System.Windows.Forms.Button();
            this.btnMiddleMiddle = new System.Windows.Forms.Button();
            this.btnLeftMiddle = new System.Windows.Forms.Button();
            this.btnRightUpper = new System.Windows.Forms.Button();
            this.btnMiddleUpper = new System.Windows.Forms.Button();
            this.btnLeftUpper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWin
            // 
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(91, 330);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(352, 56);
            this.lblWin.TabIndex = 123;
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(275, 250);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(128, 56);
            this.btnQuit.TabIndex = 122;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(115, 250);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 56);
            this.btnReset.TabIndex = 121;
            this.btnReset.Text = "Reset Game";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRightLower
            // 
            this.btnRightLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightLower.Location = new System.Drawing.Point(299, 154);
            this.btnRightLower.Name = "btnRightLower";
            this.btnRightLower.Size = new System.Drawing.Size(72, 64);
            this.btnRightLower.TabIndex = 120;
            this.btnRightLower.Click += new System.EventHandler(this.btnRightLower_Click);
            // 
            // btnMiddleLower
            // 
            this.btnMiddleLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiddleLower.Location = new System.Drawing.Point(227, 154);
            this.btnMiddleLower.Name = "btnMiddleLower";
            this.btnMiddleLower.Size = new System.Drawing.Size(72, 64);
            this.btnMiddleLower.TabIndex = 119;
            this.btnMiddleLower.Click += new System.EventHandler(this.btnMiddleLower_Click);
            // 
            // btnLeftLower
            // 
            this.btnLeftLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftLower.Location = new System.Drawing.Point(155, 154);
            this.btnLeftLower.Name = "btnLeftLower";
            this.btnLeftLower.Size = new System.Drawing.Size(72, 64);
            this.btnLeftLower.TabIndex = 118;
            this.btnLeftLower.Click += new System.EventHandler(this.btnLeftLower_Click);
            // 
            // btnRightMiddle
            // 
            this.btnRightMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightMiddle.Location = new System.Drawing.Point(299, 90);
            this.btnRightMiddle.Name = "btnRightMiddle";
            this.btnRightMiddle.Size = new System.Drawing.Size(72, 64);
            this.btnRightMiddle.TabIndex = 117;
            this.btnRightMiddle.Click += new System.EventHandler(this.btnRightMiddle_Click);
            // 
            // btnMiddleMiddle
            // 
            this.btnMiddleMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiddleMiddle.Location = new System.Drawing.Point(227, 90);
            this.btnMiddleMiddle.Name = "btnMiddleMiddle";
            this.btnMiddleMiddle.Size = new System.Drawing.Size(72, 64);
            this.btnMiddleMiddle.TabIndex = 116;
            this.btnMiddleMiddle.Click += new System.EventHandler(this.btnMiddleMiddle_Click);
            // 
            // btnLeftMiddle
            // 
            this.btnLeftMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftMiddle.Location = new System.Drawing.Point(155, 90);
            this.btnLeftMiddle.Name = "btnLeftMiddle";
            this.btnLeftMiddle.Size = new System.Drawing.Size(72, 64);
            this.btnLeftMiddle.TabIndex = 115;
            this.btnLeftMiddle.Click += new System.EventHandler(this.btnLeftMiddle_Click);
            // 
            // btnRightUpper
            // 
            this.btnRightUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightUpper.Location = new System.Drawing.Point(299, 26);
            this.btnRightUpper.Name = "btnRightUpper";
            this.btnRightUpper.Size = new System.Drawing.Size(72, 64);
            this.btnRightUpper.TabIndex = 114;
            this.btnRightUpper.Click += new System.EventHandler(this.btnRightUpper_Click);
            // 
            // btnMiddleUpper
            // 
            this.btnMiddleUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiddleUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiddleUpper.Location = new System.Drawing.Point(227, 26);
            this.btnMiddleUpper.Name = "btnMiddleUpper";
            this.btnMiddleUpper.Size = new System.Drawing.Size(72, 64);
            this.btnMiddleUpper.TabIndex = 113;
            this.btnMiddleUpper.Click += new System.EventHandler(this.btnMiddleUpper_Click);
            // 
            // btnLeftUpper
            // 
            this.btnLeftUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftUpper.Location = new System.Drawing.Point(155, 26);
            this.btnLeftUpper.Name = "btnLeftUpper";
            this.btnLeftUpper.Size = new System.Drawing.Size(72, 64);
            this.btnLeftUpper.TabIndex = 112;
            this.btnLeftUpper.Click += new System.EventHandler(this.btnLeftUpper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 422);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRightLower);
            this.Controls.Add(this.btnMiddleLower);
            this.Controls.Add(this.btnLeftLower);
            this.Controls.Add(this.btnRightMiddle);
            this.Controls.Add(this.btnMiddleMiddle);
            this.Controls.Add(this.btnLeftMiddle);
            this.Controls.Add(this.btnRightUpper);
            this.Controls.Add(this.btnMiddleUpper);
            this.Controls.Add(this.btnLeftUpper);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblWin;
        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnRightLower;
        internal System.Windows.Forms.Button btnMiddleLower;
        internal System.Windows.Forms.Button btnLeftLower;
        internal System.Windows.Forms.Button btnRightMiddle;
        internal System.Windows.Forms.Button btnMiddleMiddle;
        internal System.Windows.Forms.Button btnLeftMiddle;
        internal System.Windows.Forms.Button btnRightUpper;
        internal System.Windows.Forms.Button btnMiddleUpper;
        internal System.Windows.Forms.Button btnLeftUpper;
    }
}

