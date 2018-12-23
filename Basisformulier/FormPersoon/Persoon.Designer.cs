namespace FormPersoon
{
    partial class Persoon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Persoon));
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRichting = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtFamilienaam = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblAfstudeerj = new System.Windows.Forms.Label();
            this.lblafstrichting = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGeboorte = new System.Windows.Forms.Label();
            this.lblFamilienaam = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.grpbReg = new System.Windows.Forms.GroupBox();
            this.txtAfst = new System.Windows.Forms.TextBox();
            this.txtGeboorte = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboLand = new System.Windows.Forms.ComboBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpbReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.BackColor = System.Drawing.Color.Lavender;
            this.btnRegistreer.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreer.Location = new System.Drawing.Point(220, 508);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(145, 44);
            this.btnRegistreer.TabIndex = 29;
            this.btnRegistreer.Text = "Doorgaan";
            this.btnRegistreer.UseVisualStyleBackColor = false;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            this.btnRegistreer.MouseLeave += new System.EventHandler(this.btnRegistreer_MouseLeave);
            this.btnRegistreer.MouseHover += new System.EventHandler(this.btnRegistreer_MouseHover);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei Light", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(165, 344);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 26);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.Text = "someone@example.com";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtRichting
            // 
            this.txtRichting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRichting.ForeColor = System.Drawing.Color.Silver;
            this.txtRichting.Location = new System.Drawing.Point(165, 387);
            this.txtRichting.Multiline = true;
            this.txtRichting.Name = "txtRichting";
            this.txtRichting.Size = new System.Drawing.Size(200, 26);
            this.txtRichting.TabIndex = 25;
            this.txtRichting.TextChanged += new System.EventHandler(this.txtRichting_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.Silver;
            this.txtTel.Location = new System.Drawing.Point(165, 298);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 26);
            this.txtTel.TabIndex = 24;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilienaam.ForeColor = System.Drawing.Color.Silver;
            this.txtFamilienaam.Location = new System.Drawing.Point(165, 180);
            this.txtFamilienaam.Multiline = true;
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(200, 26);
            this.txtFamilienaam.TabIndex = 23;
            // 
            // txtNaam
            // 
            this.txtNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.ForeColor = System.Drawing.Color.Silver;
            this.txtNaam.Location = new System.Drawing.Point(165, 139);
            this.txtNaam.Multiline = true;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 26);
            this.txtNaam.TabIndex = 22;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // lblAfstudeerj
            // 
            this.lblAfstudeerj.AutoSize = true;
            this.lblAfstudeerj.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfstudeerj.Location = new System.Drawing.Point(49, 436);
            this.lblAfstudeerj.Name = "lblAfstudeerj";
            this.lblAfstudeerj.Size = new System.Drawing.Size(83, 20);
            this.lblAfstudeerj.TabIndex = 21;
            this.lblAfstudeerj.Text = "Afstudeerjaar*";
            this.lblAfstudeerj.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblafstrichting
            // 
            this.lblafstrichting.AutoSize = true;
            this.lblafstrichting.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafstrichting.Location = new System.Drawing.Point(49, 393);
            this.lblafstrichting.Name = "lblafstrichting";
            this.lblafstrichting.Size = new System.Drawing.Size(108, 20);
            this.lblafstrichting.TabIndex = 20;
            this.lblafstrichting.Text = "Aftstudeerrichting*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefoonnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail";
            // 
            // lblGeboorte
            // 
            this.lblGeboorte.AutoSize = true;
            this.lblGeboorte.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeboorte.Location = new System.Drawing.Point(49, 229);
            this.lblGeboorte.Name = "lblGeboorte";
            this.lblGeboorte.Size = new System.Drawing.Size(96, 20);
            this.lblGeboorte.TabIndex = 17;
            this.lblGeboorte.Text = "Geboortedatum*";
            // 
            // lblFamilienaam
            // 
            this.lblFamilienaam.AutoSize = true;
            this.lblFamilienaam.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilienaam.Location = new System.Drawing.Point(49, 186);
            this.lblFamilienaam.Name = "lblFamilienaam";
            this.lblFamilienaam.Size = new System.Drawing.Size(78, 20);
            this.lblFamilienaam.TabIndex = 16;
            this.lblFamilienaam.Text = "Familienaam*";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(49, 145);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(43, 20);
            this.lblNaam.TabIndex = 15;
            this.lblNaam.Text = "Naam*";
            // 
            // grpbReg
            // 
            this.grpbReg.BackColor = System.Drawing.Color.GhostWhite;
            this.grpbReg.Controls.Add(this.txtAfst);
            this.grpbReg.Controls.Add(this.txtGeboorte);
            this.grpbReg.Controls.Add(this.lbltel);
            this.grpbReg.Controls.Add(this.picAvatar);
            this.grpbReg.Controls.Add(this.cboLand);
            this.grpbReg.Controls.Add(this.lnklAnnu);
            this.grpbReg.Controls.Add(this.lblNaam);
            this.grpbReg.Controls.Add(this.btnRegistreer);
            this.grpbReg.Controls.Add(this.lblFamilienaam);
            this.grpbReg.Controls.Add(this.lblGeboorte);
            this.grpbReg.Controls.Add(this.label4);
            this.grpbReg.Controls.Add(this.txtEmail);
            this.grpbReg.Controls.Add(this.label5);
            this.grpbReg.Controls.Add(this.txtRichting);
            this.grpbReg.Controls.Add(this.lblafstrichting);
            this.grpbReg.Controls.Add(this.txtTel);
            this.grpbReg.Controls.Add(this.lblAfstudeerj);
            this.grpbReg.Controls.Add(this.txtFamilienaam);
            this.grpbReg.Controls.Add(this.txtNaam);
            this.grpbReg.Location = new System.Drawing.Point(12, 61);
            this.grpbReg.Name = "grpbReg";
            this.grpbReg.Size = new System.Drawing.Size(402, 567);
            this.grpbReg.TabIndex = 30;
            this.grpbReg.TabStop = false;
            this.grpbReg.Text = "REGISTREER";
            this.grpbReg.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtAfst
            // 
            this.txtAfst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfst.ForeColor = System.Drawing.Color.Silver;
            this.txtAfst.Location = new System.Drawing.Point(165, 430);
            this.txtAfst.Multiline = true;
            this.txtAfst.Name = "txtAfst";
            this.txtAfst.Size = new System.Drawing.Size(200, 26);
            this.txtAfst.TabIndex = 35;
            this.txtAfst.Text = "2019";
            this.txtAfst.Enter += new System.EventHandler(this.txtAfst_Enter);
            this.txtAfst.Leave += new System.EventHandler(this.txtAfst_Leave);
            // 
            // txtGeboorte
            // 
            this.txtGeboorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeboorte.ForeColor = System.Drawing.Color.Silver;
            this.txtGeboorte.Location = new System.Drawing.Point(165, 223);
            this.txtGeboorte.Multiline = true;
            this.txtGeboorte.Name = "txtGeboorte";
            this.txtGeboorte.Size = new System.Drawing.Size(200, 26);
            this.txtGeboorte.TabIndex = 34;
            this.txtGeboorte.Text = "dd/mm/jjjj";
            this.txtGeboorte.Enter += new System.EventHandler(this.txtGeboorte_Enter);
            this.txtGeboorte.Leave += new System.EventHandler(this.txtGeboorte_Leave);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.ForeColor = System.Drawing.Color.Red;
            this.lbltel.Location = new System.Drawing.Point(374, 257);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(0, 13);
            this.lbltel.TabIndex = 33;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::FormPersoon.Properties.Resources._17__2_;
            this.picAvatar.Location = new System.Drawing.Point(142, 9);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(111, 116);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 32;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // cboLand
            // 
            this.cboLand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLand.ForeColor = System.Drawing.Color.Silver;
            this.cboLand.FormattingEnabled = true;
            this.cboLand.ItemHeight = 20;
            this.cboLand.Location = new System.Drawing.Point(165, 266);
            this.cboLand.Name = "cboLand";
            this.cboLand.Size = new System.Drawing.Size(200, 26);
            this.cboLand.TabIndex = 31;
            this.cboLand.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboLand_DrawItem);
            this.cboLand.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cboLand_MeasureItem);
            this.cboLand.SelectedIndexChanged += new System.EventHandler(this.cboLand_SelectedIndexChanged);
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.Location = new System.Drawing.Point(162, 539);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(49, 13);
            this.lnklAnnu.TabIndex = 30;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormPersoon.Properties.Resources.VHSJ;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Persoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(427, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Persoon";
            this.Load += new System.EventHandler(this.Persoon_Load);
            this.grpbReg.ResumeLayout(false);
            this.grpbReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRichting;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtFamilienaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblAfstudeerj;
        private System.Windows.Forms.Label lblafstrichting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGeboorte;
        private System.Windows.Forms.Label lblFamilienaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.GroupBox grpbReg;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.ComboBox cboLand;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAfst;
        private System.Windows.Forms.TextBox txtGeboorte;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

