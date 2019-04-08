namespace Basisformulier
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnReg = new System.Windows.Forms.Button();
            this.btnLijst = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picList = new System.Windows.Forms.PictureBox();
            this.picReg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReg.BackColor = System.Drawing.Color.Firebrick;
            this.btnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReg.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(-1, 114);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(233, 49);
            this.btnReg.TabIndex = 35;
            this.btnReg.Text = "REGISTREER";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            this.btnReg.MouseLeave += new System.EventHandler(this.btnReg_MouseLeave);
            this.btnReg.MouseHover += new System.EventHandler(this.btnReg_MouseHover);
            // 
            // btnLijst
            // 
            this.btnLijst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLijst.BackColor = System.Drawing.Color.Firebrick;
            this.btnLijst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLijst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLijst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLijst.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLijst.ForeColor = System.Drawing.Color.White;
            this.btnLijst.Location = new System.Drawing.Point(6, 180);
            this.btnLijst.Margin = new System.Windows.Forms.Padding(0);
            this.btnLijst.Name = "btnLijst";
            this.btnLijst.Size = new System.Drawing.Size(218, 49);
            this.btnLijst.TabIndex = 35;
            this.btnLijst.Text = "LIJST";
            this.btnLijst.UseVisualStyleBackColor = false;
            this.btnLijst.Click += new System.EventHandler(this.btnLijst_Click);
            this.btnLijst.MouseLeave += new System.EventHandler(this.btnLijst_MouseLeave);
            this.btnLijst.MouseHover += new System.EventHandler(this.btnLijst_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnLijst);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.panel1.Location = new System.Drawing.Point(-6, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 502);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox3.Image = global::Basisformulier.Properties.Resources.icons8_ask_question_241;
            this.pictureBox3.Location = new System.Drawing.Point(184, 328);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Klik op registreren om te registreren, klik op lijst voor een overzicht.");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 24);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 37;
            this.button1.Text = "Verberg";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(234, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = " ";
            this.label1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.DarkBlue;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.Color.PapayaWhip;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Basisformulier.Properties.Resources.icons8_close_program_96;
            this.pictureBox2.Location = new System.Drawing.Point(519, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox2, "Close");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 1500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(-19, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(227, 342);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 48;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // picList
            // 
            this.picList.Image = global::Basisformulier.Properties.Resources._306458;
            this.picList.Location = new System.Drawing.Point(214, 83);
            this.picList.Name = "picList";
            this.picList.Size = new System.Drawing.Size(378, 202);
            this.picList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picList.TabIndex = 45;
            this.picList.TabStop = false;
            this.picList.Visible = false;
            // 
            // picReg
            // 
            this.picReg.Image = global::Basisformulier.Properties.Resources.register;
            this.picReg.Location = new System.Drawing.Point(238, 84);
            this.picReg.Name = "picReg";
            this.picReg.Size = new System.Drawing.Size(322, 202);
            this.picReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReg.TabIndex = 44;
            this.picReg.TabStop = false;
            this.picReg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Basisformulier.Properties.Resources.logo_handelsschool_sint_joris;
            this.pictureBox1.Location = new System.Drawing.Point(238, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 346);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picList);
            this.Controls.Add(this.picReg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLijst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picReg;
        private System.Windows.Forms.PictureBox picList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer3;
    }
}