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
            string strTextBegin = txtErvaring.Text = "Typ hier uw ervaringen...";
            
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
    }
}
