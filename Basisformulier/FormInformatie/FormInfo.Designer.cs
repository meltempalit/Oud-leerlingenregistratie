namespace FormInformatie
{
    partial class FormInfo
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
            this.txt1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oudleerlingGegevensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ervaringenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblclose = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.Color.Gray;
            this.txt1.Location = new System.Drawing.Point(18, 19);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(491, 230);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "";
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oudleerlingGegevensToolStripMenuItem,
            this.ervaringenToolStripMenuItem,
            this.werkToolStripMenuItem,
            this.werkToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oudleerlingGegevensToolStripMenuItem
            // 
            this.oudleerlingGegevensToolStripMenuItem.Name = "oudleerlingGegevensToolStripMenuItem";
            this.oudleerlingGegevensToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.oudleerlingGegevensToolStripMenuItem.Text = "Oud-leerling gegevens";
            this.oudleerlingGegevensToolStripMenuItem.Click += new System.EventHandler(this.oudleerlingGegevensToolStripMenuItem_Click);
            // 
            // ervaringenToolStripMenuItem
            // 
            this.ervaringenToolStripMenuItem.Name = "ervaringenToolStripMenuItem";
            this.ervaringenToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ervaringenToolStripMenuItem.Text = "Posts";
            this.ervaringenToolStripMenuItem.Click += new System.EventHandler(this.ervaringenToolStripMenuItem_Click);
            // 
            // werkToolStripMenuItem
            // 
            this.werkToolStripMenuItem.Name = "werkToolStripMenuItem";
            this.werkToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.werkToolStripMenuItem.Text = "Vervolgstudies";
            this.werkToolStripMenuItem.Click += new System.EventHandler(this.werkToolStripMenuItem_Click);
            // 
            // werkToolStripMenuItem1
            // 
            this.werkToolStripMenuItem1.Name = "werkToolStripMenuItem1";
            this.werkToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.werkToolStripMenuItem1.Text = "Werk";
            this.werkToolStripMenuItem1.Click += new System.EventHandler(this.werkToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.llblclose);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 272);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gegevens";
            // 
            // llblclose
            // 
            this.llblclose.AutoSize = true;
            this.llblclose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llblclose.Location = new System.Drawing.Point(476, 252);
            this.llblclose.Name = "llblclose";
            this.llblclose.Size = new System.Drawing.Size(39, 13);
            this.llblclose.TabIndex = 40;
            this.llblclose.TabStop = true;
            this.llblclose.Text = "Close";
            this.llblclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblclose_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox3.Image = global::FormInformatie.Properties.Resources.iconfinder_Cross_2001870;
            this.pictureBox3.Location = new System.Drawing.Point(517, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormInformatie.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox2.Location = new System.Drawing.Point(12, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormInformatie.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(553, 376);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oud-leerling gegevens";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oudleerlingGegevensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ervaringenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werkToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem werkToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llblclose;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

