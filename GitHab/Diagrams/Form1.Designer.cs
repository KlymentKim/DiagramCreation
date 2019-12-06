namespace Diagrams
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Rect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Line = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Ellips = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Figure = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Color = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Rect,
            this.toolStripButton_Line,
            this.toolStripButton_Ellips,
            this.toolStripButton_Figure,
            this.toolStripButton1,
            this.toolStripButton_Color});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Rect
            // 
            this.toolStripButton_Rect.CheckOnClick = true;
            this.toolStripButton_Rect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Rect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Rect.Image")));
            this.toolStripButton_Rect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Rect.Name = "toolStripButton_Rect";
            this.toolStripButton_Rect.Size = new System.Drawing.Size(34, 22);
            this.toolStripButton_Rect.Text = "Rect";
            this.toolStripButton_Rect.Click += new System.EventHandler(this.toolStripButton_Rect_Click);
            // 
            // toolStripButton_Line
            // 
            this.toolStripButton_Line.CheckOnClick = true;
            this.toolStripButton_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Line.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Line.Image")));
            this.toolStripButton_Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Line.Name = "toolStripButton_Line";
            this.toolStripButton_Line.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton_Line.Text = "Line";
            this.toolStripButton_Line.Click += new System.EventHandler(this.toolStripButton_Line_Click);
            // 
            // toolStripButton_Ellips
            // 
            this.toolStripButton_Ellips.CheckOnClick = true;
            this.toolStripButton_Ellips.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Ellips.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Ellips.Image")));
            this.toolStripButton_Ellips.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Ellips.Name = "toolStripButton_Ellips";
            this.toolStripButton_Ellips.Size = new System.Drawing.Size(38, 22);
            this.toolStripButton_Ellips.Text = "Ellips";
            this.toolStripButton_Ellips.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton_Figure
            // 
            this.toolStripButton_Figure.CheckOnClick = true;
            this.toolStripButton_Figure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Figure.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Figure.Image")));
            this.toolStripButton_Figure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Figure.Name = "toolStripButton_Figure";
            this.toolStripButton_Figure.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton_Figure.Text = "FigLine";
            this.toolStripButton_Figure.Click += new System.EventHandler(this.toolStripButton_Figure_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 436);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.toolStripButton_Figure_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Clear";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton_Color
            // 
            this.toolStripButton_Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Color.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Color.Image")));
            this.toolStripButton_Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Color.Name = "toolStripButton_Color";
            this.toolStripButton_Color.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_Color.Text = "toolStripButton2";
            this.toolStripButton_Color.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Rect;
        private System.Windows.Forms.ToolStripButton toolStripButton_Line;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Ellips;
        private System.Windows.Forms.ToolStripButton toolStripButton_Figure;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Color;
    }
}

