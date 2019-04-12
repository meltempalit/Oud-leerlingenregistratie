using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FormVervolgstudies;
using System.Media;

namespace FormPosts
{
    public partial class Posts : Form
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

        public Posts()
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

        private Business bus;
        private void Ervaring_Load(object sender, EventArgs e)
        {
            vulForm();
            panel1.BackColor = Color.FromArgb(18, 74, 111);
            progressBar1.ForeColor = Color.Pink;

        }

        public void vulForm()
        {
            bus = new Business();



        }

        private void txtErvaring_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToevoegenErvaring_Click(object sender, EventArgs e)
        {



            if (txtErvaring.Text.Length <= 2 || txtErvaring.Text == "Typ hier uw loopbaan/ ervaringen..." || txtHerinnering.Text.Length <= 2 || txtHerinnering.Text== "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business..." || txtMededeling.Text.Length <= 2 || txtMededeling.Text == "Typ hier wat u wenst mee te geven aan de leerlingen...")
            {
                MessageBox.Show("U moet iets ingeven!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (txtErvaring.Text.Length <= 2 || txtErvaring.Text == "Typ hier uw loopbaan/ ervaringen...")
                {
                    txtErvaring.BackColor = Color.FromArgb(242, 220, 220);

                }
                if (txtHerinnering.Text.Length <= 2 || txtHerinnering.Text == "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business...")
                {
                    txtHerinnering.BackColor = Color.FromArgb(242, 220, 220);
                }

                if (txtMededeling.Text.Length <= 2 || txtMededeling.Text == "Typ hier wat u wenst mee te geven aan de leerlingen...")
                {
                    txtMededeling.BackColor = Color.FromArgb(242, 220, 220);

                }


            }
            else
            {
                this.timer1.Start();
                progressBar1.Visible = true;
                bus.voegToe(txtErvaring.Text, txtMededeling.Text, txtHerinnering.Text);
                vulForm();
                
            }

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

        private void txtErvaring_Enter(object sender, EventArgs e)
        {

        }

        private void txtErvaring_Leave(object sender, EventArgs e)
        {

        }

        private void txtErvaring_Enter_1(object sender, EventArgs e)
        {
            if (txtErvaring.Text == "Typ hier uw loopbaan/ ervaringen...")
            {
                txtErvaring.Text = "";
                txtErvaring.ForeColor = Color.DarkGray;
            }
        }

        private void txtErvaring_Leave_1(object sender, EventArgs e)
        {
            if (txtErvaring.Text == "")
            {
                txtErvaring.Text = "Typ hier uw loopbaan/ ervaringen...";
                txtErvaring.ForeColor = Color.Silver;
            }
        }

        private void btnToevoegenErvaring_MouseHover(object sender, EventArgs e)
        {
            btnToevoegenErvaring.BackColor = Color.SteelBlue;
            btnToevoegenErvaring.ForeColor = Color.White;
        }

        private void btnToevoegenErvaring_MouseLeave(object sender, EventArgs e)
        {
            btnToevoegenErvaring.BackColor = Color.Transparent;
            btnToevoegenErvaring.ForeColor = Color.Black;
        }

        private void txtErvaring_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                pcbox.Visible = true;
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\Public\Documents\send.wav");
                splayer.Play();
                DialogResult dialogResult = MessageBox.Show("Succesvol toegevoegd!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Visible = false;
                    new Vervolgstudies().Show();
                }
            }
        }

        private void txtMededeling_Enter(object sender, EventArgs e)
        {
            

        }

        private void txtMededeling_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void txtHerinnering_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHerinnering_Enter(object sender, EventArgs e)
        {
            
            
            
        }

        private void txtHerinnering_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtMededeling_Enter_1(object sender, EventArgs e)
        {
            
        }

        private void txtMededeling_Leave_1(object sender, EventArgs e)
        {
            
        }

        private void txtMededeling_Enter_2(object sender, EventArgs e)
        {
            if (txtMededeling.Text == "Typ hier wat u wenst mee te geven aan de leerlingen...")
            {
                txtMededeling.Text = "";
                txtMededeling.ForeColor = Color.DarkGray;
            }
        }

        private void txtMededeling_Leave_2(object sender, EventArgs e)
        {
            if (txtMededeling.Text == "")
            {
                txtMededeling.Text = "Typ hier wat u wenst mee te geven aan de leerlingen...";
                txtMededeling.ForeColor = Color.Silver;
            }
        }

        private void txtHerinnering_Enter_1(object sender, EventArgs e)
        {
            if (txtHerinnering.Text == "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business...")
            {
                txtHerinnering.Text = "";
                txtHerinnering.ForeColor = Color.DarkGray;
            }
        }

        private void txtHerinnering_Leave_1(object sender, EventArgs e)
        {
            if (txtHerinnering.Text =="")
            {
                txtHerinnering.Text = "Typ hier wat uw leukste herinneringen zijn aan Sint-Lievenscollege Business...";
                txtHerinnering.ForeColor = Color.Silver;
            }
        }

        private void txtHerinnering_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtErvaring_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtErvaring_MouseClick(object sender, MouseEventArgs e)
        {
            txtErvaring.BackColor = Color.White;
        }

        private void txtMededeling_MouseClick(object sender, MouseEventArgs e)
        {
            txtMededeling.BackColor = Color.White;
        }

        private void txtHerinnering_MouseClick(object sender, MouseEventArgs e)
        {
            txtHerinnering.BackColor = Color.White;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtMededeling_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
