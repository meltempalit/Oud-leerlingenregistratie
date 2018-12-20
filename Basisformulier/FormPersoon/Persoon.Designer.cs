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
            this.txtAfstudeerjaar = new System.Windows.Forms.DateTimePicker();
            this.txtGeboortedatum = new System.Windows.Forms.DateTimePicker();
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
            this.cboLand = new System.Windows.Forms.ComboBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.grpbReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistreer.Location = new System.Drawing.Point(182, 418);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(169, 40);
            this.btnRegistreer.TabIndex = 29;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = false;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            this.btnRegistreer.MouseLeave += new System.EventHandler(this.btnRegistreer_MouseLeave);
            this.btnRegistreer.MouseHover += new System.EventHandler(this.btnRegistreer_MouseHover);
            // 
            // txtAfstudeerjaar
            // 
            this.txtAfstudeerjaar.Location = new System.Drawing.Point(151, 350);
            this.txtAfstudeerjaar.Name = "txtAfstudeerjaar";
            this.txtAfstudeerjaar.Size = new System.Drawing.Size(200, 20);
            this.txtAfstudeerjaar.TabIndex = 28;
            // 
            // txtGeboortedatum
            // 
            this.txtGeboortedatum.Location = new System.Drawing.Point(151, 163);
            this.txtGeboortedatum.Name = "txtGeboortedatum";
            this.txtGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.txtGeboortedatum.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(151, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.Text = "someone@example.com";
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtRichting
            // 
            this.txtRichting.Location = new System.Drawing.Point(151, 304);
            this.txtRichting.Name = "txtRichting";
            this.txtRichting.Size = new System.Drawing.Size(200, 20);
            this.txtRichting.TabIndex = 25;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(369, 216);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 20);
            this.txtTel.TabIndex = 24;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // txtFamilienaam
            // 
            this.txtFamilienaam.Location = new System.Drawing.Point(151, 94);
            this.txtFamilienaam.Name = "txtFamilienaam";
            this.txtFamilienaam.Size = new System.Drawing.Size(200, 20);
            this.txtFamilienaam.TabIndex = 23;
            // 
            // txtNaam
            // 
            this.txtNaam.ForeColor = System.Drawing.Color.Black;
            this.txtNaam.Location = new System.Drawing.Point(151, 58);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 20);
            this.txtNaam.TabIndex = 22;
            // 
            // lblAfstudeerj
            // 
            this.lblAfstudeerj.AutoSize = true;
            this.lblAfstudeerj.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfstudeerj.Location = new System.Drawing.Point(42, 350);
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
            this.lblafstrichting.Location = new System.Drawing.Point(42, 304);
            this.lblafstrichting.Name = "lblafstrichting";
            this.lblafstrichting.Size = new System.Drawing.Size(108, 20);
            this.lblafstrichting.TabIndex = 20;
            this.lblafstrichting.Text = "Aftstudeerrichting*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefoonnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail";
            // 
            // lblGeboorte
            // 
            this.lblGeboorte.AutoSize = true;
            this.lblGeboorte.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeboorte.Location = new System.Drawing.Point(44, 163);
            this.lblGeboorte.Name = "lblGeboorte";
            this.lblGeboorte.Size = new System.Drawing.Size(96, 20);
            this.lblGeboorte.TabIndex = 17;
            this.lblGeboorte.Text = "Geboortedatum*";
            // 
            // lblFamilienaam
            // 
            this.lblFamilienaam.AutoSize = true;
            this.lblFamilienaam.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilienaam.Location = new System.Drawing.Point(44, 94);
            this.lblFamilienaam.Name = "lblFamilienaam";
            this.lblFamilienaam.Size = new System.Drawing.Size(78, 20);
            this.lblFamilienaam.TabIndex = 16;
            this.lblFamilienaam.Text = "Familienaam*";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaam.Location = new System.Drawing.Point(44, 60);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(43, 20);
            this.lblNaam.TabIndex = 15;
            this.lblNaam.Text = "Naam*";
            // 
            // grpbReg
            // 
            this.grpbReg.BackColor = System.Drawing.Color.GhostWhite;
            this.grpbReg.Controls.Add(this.lbltel);
            this.grpbReg.Controls.Add(this.picAvatar);
            this.grpbReg.Controls.Add(this.cboLand);
            this.grpbReg.Controls.Add(this.lnklAnnu);
            this.grpbReg.Controls.Add(this.lblNaam);
            this.grpbReg.Controls.Add(this.btnRegistreer);
            this.grpbReg.Controls.Add(this.lblFamilienaam);
            this.grpbReg.Controls.Add(this.txtAfstudeerjaar);
            this.grpbReg.Controls.Add(this.lblGeboorte);
            this.grpbReg.Controls.Add(this.txtGeboortedatum);
            this.grpbReg.Controls.Add(this.label4);
            this.grpbReg.Controls.Add(this.txtEmail);
            this.grpbReg.Controls.Add(this.label5);
            this.grpbReg.Controls.Add(this.txtRichting);
            this.grpbReg.Controls.Add(this.lblafstrichting);
            this.grpbReg.Controls.Add(this.txtTel);
            this.grpbReg.Controls.Add(this.lblAfstudeerj);
            this.grpbReg.Controls.Add(this.txtFamilienaam);
            this.grpbReg.Controls.Add(this.txtNaam);
            this.grpbReg.Location = new System.Drawing.Point(50, 87);
            this.grpbReg.Name = "grpbReg";
            this.grpbReg.Size = new System.Drawing.Size(616, 494);
            this.grpbReg.TabIndex = 30;
            this.grpbReg.TabStop = false;
            this.grpbReg.Text = "REGISTREER";
            this.grpbReg.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboLand
            // 
            this.cboLand.FormattingEnabled = true;
            this.cboLand.Location = new System.Drawing.Point(151, 216);
            this.cboLand.Name = "cboLand";
            this.cboLand.Size = new System.Drawing.Size(200, 21);
            this.cboLand.TabIndex = 31;
            this.cboLand.SelectedIndexChanged += new System.EventHandler(this.cboLand_SelectedIndexChanged);
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.Location = new System.Drawing.Point(127, 445);
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 79);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::FormPersoon.Properties.Resources._142;
            this.picAvatar.Location = new System.Drawing.Point(401, 48);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(140, 135);
            this.picAvatar.TabIndex = 32;
            this.picAvatar.TabStop = false;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.ForeColor = System.Drawing.Color.Red;
            this.lbltel.Location = new System.Drawing.Point(369, 243);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(0, 13);
            this.lbltel.TabIndex = 33;
            // 
            // Persoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(711, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Persoon";
            this.Load += new System.EventHandler(this.Persoon_Load);
            this.grpbReg.ResumeLayout(false);
            this.grpbReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.DateTimePicker txtAfstudeerjaar;
        private System.Windows.Forms.DateTimePicker txtGeboortedatum;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.ComboBox cboLand;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lbltel;
    }
}

