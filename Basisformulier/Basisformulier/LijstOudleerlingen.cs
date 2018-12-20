using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basisformulier
{
    public partial class LijstOudleerlingen : Form
    {
        public LijstOudleerlingen()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void txtZoek_Click(object sender, EventArgs e)
        {
            
        }



        private void txtZoek_TextChanged(object sender, EventArgs e)
        {
            

        }
        Business bus = new Business();
        private void LijstOudleerlingen_Load(object sender, EventArgs e)
        {


            foreach (string item in bus.getOudleerlingen())
            {
                lstLijst.Items.Add(item);
            }


        }

        private void txtZoek_Enter(object sender, EventArgs e)
        {
            if(txtZoek.Text == "Zoeken...")
            {
                txtZoek.Text = "";
                txtZoek.ForeColor = Color.Silver;
            }
        }

        private void txtZoek_Leave(object sender, EventArgs e)
        {
            if (txtZoek.Text == "")
            {
                txtZoek.Text = "Zoeken...";
                txtZoek.ForeColor = Color.Silver;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnZoek_MouseHover(object sender, EventArgs e)
        {
            btnZoek.BackColor = Color.SteelBlue;
            btnZoek.ForeColor = Color.White;
        }

        private void btnZoek_MouseLeave(object sender, EventArgs e)
        {
            btnZoek.BackColor = Color.Transparent;
            btnZoek.ForeColor = Color.Black;
        }

        private void lstLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
         //messagebox
        }
    }
}
