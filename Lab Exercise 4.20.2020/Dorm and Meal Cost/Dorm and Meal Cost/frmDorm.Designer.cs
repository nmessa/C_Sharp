namespace Dorm_and_Meal_Cost
{
    partial class frmDorm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDorm = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(98, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboDorm);
            this.GroupBox1.Location = new System.Drawing.Point(23, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 84);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select Your Dorm";
            // 
            // cboDorm
            // 
            this.cboDorm.FormattingEnabled = true;
            this.cboDorm.Items.AddRange(new object[] {
            "Allen Hall",
            "Pike Hall",
            "Farthing Hall",
            "University Suites"});
            this.cboDorm.Location = new System.Drawing.Point(16, 33);
            this.cboDorm.Name = "cboDorm";
            this.cboDorm.Size = new System.Drawing.Size(168, 21);
            this.cboDorm.TabIndex = 0;
            // 
            // frmDorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 202);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmDorm";
            this.Text = "Dorm Selection Form";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboDorm;
    }
}