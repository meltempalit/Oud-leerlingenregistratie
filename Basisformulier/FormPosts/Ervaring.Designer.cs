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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ervaring));
            this.btnToevoegenErvaring = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtErvaring = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToevoegenErvaring
            // 
            this.btnToevoegenErvaring.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenErvaring.Location = new System.Drawing.Point(251, 191);
            this.btnToevoegenErvaring.Name = "btnToevoegenErvaring";
            this.btnToevoegenErvaring.Size = new System.Drawing.Size(152, 37);
            this.btnToevoegenErvaring.TabIndex = 5;
            this.btnToevoegenErvaring.Text = "Volgende";
            this.btnToevoegenErvaring.UseVisualStyleBackColor = true;
            this.btnToevoegenErvaring.Click += new System.EventHandler(this.btnToevoegenErvaring_Click);
            this.btnToevoegenErvaring.MouseLeave += new System.EventHandler(this.btnToevoegenErvaring_MouseLeave);
            this.btnToevoegenErvaring.MouseHover += new System.EventHandler(this.btnToevoegenErvaring_MouseHover);
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
            this.lnklAnnu.Location = new System.Drawing.Point(196, 215);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(49, 13);
            this.lnklAnnu.TabIndex = 33;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.txtErvaring);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnToevoegenErvaring);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 252);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ERVARINGEN";
            // 
            // txtErvaring
            // 
            this.txtErvaring.ForeColor = System.Drawing.Color.Silver;
            this.txtErvaring.Location = new System.Drawing.Point(17, 22);
            this.txtErvaring.Multiline = true;
            this.txtErvaring.Name = "txtErvaring";
            this.txtErvaring.Size = new System.Drawing.Size(386, 137);
            this.txtErvaring.TabIndex = 35;
            this.txtErvaring.Text = "Typ hier uw loopbaan/ ervaringen...";
            this.txtErvaring.TextChanged += new System.EventHandler(this.txtErvaring_TextChanged_1);
            this.txtErvaring.Enter += new System.EventHandler(this.txtErvaring_Enter_1);
            this.txtErvaring.Leave += new System.EventHandler(this.txtErvaring_Leave_1);
            // 
            // Ervaring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(451, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ervaring";
            this.Load += new System.EventHandler(this.Ervaring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegenErvaring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtErvaring;
    }
}