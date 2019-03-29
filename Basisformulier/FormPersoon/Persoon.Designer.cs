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
            this.lblmail = new System.Windows.Forms.Label();
            this.lblGeboorte = new System.Windows.Forms.Label();
            this.lblFamilienaam = new System.Windows.Forms.Label();
            this.grpbReg = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkControle = new System.Windows.Forms.CheckBox();
            this.txtAfst = new System.Windows.Forms.TextBox();
            this.txtGeboorte = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cboLand = new System.Windows.Forms.ComboBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.lblNaam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpbReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.BackColor = System.Drawing.Color.Lavender;
            this.btnRegistreer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreer.ForeColor = System.Drawing.Color.DimGray;
            this.btnRegistreer.Location = new System.Drawing.Point(132, 546);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(121, 29);
            this.btnRegistreer.TabIndex = 29;
            this.btnRegistreer.Text = "Doorgaan";
            this.btnRegistreer.UseVisualStyleBackColor = false;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            this.btnRegistreer.MouseLeave += new System.EventHandler(this.btnRegistreer_MouseLeave);
            this.btnRegistreer.MouseHover += new System.EventHandler(this.btnRegistreer_MouseHover);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(53, 374);
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
            this.txtRichting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRichting.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRichting.ForeColor = System.Drawing.Color.Silver;
            this.txtRichting.Location = new System.Drawing.Point(53, 423);
            this.txtRichting.Multiline = true;
            this.txtRichting.Name = "txtRichting";
            this.txtRichting.Size = new System.Drawing.Size(200, 26);
            this.txtRichting.TabIndex = 25;
            this.txtRichting.Text = "IT & Netwerken";
            this.txtRichting.TextChanged += new System.EventHandler(this.txtRichting_TextChanged);
            this.txtRichting.Enter += new System.EventHandler(this.txtRichting_Enter_1);
            this.txtRichting.Leave += new System.EventHandler(this.txtRichting_Leave);
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTel.Location = new System.Drawing.Point(53, 327);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 26);
            this.txtTel.TabIndex = 24;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            this.txtTel.Enter += new System.EventHandler(this.txtTel_Enter);
            this.txtTel.Leave += new System.EventHandler(this.txtTel_Leave);
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFamilienaam.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilienaam.ForeColor = System.Drawing.Color.Silver;
            this.txtFamilienaam.Location = new System.Drawing.Point(53, 197);
            this.txtFamilienaam.Multiline = true;
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(200, 26);
            this.txtFamilienaam.TabIndex = 23;
            this.txtFamilienaam.Text = "Familienaam";
            this.txtFamilienaam.Enter += new System.EventHandler(this.txtFamilienaam_Enter);
            this.txtFamilienaam.Leave += new System.EventHandler(this.txtFamilienaam_Leave);
            // 
            // txtNaam
            // 
            this.txtNaam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaam.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaam.ForeColor = System.Drawing.Color.Silver;
            this.txtNaam.Location = new System.Drawing.Point(53, 148);
            this.txtNaam.Multiline = true;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 26);
            this.txtNaam.TabIndex = 22;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            this.txtNaam.Enter += new System.EventHandler(this.txtNaam_Enter_1);
            this.txtNaam.Leave += new System.EventHandler(this.txtNaam_Leave_1);
            // 
            // lblAfstudeerj
            // 
            this.lblAfstudeerj.AutoSize = true;
            this.lblAfstudeerj.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfstudeerj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAfstudeerj.Location = new System.Drawing.Point(52, 452);
            this.lblAfstudeerj.Name = "lblAfstudeerj";
            this.lblAfstudeerj.Size = new System.Drawing.Size(71, 17);
            this.lblAfstudeerj.TabIndex = 21;
            this.lblAfstudeerj.Text = "Afstudeerjaar*";
            this.lblAfstudeerj.Visible = false;
            this.lblAfstudeerj.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblafstrichting
            // 
            this.lblafstrichting.AutoSize = true;
            this.lblafstrichting.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafstrichting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblafstrichting.Location = new System.Drawing.Point(52, 403);
            this.lblafstrichting.Name = "lblafstrichting";
            this.lblafstrichting.Size = new System.Drawing.Size(92, 17);
            this.lblafstrichting.TabIndex = 20;
            this.lblafstrichting.Text = "Aftstudeerrichting*";
            this.lblafstrichting.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(52, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefoonnummer";
            this.label5.Visible = false;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblmail.Location = new System.Drawing.Point(51, 356);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(36, 17);
            this.lblmail.TabIndex = 18;
            this.lblmail.Text = "E-mail";
            this.lblmail.Visible = false;
            // 
            // lblGeboorte
            // 
            this.lblGeboorte.AutoSize = true;
            this.lblGeboorte.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeboorte.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGeboorte.Location = new System.Drawing.Point(50, 226);
            this.lblGeboorte.Name = "lblGeboorte";
            this.lblGeboorte.Size = new System.Drawing.Size(82, 17);
            this.lblGeboorte.TabIndex = 17;
            this.lblGeboorte.Text = "Geboortedatum*";
            this.lblGeboorte.Visible = false;
            // 
            // lblFamilienaam
            // 
            this.lblFamilienaam.AutoSize = true;
            this.lblFamilienaam.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilienaam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFamilienaam.Location = new System.Drawing.Point(50, 177);
            this.lblFamilienaam.Name = "lblFamilienaam";
            this.lblFamilienaam.Size = new System.Drawing.Size(67, 17);
            this.lblFamilienaam.TabIndex = 16;
            this.lblFamilienaam.Text = "Familienaam*";
            this.lblFamilienaam.Visible = false;
            // 
            // grpbReg
            // 
            this.grpbReg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpbReg.Controls.Add(this.linkLabel1);
            this.grpbReg.Controls.Add(this.label1);
            this.grpbReg.Controls.Add(this.chkControle);
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
            this.grpbReg.Controls.Add(this.lblmail);
            this.grpbReg.Controls.Add(this.txtEmail);
            this.grpbReg.Controls.Add(this.label5);
            this.grpbReg.Controls.Add(this.txtRichting);
            this.grpbReg.Controls.Add(this.lblafstrichting);
            this.grpbReg.Controls.Add(this.txtTel);
            this.grpbReg.Controls.Add(this.lblAfstudeerj);
            this.grpbReg.Controls.Add(this.txtFamilienaam);
            this.grpbReg.Controls.Add(this.txtNaam);
            this.grpbReg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbReg.ForeColor = System.Drawing.Color.DarkGray;
            this.grpbReg.Location = new System.Drawing.Point(12, 61);
            this.grpbReg.Name = "grpbReg";
            this.grpbReg.Size = new System.Drawing.Size(324, 587);
            this.grpbReg.TabIndex = 30;
            this.grpbReg.TabStop = false;
            this.grpbReg.Text = "REGISTREER";
            this.grpbReg.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumOrchid;
            this.linkLabel1.Location = new System.Drawing.Point(134, 505);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 16);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy beleid";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(70, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "gelezen en ga hiermee akkoord";
            // 
            // chkControle
            // 
            this.chkControle.AutoSize = true;
            this.chkControle.ForeColor = System.Drawing.Color.DimGray;
            this.chkControle.Location = new System.Drawing.Point(55, 505);
            this.chkControle.Name = "chkControle";
            this.chkControle.Size = new System.Drawing.Size(89, 17);
            this.chkControle.TabIndex = 36;
            this.chkControle.Text = "Ik heb het ";
            this.chkControle.UseVisualStyleBackColor = true;
            // 
            // txtAfst
            // 
            this.txtAfst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAfst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfst.ForeColor = System.Drawing.Color.Silver;
            this.txtAfst.Location = new System.Drawing.Point(53, 472);
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
            this.txtGeboorte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeboorte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeboorte.ForeColor = System.Drawing.Color.Silver;
            this.txtGeboorte.Location = new System.Drawing.Point(53, 244);
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
            this.picAvatar.Location = new System.Drawing.Point(105, 10);
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
            this.cboLand.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLand.ForeColor = System.Drawing.Color.Silver;
            this.cboLand.FormattingEnabled = true;
            this.cboLand.ItemHeight = 20;
            this.cboLand.Location = new System.Drawing.Point(53, 295);
            this.cboLand.Name = "cboLand";
            this.cboLand.Size = new System.Drawing.Size(200, 26);
            this.cboLand.TabIndex = 31;
            this.cboLand.Text = "Telefoonnummer";
            this.cboLand.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboLand_DrawItem);
            this.cboLand.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cboLand_MeasureItem);
            this.cboLand.SelectedIndexChanged += new System.EventHandler(this.cboLand_SelectedIndexChanged);
            this.cboLand.Enter += new System.EventHandler(this.cboLand_Enter);
            this.cboLand.Leave += new System.EventHandler(this.cboLand_Leave);
            this.cboLand.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboLand_MouseClick);
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnklAnnu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnklAnnu.Location = new System.Drawing.Point(68, 562);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(58, 13);
            this.lnklAnnu.TabIndex = 30;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNaam.Location = new System.Drawing.Point(50, 128);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(37, 17);
            this.lblNaam.TabIndex = 15;
            this.lblNaam.Text = "Naam*";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormPersoon.Properties.Resources.iconfinder_Cross_2001870;
            this.pictureBox2.Location = new System.Drawing.Point(305, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            // Persoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(348, 660);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbReg);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Persoon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Persoon_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Persoon_MouseDown);
            this.grpbReg.ResumeLayout(false);
            this.grpbReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblGeboorte;
        private System.Windows.Forms.Label lblFamilienaam;
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
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkControle;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

