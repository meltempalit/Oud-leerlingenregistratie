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
using FormVervolgstudies;
using FormWerk;

namespace FormKeuze
{
    public partial class keuze : Form
    {
        public keuze()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Ervaring().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
