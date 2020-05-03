namespace Word_Processor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CenterJustifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LeftJustifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightJustifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GradeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sentenceCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(0, 27);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(1198, 759);
            this.RichTextBox1.TabIndex = 3;
            this.RichTextBox1.Text = "";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.FormatToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ColorToolStripMenuItem,
            this.ToolsToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1198, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.CapsToolStripMenuItem,
            this.CenterJustifyToolStripMenuItem,
            this.LeftJustifyToolStripMenuItem,
            this.RightJustifyToolStripMenuItem});
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FormatToolStripMenuItem.Text = "Format";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.FontToolStripMenuItem.Text = "Font";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // CapsToolStripMenuItem
            // 
            this.CapsToolStripMenuItem.Name = "CapsToolStripMenuItem";
            this.CapsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.CapsToolStripMenuItem.Text = "Caps";
            this.CapsToolStripMenuItem.Click += new System.EventHandler(this.CapsToolStripMenuItem_Click);
            // 
            // CenterJustifyToolStripMenuItem
            // 
            this.CenterJustifyToolStripMenuItem.Name = "CenterJustifyToolStripMenuItem";
            this.CenterJustifyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.CenterJustifyToolStripMenuItem.Text = "Center Justify";
            this.CenterJustifyToolStripMenuItem.Click += new System.EventHandler(this.CenterJustifyToolStripMenuItem_Click);
            // 
            // LeftJustifyToolStripMenuItem
            // 
            this.LeftJustifyToolStripMenuItem.Name = "LeftJustifyToolStripMenuItem";
            this.LeftJustifyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.LeftJustifyToolStripMenuItem.Text = "Left Justify";
            this.LeftJustifyToolStripMenuItem.Click += new System.EventHandler(this.LeftJustifyToolStripMenuItem_Click);
            // 
            // RightJustifyToolStripMenuItem
            // 
            this.RightJustifyToolStripMenuItem.Name = "RightJustifyToolStripMenuItem";
            this.RightJustifyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.RightJustifyToolStripMenuItem.Text = "Right Justify";
            this.RightJustifyToolStripMenuItem.Click += new System.EventHandler(this.RightJustifyToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.CutToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.CutToolStripMenuItem.Text = "Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem1,
            this.BackgroundToolStripMenuItem});
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ColorToolStripMenuItem.Text = "Color";
            // 
            // FontToolStripMenuItem1
            // 
            this.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1";
            this.FontToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.FontToolStripMenuItem1.Text = "Font";
            this.FontToolStripMenuItem1.Click += new System.EventHandler(this.FontToolStripMenuItem1_Click);
            // 
            // BackgroundToolStripMenuItem
            // 
            this.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem";
            this.BackgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.BackgroundToolStripMenuItem.Text = "Background";
            this.BackgroundToolStripMenuItem.Click += new System.EventHandler(this.BackgroundToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordCountToolStripMenuItem,
            this.GradeLevelToolStripMenuItem,
            this.sentenceCountToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // WordCountToolStripMenuItem
            // 
            this.WordCountToolStripMenuItem.Name = "WordCountToolStripMenuItem";
            this.WordCountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.WordCountToolStripMenuItem.Text = "Word Count";
            this.WordCountToolStripMenuItem.Click += new System.EventHandler(this.WordCountToolStripMenuItem_Click);
            // 
            // GradeLevelToolStripMenuItem
            // 
            this.GradeLevelToolStripMenuItem.Name = "GradeLevelToolStripMenuItem";
            this.GradeLevelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.GradeLevelToolStripMenuItem.Text = "Grade Level";
            this.GradeLevelToolStripMenuItem.Click += new System.EventHandler(this.GradeLevelToolStripMenuItem_Click);
            
            // 
            // sentenceCountToolStripMenuItem
            // 
            this.sentenceCountToolStripMenuItem.Name = "sentenceCountToolStripMenuItem";
            this.sentenceCountToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sentenceCountToolStripMenuItem.Text = "Sentence Count";
            this.sentenceCountToolStripMenuItem.Click += new System.EventHandler(this.sentenceCountToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 780);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Macrosoft Word";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.FontDialog FontDialog1;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CapsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CenterJustifyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LeftJustifyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RightJustifyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem BackgroundToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem WordCountToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GradeLevelToolStripMenuItem;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem sentenceCountToolStripMenuItem;
    }
}

