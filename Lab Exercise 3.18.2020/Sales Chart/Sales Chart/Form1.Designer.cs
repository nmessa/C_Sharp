namespace Sales_Chart
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
            this.btnInput = new System.Windows.Forms.Button();
            this.lstSales = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(230, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(129, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(28, 345);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Plot Data";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lstSales
            // 
            this.lstSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSales.FormattingEnabled = true;
            this.lstSales.ItemHeight = 29;
            this.lstSales.Location = new System.Drawing.Point(28, 25);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(930, 265);
            this.lstSales.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter sales for 5 companies";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(371, 345);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(488, 345);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(605, 345);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(722, 345);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(839, 345);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 393);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lstSales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnInput;
        internal System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
    }
}

