namespace FormPosts
{
    partial class Posts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posts));
            this.btnToevoegenErvaring = new System.Windows.Forms.Button();
            this.lnklAnnu = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHerinnering = new System.Windows.Forms.TextBox();
            this.txtMededeling = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtErvaring = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pcbox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToevoegenErvaring
            // 
            this.btnToevoegenErvaring.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegenErvaring.Location = new System.Drawing.Point(196, 347);
            this.btnToevoegenErvaring.Name = "btnToevoegenErvaring";
            this.btnToevoegenErvaring.Size = new System.Drawing.Size(152, 27);
            this.btnToevoegenErvaring.TabIndex = 5;
            this.btnToevoegenErvaring.Text = "Volgende";
            this.btnToevoegenErvaring.UseVisualStyleBackColor = true;
            this.btnToevoegenErvaring.Click += new System.EventHandler(this.btnToevoegenErvaring_Click);
            this.btnToevoegenErvaring.MouseLeave += new System.EventHandler(this.btnToevoegenErvaring_MouseLeave);
            this.btnToevoegenErvaring.MouseHover += new System.EventHandler(this.btnToevoegenErvaring_MouseHover);
            // 
            // lnklAnnu
            // 
            this.lnklAnnu.AutoSize = true;
            this.lnklAnnu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnklAnnu.Location = new System.Drawing.Point(132, 361);
            this.lnklAnnu.Name = "lnklAnnu";
            this.lnklAnnu.Size = new System.Drawing.Size(58, 13);
            this.lnklAnnu.TabIndex = 33;
            this.lnklAnnu.TabStop = true;
            this.lnklAnnu.Text = "Annuleer";
            this.lnklAnnu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklAnnu_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtHerinnering);
            this.groupBox1.Controls.Add(this.txtMededeling);
            this.groupBox1.Controls.Add(this.pcbox);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.txtErvaring);
            this.groupBox1.Controls.Add(this.lnklAnnu);
            this.groupBox1.Controls.Add(this.btnToevoegenErvaring);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 395);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POST";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtHerinnering
            // 
            this.txtHerinnering.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHerinnering.ForeColor = System.Drawing.Color.Silver;
            this.txtHerinnering.Location = new System.Drawing.Point(32, 234);
            this.txtHerinnering.Multiline = true;
            this.txtHerinnering.Name = "txtHerinnering";
            this.txtHerinnering.Size = new System.Drawing.Size(316, 64);
            this.txtHerinnering.TabIndex = 2;
            this.txtHerinnering.Text = "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business...";
            this.txtHerinnering.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHerinnering_MouseClick);
            this.txtHerinnering.TextChanged += new System.EventHandler(this.txtHerinnering_TextChanged_1);
            this.txtHerinnering.Enter += new System.EventHandler(this.txtHerinnering_Enter_1);
            this.txtHerinnering.Leave += new System.EventHandler(this.txtHerinnering_Leave_1);
            // 
            // txtMededeling
            // 
            this.txtMededeling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMededeling.ForeColor = System.Drawing.Color.Silver;
            this.txtMededeling.Location = new System.Drawing.Point(32, 155);
            this.txtMededeling.Multiline = true;
            this.txtMededeling.Name = "txtMededeling";
            this.txtMededeling.Size = new System.Drawing.Size(316, 62);
            this.txtMededeling.TabIndex = 1;
            this.txtMededeling.Text = "Typ hier wat u wenst mee te geven aan de leerlingen...";
            this.txtMededeling.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMededeling_MouseClick);
            this.txtMededeling.TextChanged += new System.EventHandler(this.txtMededeling_TextChanged);
            this.txtMededeling.Enter += new System.EventHandler(this.txtMededeling_Enter_2);
            this.txtMededeling.Leave += new System.EventHandler(this.txtMededeling_Leave_2);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 318);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 23);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // txtErvaring
            // 
            this.txtErvaring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErvaring.ForeColor = System.Drawing.Color.Silver;
            this.txtErvaring.Location = new System.Drawing.Point(32, 79);
            this.txtErvaring.Multiline = true;
            this.txtErvaring.Name = "txtErvaring";
            this.txtErvaring.Size = new System.Drawing.Size(316, 58);
            this.txtErvaring.TabIndex = 0;
            this.txtErvaring.Text = "Typ hier uw loopbaan/ ervaringen...";
            this.txtErvaring.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtErvaring_MouseClick);
            this.txtErvaring.TextChanged += new System.EventHandler(this.txtErvaring_TextChanged_1);
            this.txtErvaring.Enter += new System.EventHandler(this.txtErvaring_Enter_1);
            this.txtErvaring.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtErvaring_KeyPress);
            this.txtErvaring.Leave += new System.EventHandler(this.txtErvaring_Leave_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 19);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FormPosts.Properties.Resources._new;
            this.pictureBox2.Location = new System.Drawing.Point(101, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pcbox
            // 
            this.pcbox.Image = global::FormPosts.Properties.Resources.icons8_double_tick_48;
            this.pcbox.Location = new System.Drawing.Point(350, 319);
            this.pcbox.Name = "pcbox";
            this.pcbox.Size = new System.Drawing.Size(25, 23);
            this.pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbox.TabIndex = 37;
            this.pcbox.TabStop = false;
            this.pcbox.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormPosts.Properties.Resources.VHSJ;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 64);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // Posts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(406, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Posts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ervaring_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToevoegenErvaring;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnklAnnu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtErvaring;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbox;
        private System.Windows.Forms.TextBox txtHerinnering;
        private System.Windows.Forms.TextBox txtMededeling;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}