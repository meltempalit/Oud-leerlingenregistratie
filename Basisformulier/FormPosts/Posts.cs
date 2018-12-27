using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPosts
{
    public partial class Posts : Form
    {
        public Posts()
        {
            InitializeComponent();
        }
        private Business bus;
        private void Ervaring_Load(object sender, EventArgs e)
        {
            vulForm();
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

            bus.voegToe(txtErvaring.Text, txtMededeling.Text, txtHerinnering.Text);
            vulForm();
            
            this.timer1.Start();
            progressBar1.Visible = true;

        }

        private void lnklAnnu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "Afsluiten bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (dialogresult == DialogResult.Yes)
            {
                Visible = false;
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
                DialogResult dialogResult = MessageBox.Show("Succesvol toegevoegd!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Visible = false;
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
    }
}
