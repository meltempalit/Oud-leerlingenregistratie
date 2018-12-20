namespace Basisformulier
{
    partial class LijstOudleerlingen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LijstOudleerlingen));
            this.lstLijst = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llblclose = new System.Windows.Forms.LinkLabel();
            this.txtZoek = new System.Windows.Forms.TextBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLijst
            // 
            this.lstLijst.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLijst.ForeColor = System.Drawing.Color.Gray;
            this.lstLijst.FormattingEnabled = true;
            this.lstLijst.ItemHeight = 19;
            this.lstLijst.Location = new System.Drawing.Point(44, 37);
            this.lstLijst.Name = "lstLijst";
            this.lstLijst.Size = new System.Drawing.Size(359, 232);
            this.lstLijst.TabIndex = 0;
            this.lstLijst.SelectedIndexChanged += new System.EventHandler(this.lstLijst_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.lstLijst);
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUD-LEERLINGEN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // llblclose
            // 
            this.llblclose.AutoSize = true;
            this.llblclose.Location = new System.Drawing.Point(432, 412);
            this.llblclose.Name = "llblclose";
            this.llblclose.Size = new System.Drawing.Size(33, 13);
            this.llblclose.TabIndex = 33;
            this.llblclose.TabStop = true;
            this.llblclose.Text = "Close";
            this.llblclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtZoek
            // 
            this.txtZoek.ForeColor = System.Drawing.Color.Silver;
            this.txtZoek.Location = new System.Drawing.Point(205, 71);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(188, 20);
            this.txtZoek.TabIndex = 35;
            this.txtZoek.Text = "Zoeken...";
            this.txtZoek.TextChanged += new System.EventHandler(this.txtZoek_TextChanged);
            this.txtZoek.Enter += new System.EventHandler(this.txtZoek_Enter);
            this.txtZoek.Leave += new System.EventHandler(this.txtZoek_Leave);
            // 
            // btnZoek
            // 
            this.btnZoek.BackColor = System.Drawing.Color.LightGray;
            this.btnZoek.Location = new System.Drawing.Point(399, 71);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 20);
            this.btnZoek.TabIndex = 36;
            this.btnZoek.Text = "ZOEKEN";
            this.btnZoek.UseVisualStyleBackColor = false;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            this.btnZoek.MouseLeave += new System.EventHandler(this.btnZoek_MouseLeave);
            this.btnZoek.MouseHover += new System.EventHandler(this.btnZoek_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basisformulier.Properties.Resources.VHSJ;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 79);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // LijstOudleerlingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(502, 444);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.txtZoek);
            this.Controls.Add(this.llblclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LijstOudleerlingen";
            this.Text = "LijstOudleerlingen";
            this.Load += new System.EventHandler(this.LijstOudleerlingen_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLijst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblclose;
        private System.Windows.Forms.TextBox txtZoek;
        private System.Windows.Forms.Button btnZoek;
    }
}