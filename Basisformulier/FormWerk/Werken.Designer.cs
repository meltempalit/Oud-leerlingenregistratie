namespace FormWerk
{
    partial class Werken
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbljob = new System.Windows.Forms.Label();
            this.lblvest = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblbed = new System.Windows.Forms.Label();
            this.txtVestiging = new System.Windows.Forms.TextBox();
            this.txtStartjaar = new System.Windows.Forms.TextBox();
            this.txtBedrijf = new System.Windows.Forms.TextBox();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbljob);
            this.groupBox1.Controls.Add(this.lblvest);
            this.groupBox1.Controls.Add(this.lblstart);
            this.groupBox1.Controls.Add(this.lblbed);
            this.groupBox1.Controls.Add(this.txtVestiging);
            this.groupBox1.Controls.Add(this.txtStartjaar);
            this.groupBox1.Controls.Add(this.txtBedrijf);
            this.groupBox1.Controls.Add(this.pcbox);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtJob);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnVolgende);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 395);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WERK";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormWerk.Properties.Resources.work;
            this.pictureBox2.Location = new System.Drawing.Point(135, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 46;
            // 
            // lbljob
            // 
            this.lbljob.AutoSize = true;
            this.lbljob.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljob.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbljob.Location = new System.Drawing.Point(90, 88);
            this.lbljob.Name = "lbljob";
            this.lbljob.Size = new System.Drawing.Size(28, 17);
            this.lbljob.TabIndex = 45;
            this.lbljob.Text = "Job*";
            this.lbljob.Visible = false;
            // 
            // lblvest
            // 
            this.lblvest.AutoSize = true;
            this.lblvest.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblvest.Location = new System.Drawing.Point(90, 196);
            this.lblvest.Name = "lblvest";
            this.lblvest.Size = new System.Drawing.Size(54, 17);
            this.lblvest.TabIndex = 44;
            this.lblvest.Text = "Vestiging*";
            this.lblvest.Visible = false;
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstart.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblstart.Location = new System.Drawing.Point(90, 249);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(51, 17);
            this.lblstart.TabIndex = 43;
            this.lblstart.Text = "Startjaar*";
            this.lblstart.Visible = false;
            // 
            // lblbed
            // 
            this.lblbed.AutoSize = true;
            this.lblbed.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbed.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblbed.Location = new System.Drawing.Point(90, 143);
            this.lblbed.Name = "lblbed";
            this.lblbed.Size = new System.Drawing.Size(42, 17);
            this.lblbed.TabIndex = 42;
            this.lblbed.Text = "Bedrijf*";
            this.lblbed.Visible = false;
            // 
            // txtVestiging
            // 
            this.txtVestiging.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVestiging.ForeColor = System.Drawing.Color.Silver;
            this.txtVestiging.Location = new System.Drawing.Point(87, 215);
            this.txtVestiging.Multiline = true;
            this.txtVestiging.Name = "txtVestiging";
            this.txtVestiging.Size = new System.Drawing.Size(233, 34);
            this.txtVestiging.TabIndex = 41;
            this.txtVestiging.Text = "België, GENT";
            this.txtVestiging.TextChanged += new System.EventHandler(this.txtVestiging_TextChanged);
            this.txtVestiging.Enter += new System.EventHandler(this.txtVestiging_Enter);
            this.txtVestiging.Leave += new System.EventHandler(this.txtVestiging_Leave);
            // 
            // txtStartjaar
            // 
            this.txtStartjaar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartjaar.ForeColor = System.Drawing.Color.Silver;
            this.txtStartjaar.Location = new System.Drawing.Point(87, 268);
            this.txtStartjaar.Multiline = true;
            this.txtStartjaar.Name = "txtStartjaar";
            this.txtStartjaar.Size = new System.Drawing.Size(233, 34);
            this.txtStartjaar.TabIndex = 40;
            this.txtStartjaar.Text = "Typ hier uw startjaar...";
            this.txtStartjaar.TextChanged += new System.EventHandler(this.txtStartjaar_TextChanged);
            this.txtStartjaar.Enter += new System.EventHandler(this.txtStartjaar_Enter);
            this.txtStartjaar.Leave += new System.EventHandler(this.txtStartjaar_Leave);
            // 
            // txtBedrijf
            // 
            this.txtBedrijf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBedrijf.ForeColor = System.Drawing.Color.Silver;
            this.txtBedrijf.Location = new System.Drawing.Point(87, 161);
            this.txtBedrijf.Multiline = true;
            this.txtBedrijf.Name = "txtBedrijf";
            this.txtBedrijf.Size = new System.Drawing.Size(233, 34);
            this.txtBedrijf.TabIndex = 39;
            this.txtBedrijf.Text = "Typ hier voor welk bedrijf u werkt/ zelfstandig";
            this.txtBedrijf.TextChanged += new System.EventHandler(this.txtBedrijf_TextChanged);
            this.txtBedrijf.Enter += new System.EventHandler(this.txtBedrijf_Enter);
            this.txtBedrijf.Leave += new System.EventHandler(this.txtBedrijf_Leave);
            // 
            // pcbox
            // 
            this.pcbox.Image = global::FormWerk.Properties.Resources.icons8_double_tick_48;
            this.pcbox.Location = new System.Drawing.Point(343, 308);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(25, 23);
            this.pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbox.TabIndex = 37;
            this.pcbox.TabStop = false;
            this.pcbox.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 311);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 23);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Visible = false;
            // 
            // txtJob
            // 
            this.txtJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJob.ForeColor = System.Drawing.Color.Silver;
            this.txtJob.Location = new System.Drawing.Point(87, 106);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(233, 34);
            this.txtJob.TabIndex = 35;
            this.txtJob.Text = "vb. Industrieel ingenieur";
            this.txtJob.TextChanged += new System.EventHandler(this.txtSchool_TextChanged);
            this.txtJob.Enter += new System.EventHandler(this.txtJob_Enter);
            this.txtJob.Leave += new System.EventHandler(this.txtJob_Leave);
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnklAnnu.Location = new System.Drawing.Point(109, 354);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(58, 13);
            this.lnklAnnu.TabIndex = 33;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // btnVolgende
            // 
            this.btnVolgende.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolgende.Location = new System.Drawing.Point(168, 344);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(152, 27);
            this.btnVolgende.TabIndex = 5;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            this.btnVolgende.MouseLeave += new System.EventHandler(this.btnVolgende_MouseLeave);
            this.btnVolgende.MouseHover += new System.EventHandler(this.btnVolgende_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormWerk.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(-1, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 24);
            this.panel2.TabIndex = 48;
            // 
            // Werken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(406, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Werken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Werken_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbljob;
        private System.Windows.Forms.Label lblvest;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblbed;
        private System.Windows.Forms.TextBox txtVestiging;
        private System.Windows.Forms.TextBox txtStartjaar;
        private System.Windows.Forms.TextBox txtBedrijf;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
    }
}

