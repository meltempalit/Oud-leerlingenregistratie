using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;

namespace FormWerk
{
    public partial class Werken : Form
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

        public Werken()
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


        private void txtSchool_TextChanged(object sender, EventArgs e)
        {
            lbljob.Visible = true;
        }

        private void txtJob_Enter(object sender, EventArgs e)
        {
            if (txtJob.Text == "vb. Industrieel ingenieur")
            {
                txtJob.Text = "";
                txtJob.ForeColor = Color.DarkGray;
            }
        }

        private void txtJob_Leave(object sender, EventArgs e)
        {
            if (txtJob.Text == "")
            {
                txtJob.Text = "vb. Industrieel ingenieur";
                txtJob.ForeColor = Color.Silver;
            }
            lbljob.Visible = false;
        }

        private void txtBedrijf_Enter(object sender, EventArgs e)
        {

            if (txtBedrijf.Text == "Typ hier voor welk bedrijf u werkt/ zelfstandig")
            {
                txtBedrijf.Text = "";
                txtBedrijf.ForeColor = Color.DarkGray;
            }
        }

        private void txtVestiging_Enter(object sender, EventArgs e)
        {
            if (txtVestiging.Text == "België, GENT")
            {
                txtVestiging.Text = "";
                txtVestiging.ForeColor = Color.DarkGray;
            }
        }

        private void txtStartjaar_Enter(object sender, EventArgs e)
        {
            if (txtStartjaar.Text == "Typ hier uw startjaar...")
            {
                txtStartjaar.Text = "";
                txtStartjaar.ForeColor = Color.DarkGray;
            }
        }

        private void txtBedrijf_Leave(object sender, EventArgs e)
        {
            if (txtBedrijf.Text == "")
            {
                txtBedrijf.Text = "Typ hier voor welk bedrijf u werkt/ zelfstandig";
                txtBedrijf.ForeColor = Color.Silver;
            }
            lblbed.Visible = false;
        }

        private void txtVestiging_Leave(object sender, EventArgs e)
        {
            if (txtVestiging.Text == "")
            {
                txtVestiging.Text = "België, GENT";
                txtVestiging.ForeColor = Color.Silver;
            }
            lblvest.Visible = false;
        }

        private void txtStartjaar_Leave(object sender, EventArgs e)
        {
            if (txtStartjaar.Text == "")
            {
                txtStartjaar.Text = "Typ hier uw startjaar...";
                txtStartjaar.ForeColor = Color.Silver;
            }
            lblstart.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        Business bus = new Business();
        public void vulForm()
        {
            bus = new Business();

        }
        private void btnVolgende_Click(object sender, EventArgs e)
        {

            if (txtBedrijf.Text.Length <= 2|| txtBedrijf.Text == "Typ hier voor welk bedrijf u werkt/ zelfstandig" || txtJob.Text.Length <= 2 || txtJob.Text == "vb. Industrieel ingenieur" || txtVestiging.Text.Length <= 2 ||txtVestiging.Text == "België, GENT" || txtStartjaar.Text.Length <= 2 || txtStartjaar.Text == "Typ hier uw startjaar...")
            {
                MessageBox.Show("U moet iets ingeven!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (txtBedrijf.Text.Length <= 2|| txtBedrijf.Text == "Typ hier voor welk bedrijf u werkt/ zelfstandig")
                {
                    txtBedrijf.BackColor = Color.FromArgb(242, 220, 220);

                }
                if (txtJob.Text.Length <= 2 || txtJob.Text == "vb. Industrieel ingenieur")
                {
                    txtJob.BackColor = Color.FromArgb(242, 220, 220);
                }

                if (txtVestiging.Text.Length <= 2|| txtVestiging.Text == "België, GENT")
                {
                    txtVestiging.BackColor = Color.FromArgb(242, 220, 220);

                }
                if (txtStartjaar.Text.Length <= 2 || txtStartjaar.Text == "Typ hier uw startjaar...")
                {
                    txtStartjaar.BackColor = Color.FromArgb(242, 220, 220);

                }
            }
            else
            {
                bus.voegToe(txtJob.Text, txtBedrijf.Text, txtStartjaar.Text, txtVestiging.Text);
                vulForm();
                this.timer1.Start();
                progressBar1.Visible = true;
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();///
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\send.wav");
                splayer.Play();
                pcbox.Visible = true;
                DialogResult dialogResult = MessageBox.Show("Succesvol toegevoegd!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Visible = false;
                    Close();
                    

                }
            }
        }

        private void Werken_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(18, 74, 111);
        }

        private void txtVestiging_TextChanged(object sender, EventArgs e)
        {
            lblvest.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBedrijf_TextChanged(object sender, EventArgs e)
        {
            lblbed.Visible = true;
        }

        private void txtStartjaar_TextChanged(object sender, EventArgs e)
        {
            lblstart.Visible = true;
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

        private void btnVolgende_MouseHover(object sender, EventArgs e)
        {
            btnVolgende.BackColor = Color.SteelBlue;
            btnVolgende.ForeColor = Color.White;
        }

        private void btnVolgende_MouseLeave(object sender, EventArgs e)
        {
            btnVolgende.BackColor = Color.Transparent;
            btnVolgende.ForeColor = Color.Gray;
        }
    }
}
