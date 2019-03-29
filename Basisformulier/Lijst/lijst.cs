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
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;






namespace Lijst
{
    public partial class frmLijst : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
            (

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );
        public frmLijst()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private const int CS_schaduw = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_schaduw;
                return cp;
            }
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
            // new FormInfo().Show();
            // Visible = false;
            btnVerwijder.Enabled = true;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerwijder_MouseHover(object sender, EventArgs e)
        {
            btnVerwijder.BackColor = Color.FromArgb(18, 74, 111);
            btnVerwijder.ForeColor = Color.White;
        }

        private void btnVerwijder_MouseLeave(object sender, EventArgs e)
        {
            btnVerwijder.BackColor = Color.Transparent;
            btnVerwijder.ForeColor = Color.Black;
        }

        private void lstLijst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new FormInfo().Show();
            Visible = false;
        }


        //verwijderen 
        MySqlConnection connection = new MySqlConnection("server=localhost;Password='Test123';user id=root;database=oudleerlingen");
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            //new Verwijder().Show();


            DialogResult msg = MessageBox.Show("Weet u zeker dat u de gegevens wilt verwijderen?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (msg == DialogResult.Yes)
            {
                try
                { 
                    string deleteQuery = "DELETE FROM personen where idPersonen=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1);
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                    string deleteQuery1 = "DELETE FROM posts where idPosts=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1);
                    MySqlCommand cmd1 = new MySqlCommand(deleteQuery1, connection);
                    string deleteQuery2 = "DELETE FROM vervolgstudies where idVervolgstudies=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1);
                    MySqlCommand cmd2 = new MySqlCommand(deleteQuery2, connection);
                    string deleteQuery3 = "DELETE FROM werk where idWerk=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1);
                    MySqlCommand cmd3 = new MySqlCommand(deleteQuery3, connection);

                    if (cmd.ExecuteNonQuery()  == 1)
                    {
                        if(cmd1.ExecuteNonQuery()==1)
                        {
                            if (cmd2.ExecuteNonQuery() == 1)
                            {
                                if (cmd3.ExecuteNonQuery() == 1)
                                {
                                    DialogResult dlg = MessageBox.Show("Succesvol verwijdert!", "Verwijdering", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (dlg == DialogResult.OK)
                                    {
                                        Close();
                                    }
                                }
                            }
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show("ERROR 4#$%#$%#$^%^$^#$%#$ KON NIET VERWIJDEREN$%#$$", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();


            }





        }
    }
}
