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
using System.IO;






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
                lstLijst.Items.Add(item); ///
            }
            panel1.BackColor = Color.FromArgb(18, 74, 111);

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
          
        }

        private void btnZoek_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void txtZoek_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtZoek_Leave(object sender, EventArgs e)
        {
            
        }

        
        private void btnZoek_Click(object sender, EventArgs e)
        {
         /*   MySqlConnection connection = new MySqlConnection("server = localhost; user id = root; database = oudleerlingen; Password = 'Test123'");
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * from personen where naam like'%" + txtZoek.Text + "%'", connection);
            da.Fill(dt);

            lstLijst.DataSource = null;
            lstLijst.DataSource = dt;
            lstLijst.ValueMember = "idpersonen";
            lstLijst.DisplayMember = "naam";*/
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

                
              if( Convert.ToInt32( Convert.ToString( lstLijst.SelectedItem).Substring(0,1)) <= 9)
                {
                    connection.Open();
                    MySqlCommand cmd1teken = new MySqlCommand("DELETE FROM posts where idPosts=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1), connection);
                    MySqlCommand cmd1 = new MySqlCommand("DELETE FROM personen where idPersonen=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1), connection);
                    MySqlCommand cmd2 = new MySqlCommand("DELETE FROM werk where idWerk=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1), connection);
                    MySqlCommand cmd3 = new MySqlCommand("DELETE FROM vervolgstudies where idVervolgstudies=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 1), connection);
                    cmd1teken.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    connection.Close();
                                       
              }
                 if(Convert.ToInt32(Convert.ToString(lstLijst.SelectedItem).Substring(0, 2)) >= 10)
                 {
                    connection.Open();
                    MySqlCommand cmd2tekens = new MySqlCommand("DELETE FROM posts where idPosts=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 2), connection);
                    MySqlCommand cmd1_1 = new MySqlCommand("DELETE FROM personen where idPersonen=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 2), connection);
                    MySqlCommand cmd2_2 = new MySqlCommand("DELETE FROM werk where idWerk=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 2), connection);
                    MySqlCommand cmd3_3 = new MySqlCommand("DELETE FROM vervolgstudies where idVervolgstudies=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 2), connection);
                    cmd2tekens.ExecuteNonQuery();
                    cmd1_1.ExecuteNonQuery();
                    cmd2_2.ExecuteNonQuery();
                    cmd3_3.ExecuteNonQuery();
                    connection.Close();
                    if (Convert.ToInt32(Convert.ToString(lstLijst.SelectedItem).Substring(0, 3)) >= 100)
                    {
                        connection.Open();
                        MySqlCommand cmd3tekens = new MySqlCommand("DELETE FROM posts where idPosts=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 3), connection);
                        MySqlCommand cmd1_1_1 = new MySqlCommand("DELETE FROM personen where idPersonen=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 3), connection);
                        MySqlCommand cmd2_2_2 = new MySqlCommand("DELETE FROM werk where idWerk=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 3), connection);
                        MySqlCommand cmd3_3_3 = new MySqlCommand("DELETE FROM vervolgstudies where idVervolgstudies=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 3), connection);
                        cmd3tekens.ExecuteNonQuery();
                        cmd1_1_1.ExecuteNonQuery();
                        cmd2_2_2.ExecuteNonQuery();
                        cmd3_3_3.ExecuteNonQuery();
                        connection.Close();
                        if (Convert.ToInt32(Convert.ToString(lstLijst.SelectedItem).Substring(0, 4)) >= 1000)
                        {
                            connection.Open();
                            MySqlCommand cmd4tekens = new MySqlCommand("DELETE FROM posts where idPosts=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 4), connection);
                            MySqlCommand cmd1_1_1_1 = new MySqlCommand("DELETE FROM personen where idPersonen=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 4), connection);
                            MySqlCommand cmd2_2_2_2 = new MySqlCommand("DELETE FROM werk where idWerk=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 4), connection);
                            MySqlCommand cmd3_3_3_3 = new MySqlCommand("DELETE FROM vervolgstudies where idVervolgstudies=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 4), connection);
                            cmd4tekens.ExecuteNonQuery();
                            cmd1_1_1_1.ExecuteNonQuery();
                            cmd2_2_2_2.ExecuteNonQuery();
                            cmd3_3_3_3.ExecuteNonQuery();
                            connection.Close();

                            if (Convert.ToInt32(Convert.ToString(lstLijst.SelectedItem).Substring(0, 5)) > 10000)
                            {
                                connection.Open();
                                MySqlCommand cmd5tekens = new MySqlCommand("DELETE FROM posts where idPosts=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 5), connection);
                                MySqlCommand cmd1_1_1_1_1 = new MySqlCommand("DELETE FROM personen where idPersonen=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 5), connection);
                                MySqlCommand cmd2_2_2_2_2 = new MySqlCommand("DELETE FROM werk where idWerk=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 5), connection);
                                MySqlCommand cmd3_3_3_3_3 = new MySqlCommand("DELETE FROM vervolgstudies where idVervolgstudies=" + Convert.ToString(lstLijst.SelectedItem).Substring(0, 5), connection);
                                cmd5tekens.ExecuteNonQuery();
                                cmd1_1_1_1_1.ExecuteNonQuery();
                                cmd2_2_2_2_2.ExecuteNonQuery();
                                cmd3_3_3_3_3.ExecuteNonQuery();
                                connection.Close();
                            }

                        }
                    }
                 }
                 
                MessageBox.Show("succesvol verwijdert");
                Close();
                new frmLijst().Show();
                panel1.BackColor = Color.FromArgb(18, 74, 111);
            }






        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for(int i = 0;i < lstLijst.Items.Count;i++)
                {
                    writer.WriteLine((string)lstLijst.Items[i]);
                }
                writer.Close();
            }
            dlg.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(18, 74, 111);
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Close();
            new frmLijst().Show();
            panel1.BackColor = Color.FromArgb(18, 74, 111);

        }

        private void lstlijst2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
