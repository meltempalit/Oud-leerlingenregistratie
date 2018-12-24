using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lijst
{
    public partial class frmLijst : Form
    {
        public frmLijst()
        {
            InitializeComponent();
        }
        Business bus = new Business();
        private void frmLijst_Load(object sender, EventArgs e)
        {

            foreach(string item in bus.getOudleerlingen())
            {
                lstLijst.Items.Add(item);
            }

        }

        private void llblclose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void lstLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnZoek_MouseHover(object sender, EventArgs e)
        {
            btnZoek.BackColor = Color.FromArgb(18,74,111);
            btnZoek.ForeColor = Color.White;
        }

        private void btnZoek_MouseLeave(object sender, EventArgs e)
        {
            btnZoek.BackColor = Color.Transparent;
            btnZoek.ForeColor = Color.Black;
        }
    }
}
