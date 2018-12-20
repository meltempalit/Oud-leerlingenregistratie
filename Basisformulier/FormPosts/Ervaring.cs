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
    public partial class Ervaring : Form
    {
        public Ervaring()
        {
            InitializeComponent();
        }

        private void Ervaring_Load(object sender, EventArgs e)
        {
            
        }
        

        private void txtErvaring_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnToevoegenErvaring_Click(object sender, EventArgs e)
        {
            new Herinnering().Show();
            Visible = false;
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
            if(txtErvaring.Text == "Typ hier uw loopbaan/ ervaringen...")
            { txtErvaring.Text = "";
                txtErvaring.ForeColor = Color.Black;
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
    }
}
