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
            //txtMededeling.Text = "Typ hier wat u wenst mee te geven aan de leerlingen...";
        }

        private void btnToevoegenHerinnering_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            progressBar1.Visible = true;
            
            
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

        private void txtMededeling_Enter(object sender, EventArgs e)
        {
            if(txtMededeling.Text == "Typ hier wat u wenst mee te geven aan de leerlingen...")
            {
                txtMededeling.Text = "";
                txtMededeling.ForeColor = Color.Black;
            }
        }

        private void txtMededeling_Leave(object sender, EventArgs e)
        {
            if (txtMededeling.Text == "")
            {
                txtMededeling.Text = "Typ hier wat u wenst mee te geven aan de leerlingen...";
                txtMededeling.ForeColor = Color.Silver;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
           if  (progressBar1.Value == 100)
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
    }
}
