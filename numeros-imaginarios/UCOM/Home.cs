﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCOM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void lblEDT_Click(object sender, EventArgs e)
        {
            var frm = new frmIngresoNumerosComplejos();

            frm.Show();
        }

        private void LblOB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En progreso...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LblOA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En progreso...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LblSF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En progreso...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
