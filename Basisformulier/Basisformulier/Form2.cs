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
using Microsoft.VisualBasic;
using System.Runtime.InteropServices; // 


namespace Basisformulier
{
    public partial class Form2 : Form
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


        public Form2()
        {
            InitializeComponent();
           this.FormBorderStyle = FormBorderStyle.None;
           this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
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

        private void btnReg_Click(object sender, EventArgs e)
        {
            new Persoon().Show();
            
        }

        private void btnLijst_Click(object sender, EventArgs e)
        {
            new WachtwoordBeheerder().Show();

           // new frmLijst().Show();
        }

        private void btnReg_MouseHover(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.FromArgb(18,74,111);
            btnReg.ForeColor = Color.White;
        }

        private void btnReg_MouseLeave(object sender, EventArgs e)
        {
            btnReg.BackColor = Color.Transparent;
            btnReg.ForeColor = Color.MidnightBlue;
        }

        private void btnLijst_MouseHover(object sender, EventArgs e)
        {
            btnLijst.BackColor = Color.FromArgb(18,74,111);
            btnLijst.ForeColor = Color.White;
        }

        private void btnLijst_MouseLeave(object sender, EventArgs e)
        {
            btnLijst.BackColor = Color.Transparent;
            btnLijst.ForeColor = Color.MidnightBlue;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.Color.FromArgb(18, 74, 111);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
