﻿using System;
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
    }
}
