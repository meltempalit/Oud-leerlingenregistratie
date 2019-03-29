﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FormWerk;

namespace FormVervolgstudies
{
    public partial class Vervolgstudies : Form
    {
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
        public Vervolgstudies()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void Vervolgstudies_Load(object sender, EventArgs e)
        {

        }

        private void lnklAnnu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "Afsluiten bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dialogresult == DialogResult.Yes)
            {
                Visible = false;
                Close();
            }
            else
            {

            }
        }

        private void txtSchool_Enter(object sender, EventArgs e)
        {
            if (txtSchool.Text == "Typ hier de naam van uw hogeschool/ universiteit...")
            {
                txtSchool.Text = "";
                txtSchool.ForeColor = Color.DarkGray;
            }
        }

        private void txtSchool_Leave(object sender, EventArgs e)
        {
            if (txtSchool.Text == "")
            {
                txtSchool.Text = "Typ hier de naam van uw hogeschool/ universiteit...";
                txtSchool.ForeColor = Color.Silver;
            }
        }

        private void txtRichtingVervolg_Enter(object sender, EventArgs e)
        {
            if (txtRichtingVervolg.Text == "Typ hier uw afstudeerrichting...")
            {
                txtRichtingVervolg.Text = "";
                txtRichtingVervolg.ForeColor = Color.DarkGray;
            }
        }

        private void txtRichtingVervolg_Leave(object sender, EventArgs e)
        {
            if (txtRichtingVervolg.Text == "")
            {
                txtRichtingVervolg.Text = "Typ hier uw afstudeerrichting...";
                txtRichtingVervolg.ForeColor = Color.Silver;
            }
        }

        private void txtDiploma_Enter(object sender, EventArgs e)
        {
            if (txtDiploma.Text == "Typ hier welk diploma u heeft behaald...")
            {
                txtDiploma.Text = "";
                txtDiploma.ForeColor = Color.DarkGray;
            }
        }

        private void txtDiploma_Leave(object sender, EventArgs e)
        {
            if (txtDiploma.Text == "")
            {
                txtDiploma.Text = "Typ hier welk diploma u heeft behaald...";
                txtDiploma.ForeColor = Color.Silver;
            }
        }

        private void txtAfstudeerjaar_Enter(object sender, EventArgs e)
        {
            if (txtAfstudeerjaar.Text == "Typ hier in welk jaar u bent afgestudeerd...")
            {
                txtAfstudeerjaar.Text = "";
                txtAfstudeerjaar.ForeColor = Color.DarkGray;
            }
        }

        private void txtAfstudeerjaar_Leave(object sender, EventArgs e)
        {
            if (txtAfstudeerjaar.Text == "")
            {
                txtAfstudeerjaar.Text = "Typ hier in welk jaar u bent afgestudeerd...";
                txtAfstudeerjaar.ForeColor = Color.Silver;
            }
        }

        private void btnVolgende_MouseHover(object sender, EventArgs e)
        {
            btnVolgende.BackColor = Color.SteelBlue;
            btnVolgende.ForeColor = Color.White;
        }

        private void btnVolgende_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnVolgende_MouseLeave(object sender, EventArgs e)
        {
            btnVolgende.BackColor = Color.Transparent;
            btnVolgende.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                pcbox.Visible = true;
                DialogResult dialogResult = MessageBox.Show("Succesvol toegevoegd!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Visible = false;
                    new Werken().Show();
                   
                }
            }
        }
        Business bus = new Business();
        public void vulForm()
        {
            bus = new Business();

        }
        private void btnVolgende_Click(object sender, EventArgs e)
        {
            if (txtSchool.Text.Length <= 2 || txtDiploma.Text.Length <= 2 || txtAfstudeerjaar.Text.Length <= 2 || txtRichtingVervolg.Text.Length <= 2)
            {
                MessageBox.Show("U moet iets ingeven!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (txtSchool.Text.Length <= 2)
                {
                    txtSchool.BackColor = Color.FromArgb(242, 220, 220);

                }
                if (txtDiploma.Text.Length <= 2)
                {
                    txtDiploma.BackColor = Color.FromArgb(242, 220, 220);
                }

                if (txtAfstudeerjaar.Text.Length <= 2)
                {
                    txtAfstudeerjaar.BackColor = Color.FromArgb(242, 220, 220);

                }
                if (txtRichtingVervolg.Text.Length <= 2)
                {
                    txtRichtingVervolg.BackColor = Color.FromArgb(242, 220, 220);

                }
            }
            else
            {
               
                this.timer1.Start();
                progressBar1.Visible = true;
                bus.voegToe(txtSchool.Text, txtRichtingVervolg.Text, txtDiploma.Text, txtAfstudeerjaar.Text);
                vulForm();

            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSchool_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
