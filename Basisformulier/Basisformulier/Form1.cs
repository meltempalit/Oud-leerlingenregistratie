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
        }

        private void studiesNaSintLievenscollegeBusinessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oudLeerlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Persoon().Show();
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
    }
}
