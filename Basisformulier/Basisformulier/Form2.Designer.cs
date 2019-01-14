namespace Basisformulier
{
    partial class Form2
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
            this.btnReg = new System.Windows.Forms.Button();
            this.btnLijst = new System.Windows.Forms.Button();
            this.llblclose = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReg.Location = new System.Drawing.Point(91, 114);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(266, 49);
            this.btnReg.TabIndex = 35;
            this.btnReg.Text = "REGISTREER";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            this.btnReg.MouseLeave += new System.EventHandler(this.btnReg_MouseLeave);
            this.btnReg.MouseHover += new System.EventHandler(this.btnReg_MouseHover);
            // 
            // btnLijst
            // 
            this.btnLijst.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLijst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijst.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLijst.Location = new System.Drawing.Point(91, 184);
            this.btnLijst.Name = "btnLijst";
            this.btnLijst.Size = new System.Drawing.Size(266, 49);
            this.btnLijst.TabIndex = 37;
            this.btnLijst.Text = "LIJST";
            this.btnLijst.UseVisualStyleBackColor = false;
            this.btnLijst.Click += new System.EventHandler(this.btnLijst_Click);
            this.btnLijst.MouseLeave += new System.EventHandler(this.btnLijst_MouseLeave);
            this.btnLijst.MouseHover += new System.EventHandler(this.btnLijst_MouseHover);
            // 
            // llblclose
            // 
            this.llblclose.AutoSize = true;
            this.llblclose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llblclose.Location = new System.Drawing.Point(382, 257);
            this.llblclose.Name = "llblclose";
            this.llblclose.Size = new System.Drawing.Size(33, 13);
            this.llblclose.TabIndex = 41;
            this.llblclose.TabStop = true;
            this.llblclose.Text = "Close";
            this.llblclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblclose_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.llblclose);
            this.panel1.Controls.Add(this.btnLijst);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(57, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 279);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basisformulier.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Basisformulier.Properties.Resources.iconfinder_Cross_2001870;
            this.pictureBox2.Location = new System.Drawing.Point(491, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(534, 382);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLijst;
        private System.Windows.Forms.LinkLabel llblclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}