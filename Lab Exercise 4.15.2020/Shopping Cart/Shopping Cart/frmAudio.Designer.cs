namespace Shopping_Cart
{
    partial class frmAudio
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAudio = new System.Windows.Forms.ListBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(137, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Book to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lstAudio);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(22, 22);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(373, 182);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select an Audio Book";
            // 
            // lstAudio
            // 
            this.lstAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAudio.FormattingEnabled = true;
            this.lstAudio.ItemHeight = 24;
            this.lstAudio.Items.AddRange(new object[] {
            "Learn Calculus in One Day (Audio)",
            "The History of Tuva (Audio)",
            "The Science of Body Language (Audio)",
            "Relaxation Techniques (Audio)"});
            this.lstAudio.Location = new System.Drawing.Point(17, 25);
            this.lstAudio.Name = "lstAudio";
            this.lstAudio.Size = new System.Drawing.Size(350, 148);
            this.lstAudio.TabIndex = 0;
            // 
            // frmAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 284);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmAudio";
            this.Text = "Audio Books";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox lstAudio;
    }
}