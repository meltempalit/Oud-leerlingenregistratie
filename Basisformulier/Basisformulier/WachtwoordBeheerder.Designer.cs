﻿namespace Basisformulier
{
    partial class WachtwoordBeheerder
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
            this.txtWW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnu = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWW
            // 
            this.txtWW.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWW.ForeColor = System.Drawing.Color.DarkGray;
            this.txtWW.Location = new System.Drawing.Point(101, 55);
            this.txtWW.Name = "txtWW";
            this.txtWW.PasswordChar = '•';
            this.txtWW.Size = new System.Drawing.Size(222, 25);
            this.txtWW.TabIndex = 0;
            this.txtWW.UseWaitCursor = true;
            this.txtWW.TextChanged += new System.EventHandler(this.txtWW_TextChanged);
            this.txtWW.Enter += new System.EventHandler(this.txtWW_Enter);
            this.txtWW.Leave += new System.EventHandler(this.txtWW_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wachtwoord:";
            this.label1.UseWaitCursor = true;
            // 
            // btnAnu
            // 
            this.btnAnu.Location = new System.Drawing.Point(164, 104);
            this.btnAnu.Name = "btnAnu";
            this.btnAnu.Size = new System.Drawing.Size(75, 23);
            this.btnAnu.TabIndex = 2;
            this.btnAnu.Text = "Annuleer";
            this.btnAnu.UseVisualStyleBackColor = true;
            this.btnAnu.UseWaitCursor = true;
            this.btnAnu.Click += new System.EventHandler(this.button1_Click);
            this.btnAnu.MouseLeave += new System.EventHandler(this.btnAnu_MouseLeave);
            this.btnAnu.MouseHover += new System.EventHandler(this.btnAnu_MouseHover);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(248, 104);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.UseWaitCursor = true;
            this.btnOK.Click += new System.EventHandler(this.button2_Click);
            this.btnOK.MouseEnter += new System.EventHandler(this.btnOK_MouseEnter);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            this.btnOK.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name:";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin";
            this.label3.UseWaitCursor = true;
            // 
            // WachtwoordBeheerder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(349, 139);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnAnu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WachtwoordBeheerder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wachtwoord beheerder";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.WachtwoordBeheerder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnu;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}