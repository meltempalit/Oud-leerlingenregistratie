using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FormInformatie
{
    public partial class FormVervolgstudiesInfo : Form
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

        public FormVervolgstudiesInfo()
        {
            InitializeComponent();
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

        private void oudleerlingGegevensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormInfo().Show();
            Visible = false;
        }

        private void ervaringenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormPostsInfo().Show();
            Visible = false;
        }

        private void werkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormVervolgstudiesInfo().Show();
            Visible = false;
        }

        private void werkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormWerkInfo().Show();
            Visible = false;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormVervolgstudiesInfo_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
