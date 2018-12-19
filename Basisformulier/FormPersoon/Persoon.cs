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
            //new Ervaring().Show();
           // Visible = false;

            if(txtNaam.Text =="" || txtFamilienaam.Text =="" || txtRichting.Text =="" || txtGeboortedatum.Text =="" || txtAfstudeerjaar.Text == "" )
            {
                MessageBox.Show("U moet iets ingeven!","Fout",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
               
                if(txtNaam.Text=="")
                {
                    lblNaam.ForeColor = Color.Red;
                }
                if (txtFamilienaam.Text == "")
                {
                    lblFamilienaam.ForeColor = Color.Red;
                }
                
                if (txtRichting.Text == "")
                {
                    lblafstrichting.ForeColor = Color.Red;
                }
            }
            else
            {
                new Ervaring().Show();
               Visible = false;

            }


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
            cboLand.Items.Add("België");
            cboLand.Items.Add("Nederland");
            cboLand.Items.Add("Anders");



        }

        private void cboLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLand.SelectedItem == "België")
            {
                txtTel.Text = "+32";
            }
            else if (cboLand.SelectedItem == "Nederland")
            {
                txtTel.Text = "+31";
            }
            else if(cboLand.SelectedItem == "Anders")
            {
                txtTel.Text = "";
            }


        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "someone@example.com")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "someone@example.com";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
