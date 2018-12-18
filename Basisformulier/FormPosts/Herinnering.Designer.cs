namespace FormPosts
{
    partial class Herinnering
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
            this.txtHerinneringen = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "VOLGENDE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHerinneringen
            // 
            this.txtHerinneringen.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtHerinneringen.Location = new System.Drawing.Point(24, 31);
            this.txtHerinneringen.Multiline = true;
            this.txtHerinneringen.Name = "txtHerinneringen";
            this.txtHerinneringen.Size = new System.Drawing.Size(380, 209);
            this.txtHerinneringen.TabIndex = 7;
            this.txtHerinneringen.TextChanged += new System.EventHandler(this.txtHerinneringen_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormPosts.Properties.Resources.VHSJ;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 79);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.Location = new System.Drawing.Point(197, 282);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(49, 13);
            this.lnklAnnu.TabIndex = 33;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHerinneringen);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 318);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HERINNERINGEN";
            // 
            // Herinnering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Herinnering";
            this.Text = "Herinnering";
            this.Load += new System.EventHandler(this.Herinnering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHerinneringen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}