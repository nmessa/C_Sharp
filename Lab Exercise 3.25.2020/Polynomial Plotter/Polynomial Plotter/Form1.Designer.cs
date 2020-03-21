namespace Polynomial_Plotter
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnClear = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.txtX4 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(400, 705);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(42, 657);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(62, 24);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "f (x) = ";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(518, 657);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(24, 24);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "X";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(400, 657);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 24);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "X^2";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(279, 657);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 24);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "X^3";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(151, 657);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 24);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "X^4";
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(555, 658);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(37, 20);
            this.txtX0.TabIndex = 4;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(480, 658);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(37, 20);
            this.txtX1.TabIndex = 3;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(360, 658);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(37, 20);
            this.txtX2.TabIndex = 2;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(241, 658);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(37, 20);
            this.txtX3.TabIndex = 1;
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(112, 658);
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(37, 20);
            this.txtX4.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(275, 705);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(150, 706);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.Location = new System.Drawing.Point(25, 707);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(75, 23);
            this.btnPlot.TabIndex = 16;
            this.btnPlot.Text = "Plot";
            this.btnPlot.UseVisualStyleBackColor = true;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(25, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "fx";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1080, 604);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 765);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.txtX4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPlot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtX0;
        internal System.Windows.Forms.TextBox txtX1;
        internal System.Windows.Forms.TextBox txtX2;
        internal System.Windows.Forms.TextBox txtX3;
        internal System.Windows.Forms.TextBox txtX4;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

