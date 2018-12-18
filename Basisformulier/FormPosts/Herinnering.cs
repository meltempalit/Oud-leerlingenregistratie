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
    public partial class Herinnering : Form
    {
        public Herinnering()
        {
            InitializeComponent();
        }

        private void Herinnering_Load(object sender, EventArgs e)
        {
            txtHerinneringen.Text = "Typ hier wat uw leukste herinnering zijn aan Sint-Joris?...";
        }

        private void txtHerinneringen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Mededeling().Show();
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
