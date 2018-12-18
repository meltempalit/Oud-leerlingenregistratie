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

namespace FormPersoon
{
    public partial class Persoon : Form
    {
        public Persoon()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            new Ervaring().Show();
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

        private void Persoon_Load(object sender, EventArgs e)
        {
           
        }
    }
}
