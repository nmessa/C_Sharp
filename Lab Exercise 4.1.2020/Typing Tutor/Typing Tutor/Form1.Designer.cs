namespace Typing_Tutor
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTurtle = new System.Windows.Forms.Label();
            this.lblBird = new System.Windows.Forms.Label();
            this.lblFish = new System.Windows.Forms.Label();
            this.lblDog = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(368, 573);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 573);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntry.Location = new System.Drawing.Point(76, 536);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(326, 31);
            this.txtEntry.TabIndex = 15;
            this.txtEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntry.TextChanged += new System.EventHandler(this.txtEntry_TextChanged);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(135, 573);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(191, 28);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Score: ";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurtle
            // 
            this.lblTurtle.BackColor = System.Drawing.Color.Transparent;
            this.lblTurtle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurtle.ForeColor = System.Drawing.Color.White;
            this.lblTurtle.Location = new System.Drawing.Point(357, 1);
            this.lblTurtle.Name = "lblTurtle";
            this.lblTurtle.Size = new System.Drawing.Size(84, 34);
            this.lblTurtle.TabIndex = 13;
            this.lblTurtle.Text = "turtle";
            this.lblTurtle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBird
            // 
            this.lblBird.BackColor = System.Drawing.Color.Transparent;
            this.lblBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBird.ForeColor = System.Drawing.Color.White;
            this.lblBird.Location = new System.Drawing.Point(273, 1);
            this.lblBird.Name = "lblBird";
            this.lblBird.Size = new System.Drawing.Size(84, 34);
            this.lblBird.TabIndex = 12;
            this.lblBird.Text = "bird";
            this.lblBird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFish
            // 
            this.lblFish.BackColor = System.Drawing.Color.Transparent;
            this.lblFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFish.ForeColor = System.Drawing.Color.White;
            this.lblFish.Location = new System.Drawing.Point(189, 1);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(84, 34);
            this.lblFish.TabIndex = 11;
            this.lblFish.Text = "fish";
            this.lblFish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDog
            // 
            this.lblDog.BackColor = System.Drawing.Color.Transparent;
            this.lblDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDog.ForeColor = System.Drawing.Color.White;
            this.lblDog.Location = new System.Drawing.Point(105, 1);
            this.lblDog.Name = "lblDog";
            this.lblDog.Size = new System.Drawing.Size(84, 34);
            this.lblDog.TabIndex = 10;
            this.lblDog.Text = "dog";
            this.lblDog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCat
            // 
            this.lblCat.BackColor = System.Drawing.Color.Transparent;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.White;
            this.lblCat.Location = new System.Drawing.Point(21, 1);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(84, 34);
            this.lblCat.TabIndex = 9;
            this.lblCat.Text = "cat";
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 605);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTurtle);
            this.Controls.Add(this.lblBird);
            this.Controls.Add(this.lblFish);
            this.Controls.Add(this.lblDog);
            this.Controls.Add(this.lblCat);
            this.Name = "Form1";
            this.Text = "Alien Invasion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnQuit;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.TextBox txtEntry;
        internal System.Windows.Forms.Label lblScore;
        internal System.Windows.Forms.Label lblTurtle;
        internal System.Windows.Forms.Label lblBird;
        internal System.Windows.Forms.Label lblFish;
        internal System.Windows.Forms.Label lblDog;
        internal System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Timer timer1;
    }
}

