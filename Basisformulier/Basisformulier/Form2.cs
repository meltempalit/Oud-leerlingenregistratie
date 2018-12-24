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
using Lijst;

namespace Basisformulier
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new Persoon().Show();
            
        }

        private void btnLijst_Click(object sender, EventArgs e)
        {
            new frmLijst().Show();
        }

        private void btnReg_MouseHover(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.FromArgb(18,74,111);
            btnReg.ForeColor = Color.White;
        }

        private void btnReg_MouseLeave(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.Transparent;
            btnReg.ForeColor = Color.Black;
        }

        private void btnLijst_MouseHover(object sender, EventArgs e)
        {
            btnLijst.BackColor = Color.FromArgb(18,74,111);
            btnLijst.ForeColor = Color.White;
        }

        private void btnLijst_MouseLeave(object sender, EventArgs e)
        {
            btnLijst.BackColor = Color.Transparent;
            btnLijst.ForeColor = Color.Black;
        }
    }
}
