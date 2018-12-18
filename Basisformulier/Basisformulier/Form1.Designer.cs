namespace Basisformulier
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registeerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oudLeerlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registeerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registeerToolStripMenuItem
            // 
            this.registeerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oudLeerlingToolStripMenuItem,
            this.lijstToolStripMenuItem});
            this.registeerToolStripMenuItem.Name = "registeerToolStripMenuItem";
            this.registeerToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registeerToolStripMenuItem.Text = "Registeer";
            // 
            // oudLeerlingToolStripMenuItem
            // 
            this.oudLeerlingToolStripMenuItem.Name = "oudLeerlingToolStripMenuItem";
            this.oudLeerlingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oudLeerlingToolStripMenuItem.Text = "Oud-Leerling";
            this.oudLeerlingToolStripMenuItem.Click += new System.EventHandler(this.oudLeerlingToolStripMenuItem_Click);
            // 
            // lijstToolStripMenuItem
            // 
            this.lijstToolStripMenuItem.Name = "lijstToolStripMenuItem";
            this.lijstToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lijstToolStripMenuItem.Text = "Lijst oud-leerlingen";
            this.lijstToolStripMenuItem.Click += new System.EventHandler(this.lijstToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basisformulier.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox1.Location = new System.Drawing.Point(161, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 150);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(670, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Basis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registeerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oudLeerlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lijstToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

