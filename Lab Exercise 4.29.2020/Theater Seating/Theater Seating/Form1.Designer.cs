namespace Theater_Seating
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
            this.lblChart = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.Location = new System.Drawing.Point(143, 75);
            this.lblChart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(0, 35);
            this.lblChart.TabIndex = 15;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRow.Location = new System.Drawing.Point(23, 66);
            this.lblRow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(0, 36);
            this.lblRow.TabIndex = 14;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(316, 650);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(102, 23);
            this.btnReserve.TabIndex = 13;
            this.btnReserve.Text = "Reserve Seat";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(118, 665);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(100, 20);
            this.txtCol.TabIndex = 12;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(118, 633);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(100, 20);
            this.txtRow.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(36, 665);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Seat";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(37, 633);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Row";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.Location = new System.Drawing.Point(144, 21);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(1018, 29);
            this.lblSeats.TabIndex = 8;
            this.lblSeats.Text = " 1   2    3    4   5    6   7    8   9  10 11 12  13 14 15  16 17 18 19  20  21 2" +
    "2 23 24  25 26 27 28  29 30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 704);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.lblSeats);
            this.Name = "Form1";
            this.Text = "Theater Seating Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblChart;
        internal System.Windows.Forms.Label lblRow;
        internal System.Windows.Forms.Button btnReserve;
        internal System.Windows.Forms.TextBox txtCol;
        internal System.Windows.Forms.TextBox txtRow;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblSeats;
    }
}

