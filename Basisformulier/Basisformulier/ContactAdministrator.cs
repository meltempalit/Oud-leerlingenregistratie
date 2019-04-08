using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace Basisformulier
{
    public partial class ContactAdministrator : Form
         
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

        public ContactAdministrator()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage msg = new MailMessage(textVN.Text, "oudleerlingenproject@gmail.com", textOnderwerp.Text, textTekst.Text); // oudleerlingenproject@gmail.com WW: 12501250
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential(textVN.Text, textPWMAIL.Text);//your mail password
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg); /*https:/myaccount.google.com/lesssecureapps*/ 
            MessageBox.Show("Mail Send");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void llblclose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
