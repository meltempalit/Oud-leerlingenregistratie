namespace Lijst
{
    partial class frmLijst
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
            this.btnZoek = new System.Windows.Forms.Button();
            this.txtZoek = new System.Windows.Forms.TextBox();
            this.llblclose = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLijst = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoek
            // 
            this.btnZoek.BackColor = System.Drawing.Color.LightGray;
            this.btnZoek.Location = new System.Drawing.Point(429, 50);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 20);
            this.btnZoek.TabIndex = 41;
            this.btnZoek.Text = "ZOEKEN";
            this.btnZoek.UseVisualStyleBackColor = false;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            this.btnZoek.MouseLeave += new System.EventHandler(this.btnZoek_MouseLeave);
            this.btnZoek.MouseHover += new System.EventHandler(this.btnZoek_MouseHover);
            // 
            // txtZoek
            // 
            this.txtZoek.ForeColor = System.Drawing.Color.Silver;
            this.txtZoek.Location = new System.Drawing.Point(235, 51);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(188, 20);
            this.txtZoek.TabIndex = 40;
            this.txtZoek.Text = "Zoeken...";
            this.txtZoek.Enter += new System.EventHandler(this.txtZoek_Enter);
            this.txtZoek.Leave += new System.EventHandler(this.txtZoek_Leave);
            // 
            // llblclose
            // 
            this.llblclose.AutoSize = true;
            this.llblclose.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.llblclose.Location = new System.Drawing.Point(485, 423);
            this.llblclose.Name = "llblclose";
            this.llblclose.Size = new System.Drawing.Size(33, 13);
            this.llblclose.TabIndex = 39;
            this.llblclose.TabStop = true;
            this.llblclose.Text = "Close";
            this.llblclose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblclose_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnVerwijder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstLijst);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 333);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUD-LEERLINGEN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(130, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 46;
            this.button1.Text = "EXPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Enabled = false;
            this.btnVerwijder.ForeColor = System.Drawing.Color.Black;
            this.btnVerwijder.Location = new System.Drawing.Point(16, 294);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(108, 26);
            this.btnVerwijder.TabIndex = 45;
            this.btnVerwijder.Text = "VERWIJDER";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            this.btnVerwijder.MouseLeave += new System.EventHandler(this.btnVerwijder_MouseLeave);
            this.btnVerwijder.MouseHover += new System.EventHandler(this.btnVerwijder_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klik tweemaal op een oud-leerling voor meer informatie";
            // 
            // lstLijst
            // 
            this.lstLijst.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLijst.ForeColor = System.Drawing.Color.DimGray;
            this.lstLijst.FormattingEnabled = true;
            this.lstLijst.ItemHeight = 19;
            this.lstLijst.Location = new System.Drawing.Point(16, 49);
            this.lstLijst.Name = "lstLijst";
            this.lstLijst.Size = new System.Drawing.Size(489, 232);
            this.lstLijst.TabIndex = 0;
            this.lstLijst.SelectedIndexChanged += new System.EventHandler(this.lstLijst_SelectedIndexChanged);
            this.lstLijst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstLijst_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lijst.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 23);
            this.panel1.TabIndex = 46;
            // 
            // frmLijst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(550, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.txtZoek);
            this.Controls.Add(this.llblclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLijst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLijst_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.TextBox txtZoek;
        private System.Windows.Forms.LinkLabel llblclose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLijst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

