using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lijst;

namespace Basisformulier
{
    public partial class WachtwoordBeheerder : Form
    {
        public WachtwoordBeheerder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
                if (txtWW.Text == "1250")
                {
                    new frmLijst().Show();
                    Visible = false;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    txtWW.BackColor = Color.FromArgb(242, 220, 220);
                }
          
            

            
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.FromArgb(18, 74, 111);
            btnOK.ForeColor = Color.White;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.Transparent;
            btnOK.ForeColor = Color.Black;
        }

        private void btnAnu_MouseHover(object sender, EventArgs e)
        {
            btnAnu.BackColor = Color.FromArgb(18, 74, 111);
            btnAnu.ForeColor = Color.White;
        }

        private void btnAnu_MouseLeave(object sender, EventArgs e)
        {
            btnAnu.BackColor = Color.Transparent;
            btnAnu.ForeColor = Color.Black;
        }

        private void btnOK_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtWW_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtWW_Leave(object sender, EventArgs e)
        {

            
        }

        private void txtWW_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WachtwoordBeheerder_Load(object sender, EventArgs e)
        {

        }
    }
}
