using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormPersoon;


namespace Basisformulier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            this.BackgroundImage = Properties.Resources.pic;
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new EventHandler(Veranderfoto);
            tim.Start();*/
        }

        private void Veranderfoto(object sender, EventArgs e)
        {
           /* List<Bitmap> l1 = new List<Bitmap>();
            l1.Add(Properties.Resources.pccc);
            l1.Add(Properties.Resources.picc);
            int index = DateTime.Now.Second % l1.Count;
            this.BackgroundImage = l1[index];*/
        }

        private void studiesNaSintLievenscollegeBusinessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void oudLeerlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Persoon().Show();
            //Visible = false;

        }

        private void lijstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LijstOudleerlingen().Show();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void piToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registeerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
