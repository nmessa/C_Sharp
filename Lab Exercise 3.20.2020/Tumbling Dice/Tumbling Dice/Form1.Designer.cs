namespace Tumbling_Dice
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
            this.lblResult = new System.Windows.Forms.Label();
            this.die6 = new System.Windows.Forms.PictureBox();
            this.die5 = new System.Windows.Forms.PictureBox();
            this.die4 = new System.Windows.Forms.PictureBox();
            this.die3 = new System.Windows.Forms.PictureBox();
            this.die2 = new System.Windows.Forms.PictureBox();
            this.die1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.die6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(237, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 19;
            // 
            // die6
            // 
            this.die6.Image = ((System.Drawing.Image)(resources.GetObject("die6.Image")));
            this.die6.Location = new System.Drawing.Point(652, 476);
            this.die6.Name = "die6";
            this.die6.Size = new System.Drawing.Size(121, 108);
            this.die6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die6.TabIndex = 18;
            this.die6.TabStop = false;
            this.die6.Visible = false;
            // 
            // die5
            // 
            this.die5.Image = ((System.Drawing.Image)(resources.GetObject("die5.Image")));
            this.die5.Location = new System.Drawing.Point(525, 476);
            this.die5.Name = "die5";
            this.die5.Size = new System.Drawing.Size(121, 108);
            this.die5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die5.TabIndex = 17;
            this.die5.TabStop = false;
            this.die5.Visible = false;
            // 
            // die4
            // 
            this.die4.Image = ((System.Drawing.Image)(resources.GetObject("die4.Image")));
            this.die4.Location = new System.Drawing.Point(398, 476);
            this.die4.Name = "die4";
            this.die4.Size = new System.Drawing.Size(121, 108);
            this.die4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die4.TabIndex = 16;
            this.die4.TabStop = false;
            this.die4.Visible = false;
            // 
            // die3
            // 
            this.die3.Image = ((System.Drawing.Image)(resources.GetObject("die3.Image")));
            this.die3.Location = new System.Drawing.Point(271, 476);
            this.die3.Name = "die3";
            this.die3.Size = new System.Drawing.Size(121, 108);
            this.die3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die3.TabIndex = 15;
            this.die3.TabStop = false;
            this.die3.Visible = false;
            // 
            // die2
            // 
            this.die2.Image = ((System.Drawing.Image)(resources.GetObject("die2.Image")));
            this.die2.Location = new System.Drawing.Point(144, 476);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(121, 108);
            this.die2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die2.TabIndex = 14;
            this.die2.TabStop = false;
            this.die2.Visible = false;
            // 
            // die1
            // 
            this.die1.Image = ((System.Drawing.Image)(resources.GetObject("die1.Image")));
            this.die1.Location = new System.Drawing.Point(17, 476);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(121, 108);
            this.die1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die1.TabIndex = 13;
            this.die1.TabStop = false;
            this.die1.Visible = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(419, 115);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(121, 108);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 12;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = ((System.Drawing.Image)(resources.GetObject("pb1.Image")));
            this.pb1.Location = new System.Drawing.Point(264, 115);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(121, 108);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 11;
            this.pb1.TabStop = false;
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(302, 269);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(201, 91);
            this.btnRoll.TabIndex = 10;
            this.btnRoll.Text = "Roll the Dice";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 598);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.die6);
            this.Controls.Add(this.die5);
            this.Controls.Add(this.die4);
            this.Controls.Add(this.die3);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.die6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblResult;
        internal System.Windows.Forms.PictureBox die6;
        internal System.Windows.Forms.PictureBox die5;
        internal System.Windows.Forms.PictureBox die4;
        internal System.Windows.Forms.PictureBox die3;
        internal System.Windows.Forms.PictureBox die2;
        internal System.Windows.Forms.PictureBox die1;
        internal System.Windows.Forms.PictureBox pb2;
        internal System.Windows.Forms.PictureBox pb1;
        internal System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Timer timer1;
    }
}

