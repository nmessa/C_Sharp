namespace Jackson_Pollack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblShapes = new System.Windows.Forms.Label();
            this.txtShapes = new System.Windows.Forms.TextBox();
            this.ckbPrint = new System.Windows.Forms.CheckBox();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(30, 599);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Location = new System.Drawing.Point(322, 607);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(103, 13);
            this.lblShapes.TabIndex = 2;
            this.lblShapes.Text = "How Many Shapes?";
            // 
            // txtShapes
            // 
            this.txtShapes.Location = new System.Drawing.Point(436, 600);
            this.txtShapes.Name = "txtShapes";
            this.txtShapes.Size = new System.Drawing.Size(100, 20);
            this.txtShapes.TabIndex = 0;
            // 
            // ckbPrint
            // 
            this.ckbPrint.AutoSize = true;
            this.ckbPrint.Location = new System.Drawing.Point(577, 604);
            this.ckbPrint.Name = "ckbPrint";
            this.ckbPrint.Size = new System.Drawing.Size(94, 17);
            this.ckbPrint.TabIndex = 4;
            this.ckbPrint.Text = "Print Painting?";
            this.ckbPrint.UseVisualStyleBackColor = true;
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 643);
            this.Controls.Add(this.ckbPrint);
            this.Controls.Add(this.txtShapes);
            this.Controls.Add(this.lblShapes);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "Art Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.TextBox txtShapes;
        private System.Windows.Forms.CheckBox ckbPrint;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

