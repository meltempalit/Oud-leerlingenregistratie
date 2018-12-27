using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPosts;
using FormInformatie;




namespace Lijst
{
    public partial class frmLijst : Form
    {
        public frmLijst()
        {
            InitializeComponent();
        }
        Business bus = new Business();
        private void frmLijst_Load(object sender, EventArgs e)
        {

            foreach (string item in bus.getOudleerlingen())
            {
                lstLijst.Items.Add(item);
            }

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

        private void lstLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            new FormInfo().Show();
            Visible = false;
        }

        private void btnZoek_MouseHover(object sender, EventArgs e)
        {
            btnZoek.BackColor = Color.FromArgb(18, 74, 111);
            btnZoek.ForeColor = Color.White;
        }

        private void btnZoek_MouseLeave(object sender, EventArgs e)
        {
            btnZoek.BackColor = Color.Transparent;
            btnZoek.ForeColor = Color.Black;
        }

        private void txtZoek_Enter(object sender, EventArgs e)
        {
            if (txtZoek.Text == "Zoeken...")
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

        private void btnZoek_Click(object sender, EventArgs e)
        {



          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
