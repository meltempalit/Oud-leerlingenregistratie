﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPersoon;
using Lijst;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices; // 
using System.Media;


namespace Basisformulier
{
    public partial class Form2 : Form
    {
        int PW;
        bool verborgen;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
            (

            int nLeftRect,
            int nTopRect, 
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        public Form2()
        {
            InitializeComponent();
           this.FormBorderStyle = FormBorderStyle.None;
           this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            PW = panel1.Width;
            verborgen = false;

        }
        

        private const int CS_schaduw = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_schaduw;
                return cp;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new Persoon().Show();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\click.wav");
            splayer.Play();
            

        }

        private void btnLijst_Click(object sender, EventArgs e)
        {
            new WachtwoordBeheerder().Show();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\click.wav");
            splayer.Play();
            // new frmLijst().Show();
           
        }

        private void btnReg_MouseHover(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.FromArgb(18, 74, 111);
            btnReg.ForeColor = Color.White;
            picReg.Visible = true;
            btnReg.TabStop = false;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.FlatAppearance.BorderSize = 0;
            pReg.Visible = true;

        }

        private void btnReg_MouseLeave(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.Transparent;
            btnReg.ForeColor = Color.White;
            picReg.Visible = false;
            pReg.Visible = false;
        }

        private void btnLijst_MouseHover(object sender, EventArgs e)
        {
            btnLijst.BackColor = Color.FromArgb(18,74,111);
           // btnLijst.BackColor = Color.Green;
            btnLijst.ForeColor = Color.White;
            picList.Visible = true;
            btnLijst.TabStop = false;
            btnLijst.FlatStyle = FlatStyle.Flat;
            btnLijst.FlatAppearance.BorderSize = 0;
            pLijst.Visible = true;
           

        }

        private void btnLijst_MouseLeave(object sender, EventArgs e)
        {
            btnLijst.BackColor = Color.Transparent;
            btnLijst.ForeColor = Color.White;
            picList.Visible = false;
            pLijst.Visible = false;

        }

        private void llblclose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "Bevestiging", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else { }
        }
        int a = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.Color.FromArgb(18, 74, 111);
            btnReg.TabStop = false;
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.FlatAppearance.BorderSize = 0;
            btnLijst.TabStop = false;
            btnLijst.FlatStyle = FlatStyle.Flat;
            btnLijst.FlatAppearance.BorderSize = 0;
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\elec.wav");
            splayer.Play();
            pictureBox4.SendToBack();
            timer3.Start();
            pLijst.BackColor = Color.FromArgb(18, 74, 111);
            pReg.BackColor = Color.FromArgb(18, 74, 111);



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\elec.wav");
            splayer.Play();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(18, 74, 111);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0.0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (verborgen)
            {
                panel1.Width = panel1.Width + 20;
                if(panel1.Width >= PW)
                {
                
                    timer2.Stop();
                    verborgen = false;
                    this.Refresh();
                    button1.Cursor = Cursors.AppStarting;

                }
            }
            else
            {
                panel1.Width = panel1.Width - 20;
                if(panel1.Width <= 0)
                {
                    timer2.Stop();
                    verborgen = true;
                    this.Refresh();
                    pictureBox4.Visible = true;
                    button1.Cursor = Cursors.AppStarting;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verborgen) button1.Text = "Verberg";
            else button1.Text = "Show";
            timer2.Start(); SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\click.wav");
            splayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
                a++;
                switch (a)
                {

                    case 1:

                        pictureBox4.Image = Properties.Resources.Knipsel;
                        break;
                    case 2:

                        pictureBox4.Image = Properties.Resources.Knipsel1;
                        break;
                    case 3:

                        pictureBox4.Image = Properties.Resources.Knipsel2;
                        break;
                    case 4:

                        pictureBox4.Image = Properties.Resources.Knipsel3;
                        break;
                    case 5:

                        pictureBox4.Image = Properties.Resources.Knipsel5;
                        break;

                    case 6:

                    pictureBox4.Image = Properties.Resources.Knipsel6;
                    break;

                    case 7:

                    pictureBox4.Image = Properties.Resources.Knipsel7;
                    break;

                     case 8:

                    pictureBox4.Image = Properties.Resources.Knipsel8;
                    break;

                    case 9:

                    pictureBox4.Image = Properties.Resources.Knipsel9;
                    a = 0;
                    break;

                    
            }
             
           
                
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new ContactAdministrator().Show();
        }
    }
}
