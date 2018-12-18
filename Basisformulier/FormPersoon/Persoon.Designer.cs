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
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.txtAfstudeerjaar = new System.Windows.Forms.DateTimePicker();
            this.txtGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRichting = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbReg = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.grpbReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.BackColor = System.Drawing.Color.Silver;
            this.btnRegistreer.Location = new System.Drawing.Point(182, 418);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(169, 40);
            this.btnRegistreer.TabIndex = 29;
            this.btnRegistreer.Text = "REGISTREER";
            this.btnRegistreer.UseVisualStyleBackColor = false;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
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
            this.txtEmail.Location = new System.Drawing.Point(151, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 26;
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
            this.txtTel.Location = new System.Drawing.Point(151, 263);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(200, 20);
            this.txtTel.TabIndex = 24;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(151, 94);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(200, 20);
            this.txtVoornaam.TabIndex = 23;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(151, 58);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 20);
            this.txtNaam.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Afstudeerjaar ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Aftstudeerrichting";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Telefoonnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Geboortedatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Voornaam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Naam";
            // 
            // grpbReg
            // 
            this.grpbReg.Controls.Add(this.lnklAnnu);
            this.grpbReg.Controls.Add(this.label1);
            this.grpbReg.Controls.Add(this.btnRegistreer);
            this.grpbReg.Controls.Add(this.label2);
            this.grpbReg.Controls.Add(this.txtAfstudeerjaar);
            this.grpbReg.Controls.Add(this.label3);
            this.grpbReg.Controls.Add(this.txtGeboortedatum);
            this.grpbReg.Controls.Add(this.label4);
            this.grpbReg.Controls.Add(this.txtEmail);
            this.grpbReg.Controls.Add(this.label5);
            this.grpbReg.Controls.Add(this.txtRichting);
            this.grpbReg.Controls.Add(this.label6);
            this.grpbReg.Controls.Add(this.txtTel);
            this.grpbReg.Controls.Add(this.label7);
            this.grpbReg.Controls.Add(this.txtVoornaam);
            this.grpbReg.Controls.Add(this.txtNaam);
            this.grpbReg.Location = new System.Drawing.Point(83, 87);
            this.grpbReg.Name = "grpbReg";
            this.grpbReg.Size = new System.Drawing.Size(489, 494);
            this.grpbReg.TabIndex = 30;
            this.grpbReg.TabStop = false;
            this.grpbReg.Text = "REGISTREER";
            this.grpbReg.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // Persoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(636, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbReg);
            this.Name = "Persoon";
            this.Text = "Persoon";
            this.Load += new System.EventHandler(this.Persoon_Load);
            this.grpbReg.ResumeLayout(false);
            this.grpbReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistreer;
        private System.Windows.Forms.DateTimePicker txtAfstudeerjaar;
        private System.Windows.Forms.DateTimePicker txtGeboortedatum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRichting;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
    }
}

