namespace FormPosts
{
    partial class Mededeling
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
            this.btnToevoegenHerinnering = new System.Windows.Forms.Button();
            this.txtMededeling = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToevoegenHerinnering
            // 
            this.btnToevoegenHerinnering.Location = new System.Drawing.Point(254, 234);
            this.btnToevoegenHerinnering.Name = "btnToevoegenHerinnering";
            this.btnToevoegenHerinnering.Size = new System.Drawing.Size(152, 49);
            this.btnToevoegenHerinnering.TabIndex = 8;
            this.btnToevoegenHerinnering.Text = "VOLGENDE";
            this.btnToevoegenHerinnering.UseVisualStyleBackColor = true;
            this.btnToevoegenHerinnering.Click += new System.EventHandler(this.btnToevoegenHerinnering_Click);
            // 
            // txtMededeling
            // 
            this.txtMededeling.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtMededeling.Location = new System.Drawing.Point(26, 19);
            this.txtMededeling.Multiline = true;
            this.txtMededeling.Name = "txtMededeling";
            this.txtMededeling.Size = new System.Drawing.Size(380, 209);
            this.txtMededeling.TabIndex = 7;
            this.txtMededeling.TextChanged += new System.EventHandler(this.txtMededeling_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormPosts.Properties.Resources.VHSJ;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 79);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.Location = new System.Drawing.Point(199, 270);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(49, 13);
            this.lnklAnnu.TabIndex = 34;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMededeling);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnToevoegenHerinnering);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 327);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEDEDELING";
            // 
            // Mededeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Mededeling";
            this.Text = "Mededeling";
            this.Load += new System.EventHandler(this.Mededeling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegenHerinnering;
        private System.Windows.Forms.TextBox txtMededeling;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}