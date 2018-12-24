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
using Lijst;


namespace FormPersoon
{
    public partial class Persoon : Form
    {
        public Persoon()
        {
            InitializeComponent();
        }
        Business bus = new Business();

        public void vulForm()
        {
            bus = new Business();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            bus.voegPersoon(txtNaam.Text,txtFamilienaam.Text,txtGeboorte.Text,txtEmail.Text,txtTel.Text,txtAfst.Text,txtRichting.Text);
            vulForm();




            if (txtNaam.Text =="" || txtFamilienaam.Text =="" || txtRichting.Text ==""  )
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

                
                MessageBox.Show("U bent geregistreerd!", "Welkom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Visible = false;

                new Posts().Show();
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
        int intAvatar;
        private void Persoon_Load(object sender, EventArgs e)
        {
            vulForm();

            cboLand.Items.Add("België");
            cboLand.Items.Add("Nederland");
            cboLand.Items.Add("Anders");

            
       
            Random random = new Random();

            intAvatar = random.Next(1,24);

            switch (intAvatar)
            {
                case 1:
                    picAvatar.Image = Properties.Resources._1;
                    
                   
                    break;
                case 2:
                    picAvatar.Image = Properties.Resources._2;
                    break;

                case 3:
                    picAvatar.Image = Properties.Resources._3;
                    break;

                case 4:
                    picAvatar.Image = Properties.Resources._4;
                    break;

                case 5:
                    picAvatar.Image = Properties.Resources._5;
                    break;
                case 6:
                    picAvatar.Image = Properties.Resources._6;
                    break;
                case 7:
                    picAvatar.Image = Properties.Resources._7;
                    break;
                case 8:
                    picAvatar.Image = Properties.Resources._8;
                    break;
                case 9:
                    picAvatar.Image = Properties.Resources._9;
                    break;
                case 10:
                    picAvatar.Image = Properties.Resources._10;
                    break;
                case 11:
                    picAvatar.Image = Properties.Resources._11;
                    break;
                case 12:
                    picAvatar.Image = Properties.Resources._12;
                    break;
                case 13:
                    picAvatar.Image = Properties.Resources._13;
                    break;
                case 14:
                    picAvatar.Image = Properties.Resources._141;
                    break;
                case 15:
                    picAvatar.Image = Properties.Resources._15;
                    break;
                case 16:
                    picAvatar.Image = Properties.Resources._16;
                    break;
                case 17:
                    picAvatar.Image = Properties.Resources._17;
                    break;
                case 19:
                    picAvatar.Image = Properties.Resources._19;
                    break;
                case 18:
                    picAvatar.Image = Properties.Resources._18;
                    break;
                case 20:
                    picAvatar.Image = Properties.Resources._20;
                    break;
                case 21:
                    picAvatar.Image = Properties.Resources._21;
                    break;
                case 22:
                    picAvatar.Image = Properties.Resources._22;
                    break;
                case 23:
                    picAvatar.Image = Properties.Resources._23;
                    break;
                case 24:
                    picAvatar.Image = Properties.Resources._24;
                    break;






            }


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
                txtEmail.ForeColor = Color.Silver;
                this.txtEmail.Font = new Font(this.txtEmail.Font, FontStyle.Regular);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "someone@example.com";
                txtEmail.ForeColor = Color.Silver;
                this.txtEmail.Font = new Font(this.txtEmail.Font, FontStyle.Italic);

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

        private void btnRegistreer_MouseHover(object sender, EventArgs e)
        {
           
            btnRegistreer.BackColor = Color.SteelBlue;
            btnRegistreer.ForeColor = Color.White;
        }

        private void btnRegistreer_MouseLeave(object sender, EventArgs e)
        {
            

            btnRegistreer.BackColor = Color.Transparent;
            btnRegistreer.ForeColor = Color.Black;

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGeboortedatum_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void cboLand_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Silver;
            Font ft = cboLand.Font; ;
            e.Graphics.DrawString(cboLand.Items[e.Index].ToString(), ft, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void cboLand_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 20;
        }

        private void txtRichting_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGeboorte_Enter(object sender, EventArgs e)
        {
            if (txtGeboorte.Text == "dd/mm/jjjj")
            {
                txtGeboorte.Text = "";
                txtGeboorte.ForeColor = Color.Silver;
                this.txtGeboorte.Font = new Font(this.txtGeboorte.Font, FontStyle.Regular);
            }
        }

        private void txtGeboorte_Leave(object sender, EventArgs e)
        {
            if (txtGeboorte.Text == "")
            {
                txtGeboorte.Text = "dd/mm/jjjj";
                txtGeboorte.ForeColor = Color.Silver;
                this.txtGeboorte.Font = new Font(this.txtGeboorte.Font, FontStyle.Italic);

            }
        }

        private void txtNaam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAfst_Enter(object sender, EventArgs e)
        {
            if(txtAfst.Text == "2019")
            {
                txtAfst.Text = "";
                txtAfst.ForeColor = Color.Silver;
                this.txtAfst.Font = new Font(txtAfst.Font, FontStyle.Regular);
                
            }
        }

        private void txtAfst_Leave(object sender, EventArgs e)
        {

        }
    }
}
