using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCOM.Operaciones_Avanzadas;
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
            var frm = new Operaciones_Basicas.FormOperacionesBasicas();

            frm.Show();
        }

        private void LblOA_Click(object sender, EventArgs e)
        {
            new OAForm().Show();
        }

        private void LblSF_Click(object sender, EventArgs e)
        {
            new Suma_Fasores.SumaFasoresForm().Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
