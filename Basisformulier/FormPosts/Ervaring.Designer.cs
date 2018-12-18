namespace FormPosts
{
    partial class Ervaring
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
            this.btnToevoegenErvaring = new System.Windows.Forms.Button();
            this.txtErvaring = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToevoegenErvaring
            // 
            this.btnToevoegenErvaring.Location = new System.Drawing.Point(251, 249);
            this.btnToevoegenErvaring.Name = "btnToevoegenErvaring";
            this.btnToevoegenErvaring.Size = new System.Drawing.Size(152, 49);
            this.btnToevoegenErvaring.TabIndex = 5;
            this.btnToevoegenErvaring.Text = "VOLGENDE";
            this.btnToevoegenErvaring.UseVisualStyleBackColor = true;
            this.btnToevoegenErvaring.Click += new System.EventHandler(this.btnToevoegenErvaring_Click);
            // 
            // txtErvaring
            // 
            this.txtErvaring.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtErvaring.Location = new System.Drawing.Point(23, 34);
            this.txtErvaring.Multiline = true;
            this.txtErvaring.Name = "txtErvaring";
            this.txtErvaring.Size = new System.Drawing.Size(380, 209);
            this.txtErvaring.TabIndex = 4;
            this.txtErvaring.TextChanged += new System.EventHandler(this.txtErvaring_TextChanged);
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
            this.lnklAnnu.Location = new System.Drawing.Point(196, 285);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(49, 13);
            this.lnklAnnu.TabIndex = 33;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtErvaring);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnToevoegenErvaring);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 318);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ERVARINGEN";
            // 
            // Ervaring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ervaring";
            this.Text = "Ervaring";
            this.Load += new System.EventHandler(this.Ervaring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegenErvaring;
        private System.Windows.Forms.TextBox txtErvaring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}