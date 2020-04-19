namespace Dorm_and_Meal_Cost
{
    partial class frmMeal
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
            this.cboMeals = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(88, 179);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cboMeals);
            this.GroupBox1.Location = new System.Drawing.Point(15, 31);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(225, 100);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select your meal plan";
            // 
            // cboMeals
            // 
            this.cboMeals.FormattingEnabled = true;
            this.cboMeals.Items.AddRange(new object[] {
            "7 meals per week",
            "14 meals per week",
            "Unlimited"});
            this.cboMeals.Location = new System.Drawing.Point(35, 38);
            this.cboMeals.Name = "cboMeals";
            this.cboMeals.Size = new System.Drawing.Size(154, 21);
            this.cboMeals.TabIndex = 0;
            // 
            // frmMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 233);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmMeal";
            this.Text = "Meal Plan Selection";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox cboMeals;

    }
}