namespace Basisformulier
{
    partial class ContactAdministrator
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
            this.button1 = new System.Windows.Forms.Button();
            this.textVN = new System.Windows.Forms.TextBox();
            this.textOnderwerp = new System.Windows.Forms.TextBox();
            this.textTekst = new System.Windows.Forms.TextBox();
            this.textPWMAIL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llblclose = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verzend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textVN
            // 
            this.textVN.Location = new System.Drawing.Point(16, 39);
            this.textVN.Name = "textVN";
            this.textVN.Size = new System.Drawing.Size(174, 20);
            this.textVN.TabIndex = 1;
            this.textVN.Text = "oudleerlingenproject@gmail.com";
            // 
            // textOnderwerp
            // 
            this.textOnderwerp.Location = new System.Drawing.Point(16, 122);
            this.textOnderwerp.Name = "textOnderwerp";
            this.textOnderwerp.Size = new System.Drawing.Size(174, 20);
            this.textOnderwerp.TabIndex = 2;
            this.textOnderwerp.Text = "Onderwerp";
            // 
            // textTekst
            // 
            this.textTekst.Location = new System.Drawing.Point(16, 160);
            this.textTekst.Multiline = true;
            this.textTekst.Name = "textTekst";
            this.textTekst.Size = new System.Drawing.Size(174, 80);
            this.textTekst.TabIndex = 3;
            this.textTekst.Text = "Typ hier uw tekst...";
            // 
            // textPWMAIL
            // 
            this.textPWMAIL.Location = new System.Drawing.Point(16, 79);
            this.textPWMAIL.Name = "textPWMAIL";
            this.textPWMAIL.Size = new System.Drawing.Size(174, 20);
            this.textPWMAIL.TabIndex = 4;
            this.textPWMAIL.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.textVN);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textTekst);
            this.groupBox1.Controls.Add(this.textPWMAIL);
            this.groupBox1.Controls.Add(this.textOnderwerp);
            this.groupBox1.Location = new System.Drawing.Point(21, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Admin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basisformulier.Properties.Resources.VHSJ1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // llblclose
            // 
            this.llblclose.AutoSize = true;
            this.llblclose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llblclose.Location = new System.Drawing.Point(207, 366);
            this.llblclose.Name = "llblclose";
            this.llblclose.Size = new System.Drawing.Size(33, 13);
            this.llblclose.TabIndex = 41;
            this.llblclose.TabStop = true;
            this.llblclose.Text = "Close";
            this.llblclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblclose_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(-8, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 24);
            this.panel2.TabIndex = 42;
            // 
            // ContactAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.llblclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactAdministrator";
            this.Text = "ContactAdministrator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textVN;
        private System.Windows.Forms.TextBox textOnderwerp;
        private System.Windows.Forms.TextBox textTekst;
        private System.Windows.Forms.TextBox textPWMAIL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblclose;
        private System.Windows.Forms.Panel panel2;
    }
}