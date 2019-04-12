namespace FormVervolgstudies
{
    partial class Vervolgstudies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vervolgstudies));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblschool = new System.Windows.Forms.Label();
            this.lblafstj = new System.Windows.Forms.Label();
            this.lbldip = new System.Windows.Forms.Label();
            this.lblafstrichting = new System.Windows.Forms.Label();
            this.txtAfstudeerjaar = new System.Windows.Forms.TextBox();
            this.txtDiploma = new System.Windows.Forms.TextBox();
            this.txtRichtingVervolg = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblschool);
            this.groupBox1.Controls.Add(this.lblafstj);
            this.groupBox1.Controls.Add(this.lbldip);
            this.groupBox1.Controls.Add(this.lblafstrichting);
            this.groupBox1.Controls.Add(this.txtAfstudeerjaar);
            this.groupBox1.Controls.Add(this.txtDiploma);
            this.groupBox1.Controls.Add(this.txtRichtingVervolg);
            this.groupBox1.Controls.Add(this.pcbox);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtSchool);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnVolgende);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(14, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 400);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDIES";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblschool
            // 
            this.lblschool.AutoSize = true;
            this.lblschool.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschool.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblschool.Location = new System.Drawing.Point(115, 77);
            this.lblschool.Name = "lblschool";
            this.lblschool.Size = new System.Drawing.Size(41, 17);
            this.lblschool.TabIndex = 45;
            this.lblschool.Text = "School*";
            this.lblschool.Visible = false;
            // 
            // lblafstj
            // 
            this.lblafstj.AutoSize = true;
            this.lblafstj.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafstj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblafstj.Location = new System.Drawing.Point(114, 187);
            this.lblafstj.Name = "lblafstj";
            this.lblafstj.Size = new System.Drawing.Size(71, 17);
            this.lblafstj.TabIndex = 44;
            this.lblafstj.Text = "Afstudeerjaar*";
            this.lblafstj.Visible = false;
            // 
            // lbldip
            // 
            this.lbldip.AutoSize = true;
            this.lbldip.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldip.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbldip.Location = new System.Drawing.Point(115, 239);
            this.lbldip.Name = "lbldip";
            this.lbldip.Size = new System.Drawing.Size(50, 17);
            this.lbldip.TabIndex = 43;
            this.lbldip.Text = "Diploma*";
            this.lbldip.Visible = false;
            this.lbldip.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblafstrichting
            // 
            this.lblafstrichting.AutoSize = true;
            this.lblafstrichting.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafstrichting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblafstrichting.Location = new System.Drawing.Point(114, 132);
            this.lblafstrichting.Name = "lblafstrichting";
            this.lblafstrichting.Size = new System.Drawing.Size(92, 17);
            this.lblafstrichting.TabIndex = 42;
            this.lblafstrichting.Text = "Aftstudeerrichting*";
            this.lblafstrichting.Visible = false;
            // 
            // txtAfstudeerjaar
            // 
            this.txtAfstudeerjaar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAfstudeerjaar.ForeColor = System.Drawing.Color.Silver;
            this.txtAfstudeerjaar.Location = new System.Drawing.Point(118, 201);
            this.txtAfstudeerjaar.Multiline = true;
            this.txtAfstudeerjaar.Name = "txtAfstudeerjaar";
            this.txtAfstudeerjaar.Size = new System.Drawing.Size(183, 32);
            this.txtAfstudeerjaar.TabIndex = 41;
            this.txtAfstudeerjaar.Text = "Typ hier in welk jaar u bent afgestudeerd...";
            this.txtAfstudeerjaar.Enter += new System.EventHandler(this.txtAfstudeerjaar_Enter);
            this.txtAfstudeerjaar.Leave += new System.EventHandler(this.txtAfstudeerjaar_Leave);
            // 
            // txtDiploma
            // 
            this.txtDiploma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiploma.ForeColor = System.Drawing.Color.Silver;
            this.txtDiploma.Location = new System.Drawing.Point(117, 256);
            this.txtDiploma.Multiline = true;
            this.txtDiploma.Name = "txtDiploma";
            this.txtDiploma.Size = new System.Drawing.Size(187, 32);
            this.txtDiploma.TabIndex = 40;
            this.txtDiploma.Text = "Typ hier welk diploma u heeft behaald...";
            this.txtDiploma.Enter += new System.EventHandler(this.txtDiploma_Enter);
            this.txtDiploma.Leave += new System.EventHandler(this.txtDiploma_Leave);
            // 
            // txtRichtingVervolg
            // 
            this.txtRichtingVervolg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRichtingVervolg.ForeColor = System.Drawing.Color.Silver;
            this.txtRichtingVervolg.Location = new System.Drawing.Point(118, 147);
            this.txtRichtingVervolg.Multiline = true;
            this.txtRichtingVervolg.Name = "txtRichtingVervolg";
            this.txtRichtingVervolg.Size = new System.Drawing.Size(183, 32);
            this.txtRichtingVervolg.TabIndex = 39;
            this.txtRichtingVervolg.Text = "Typ hier uw afstudeerrichting...";
            this.txtRichtingVervolg.Enter += new System.EventHandler(this.txtRichtingVervolg_Enter);
            this.txtRichtingVervolg.Leave += new System.EventHandler(this.txtRichtingVervolg_Leave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 298);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(367, 23);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // txtSchool
            // 
            this.txtSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSchool.ForeColor = System.Drawing.Color.Silver;
            this.txtSchool.Location = new System.Drawing.Point(118, 95);
            this.txtSchool.Multiline = true;
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(183, 34);
            this.txtSchool.TabIndex = 35;
            this.txtSchool.Text = "Typ hier de naam van uw hogeschool/ universiteit...";
            this.txtSchool.TextChanged += new System.EventHandler(this.txtSchool_TextChanged);
            this.txtSchool.Enter += new System.EventHandler(this.txtSchool_Enter);
            this.txtSchool.Leave += new System.EventHandler(this.txtSchool_Leave);
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnklAnnu.Location = new System.Drawing.Point(172, 356);
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
            this.btnVolgende.Location = new System.Drawing.Point(236, 342);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(152, 27);
            this.btnVolgende.TabIndex = 5;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            this.btnVolgende.Click += new System.EventHandler(this.btnVolgende_Click);
            this.btnVolgende.Leave += new System.EventHandler(this.btnVolgende_Leave);
            this.btnVolgende.MouseLeave += new System.EventHandler(this.btnVolgende_MouseLeave);
            this.btnVolgende.MouseHover += new System.EventHandler(this.btnVolgende_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 19);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormVervolgstudies.Properties.Resources.study;
            this.pictureBox2.Location = new System.Drawing.Point(162, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormVervolgstudies.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pcbox
            // 
            this.pcbox.Location = new System.Drawing.Point(394, 306);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(16, 16);
            this.pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbox.TabIndex = 37;
            this.pcbox.TabStop = false;
            this.pcbox.Visible = false;
            // 
            // Vervolgstudies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(451, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vervolgstudies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Vervolgstudies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiploma;
        private System.Windows.Forms.TextBox txtRichtingVervolg;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtAfstudeerjaar;
        private System.Windows.Forms.Label lblafstrichting;
        private System.Windows.Forms.Label lbldip;
        private System.Windows.Forms.Label lblschool;
        private System.Windows.Forms.Label lblafstj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

