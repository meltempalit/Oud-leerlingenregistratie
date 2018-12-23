namespace FormLijst
{
    partial class Lijst
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLijst = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZoek
            // 
            this.btnZoek.BackColor = System.Drawing.Color.LightGray;
            this.btnZoek.Location = new System.Drawing.Point(390, 46);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 20);
            this.btnZoek.TabIndex = 46;
            this.btnZoek.Text = "ZOEKEN";
            this.btnZoek.UseVisualStyleBackColor = false;
            // 
            // txtZoek
            // 
            this.txtZoek.ForeColor = System.Drawing.Color.Silver;
            this.txtZoek.Location = new System.Drawing.Point(195, 46);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(188, 20);
            this.txtZoek.TabIndex = 45;
            this.txtZoek.Text = "Zoeken...";
            // 
            // llblclose
            // 
            this.llblclose.AutoSize = true;
            this.llblclose.Location = new System.Drawing.Point(413, 378);
            this.llblclose.Name = "llblclose";
            this.llblclose.Size = new System.Drawing.Size(33, 13);
            this.llblclose.TabIndex = 44;
            this.llblclose.TabStop = true;
            this.llblclose.Text = "Close";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormLijst.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.lstLijst);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 303);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUD-LEERLINGEN";
            // 
            // lstLijst
            // 
            this.lstLijst.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLijst.ForeColor = System.Drawing.Color.Gray;
            this.lstLijst.FormattingEnabled = true;
            this.lstLijst.ItemHeight = 19;
            this.lstLijst.Location = new System.Drawing.Point(40, 34);
            this.lstLijst.Name = "lstLijst";
            this.lstLijst.Size = new System.Drawing.Size(359, 232);
            this.lstLijst.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(486, 400);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.txtZoek);
            this.Controls.Add(this.llblclose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}

