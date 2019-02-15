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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiploma = new System.Windows.Forms.TextBox();
            this.txtRichtingVervolg = new System.Windows.Forms.TextBox();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.btnToevoegenErvaring = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtAfstudeerjaar = new System.Windows.Forms.TextBox();
            this.lblafstrichting = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lblafstrichting);
            this.groupBox1.Controls.Add(this.txtAfstudeerjaar);
            this.groupBox1.Controls.Add(this.txtDiploma);
            this.groupBox1.Controls.Add(this.txtRichtingVervolg);
            this.groupBox1.Controls.Add(this.pcbox);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtSchool);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnToevoegenErvaring);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(14, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 395);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STUDIES";
            // 
            // txtDiploma
            // 
            this.txtDiploma.ForeColor = System.Drawing.Color.Silver;
            this.txtDiploma.Location = new System.Drawing.Point(163, 183);
            this.txtDiploma.Multiline = true;
            this.txtDiploma.Name = "txtDiploma";
            this.txtDiploma.Size = new System.Drawing.Size(187, 32);
            this.txtDiploma.TabIndex = 40;
            this.txtDiploma.Text = "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business...";
            // 
            // txtRichtingVervolg
            // 
            this.txtRichtingVervolg.ForeColor = System.Drawing.Color.Silver;
            this.txtRichtingVervolg.Location = new System.Drawing.Point(163, 128);
            this.txtRichtingVervolg.Multiline = true;
            this.txtRichtingVervolg.Name = "txtRichtingVervolg";
            this.txtRichtingVervolg.Size = new System.Drawing.Size(187, 32);
            this.txtRichtingVervolg.TabIndex = 39;
            this.txtRichtingVervolg.Text = "Typ hier wat u wenst mee te geven aan de leerlingen...";
            // 
            // pcbox
            // 
            this.pcbox.Location = new System.Drawing.Point(394, 320);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(16, 16);
            this.pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbox.TabIndex = 37;
            this.pcbox.TabStop = false;
            this.pcbox.Visible = false;
            // 
            // txtSchool
            // 
            this.txtSchool.ForeColor = System.Drawing.Color.Silver;
            this.txtSchool.Location = new System.Drawing.Point(163, 73);
            this.txtSchool.Multiline = true;
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(187, 32);
            this.txtSchool.TabIndex = 35;
            this.txtSchool.Text = "Typ hier uw loopbaan/ ervaringen...";
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
            // 
            // btnToevoegenErvaring
            // 
            this.btnToevoegenErvaring.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenErvaring.Location = new System.Drawing.Point(236, 342);
            this.btnToevoegenErvaring.Name = "btnToevoegenErvaring";
            this.btnToevoegenErvaring.Size = new System.Drawing.Size(152, 27);
            this.btnToevoegenErvaring.TabIndex = 5;
            this.btnToevoegenErvaring.Text = "Volgende";
            this.btnToevoegenErvaring.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormVervolgstudies.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 313);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 23);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Visible = false;
            // 
            // txtAfstudeerjaar
            // 
            this.txtAfstudeerjaar.ForeColor = System.Drawing.Color.Silver;
            this.txtAfstudeerjaar.Location = new System.Drawing.Point(163, 240);
            this.txtAfstudeerjaar.Multiline = true;
            this.txtAfstudeerjaar.Name = "txtAfstudeerjaar";
            this.txtAfstudeerjaar.Size = new System.Drawing.Size(187, 32);
            this.txtAfstudeerjaar.TabIndex = 41;
            this.txtAfstudeerjaar.Text = "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business...";
            // 
            // lblafstrichting
            // 
            this.lblafstrichting.AutoSize = true;
            this.lblafstrichting.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafstrichting.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblafstrichting.Location = new System.Drawing.Point(38, 136);
            this.lblafstrichting.Name = "lblafstrichting";
            this.lblafstrichting.Size = new System.Drawing.Size(92, 17);
            this.lblafstrichting.TabIndex = 42;
            this.lblafstrichting.Text = "Aftstudeerrichting*";
            // 
            // Vervolgstudies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(451, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vervolgstudies";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Vervolgstudies_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiploma;
        private System.Windows.Forms.TextBox txtRichtingVervolg;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.Button btnToevoegenErvaring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtAfstudeerjaar;
        private System.Windows.Forms.Label lblafstrichting;
    }
}

