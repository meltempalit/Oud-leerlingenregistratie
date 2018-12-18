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
    public partial class Mededeling : Form
    {
        public Mededeling()
        {
            InitializeComponent();
        }

        private void txtMededeling_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Mededeling_Load(object sender, EventArgs e)
        {
            txtMededeling.Text = "Typ hier wat u wenst mee te geven aan de leerlingen...";
        }

        private void btnToevoegenHerinnering_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesvol toegevoegd!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Visible = false;
        }

        private void lnklAnnu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          DialogResult dialogresult =  MessageBox.Show("Weet u zeker dat u wilt afsluiten?", "Afsluiten bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if(dialogresult == DialogResult.Yes)
            {
                Visible = false;
            }
            else
            {

            }
            

            
        }
    }
}
