using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Lijst;



namespace Lijst
{
    public partial class Verwijder : Form
    {
        public Verwijder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        MySqlConnection connection = new MySqlConnection("server=localhost;Password='Test123';user id=root;database=oudleerlingen");
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Weet u zeker dat u de gegevens wilt verwijderen?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (msg == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM personen where idPersonen=" + textBox1.Text;
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                    //string deleteQuery1 = "DELETE FROM posts where idPosts=" + textBox1.Text
                   // MySqlCommand cmd1 = new MySqlCommand(deleteQuery1, connection);
                
                    if (cmd.ExecuteNonQuery() == 1 )
                    {


                      DialogResult dlg =   MessageBox.Show("Succesvol verwijdert!", "Verwijdering", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (dlg == DialogResult.OK)
                        {
                            Close();
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

