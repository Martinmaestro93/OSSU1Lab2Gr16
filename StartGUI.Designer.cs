
namespace Hogskolan_Sarob
{
    partial class StartGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillTaBortLärareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraLärarlagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraKurserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillStudenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.läggTillTaBortLärareToolStripMenuItem,
            this.hanteraLärarlagToolStripMenuItem,
            this.hanteraKurserToolStripMenuItem,
            this.läggTillStudenterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.läggTillTaBortLärareToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // läggTillTaBortLärareToolStripMenuItem
            // 
            this.läggTillTaBortLärareToolStripMenuItem.Name = "läggTillTaBortLärareToolStripMenuItem";
            this.läggTillTaBortLärareToolStripMenuItem.Size = new System.Drawing.Size(174, 25);
            this.läggTillTaBortLärareToolStripMenuItem.Text = "Lägg till/Ta bort lärare";
            this.läggTillTaBortLärareToolStripMenuItem.Click += new System.EventHandler(this.läggTillTaBortLärareToolStripMenuItem_Click);
            // 
            // hanteraLärarlagToolStripMenuItem
            // 
            this.hanteraLärarlagToolStripMenuItem.Name = "hanteraLärarlagToolStripMenuItem";
            this.hanteraLärarlagToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.hanteraLärarlagToolStripMenuItem.Text = "Hantera lärarlag";
            this.hanteraLärarlagToolStripMenuItem.Click += new System.EventHandler(this.hanteraLärarlagToolStripMenuItem_Click);
            // 
            // hanteraKurserToolStripMenuItem
            // 
            this.hanteraKurserToolStripMenuItem.Name = "hanteraKurserToolStripMenuItem";
            this.hanteraKurserToolStripMenuItem.Size = new System.Drawing.Size(126, 25);
            this.hanteraKurserToolStripMenuItem.Text = "Hantera Kurser";
            this.hanteraKurserToolStripMenuItem.Click += new System.EventHandler(this.hanteraKurserToolStripMenuItem_Click);
            // 
            // läggTillStudenterToolStripMenuItem
            // 
            this.läggTillStudenterToolStripMenuItem.Name = "läggTillStudenterToolStripMenuItem";
            this.läggTillStudenterToolStripMenuItem.Size = new System.Drawing.Size(147, 25);
            this.läggTillStudenterToolStripMenuItem.Text = "Lägg till studenter";
            this.läggTillStudenterToolStripMenuItem.DoubleClick += new System.EventHandler(this.läggTillStudenterToolStripMenuItem_DoubleClick);
            // 
            // StartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 818);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 858);
            this.Name = "StartGUI";
            this.Text = "StartGUI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillTaBortLärareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraLärarlagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraKurserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillStudenterToolStripMenuItem;
    }
}