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

namespace UCOM.Operaciones_Avanzadas
{
    public partial class OAForm : Form
    {
        public OAForm()
        {
            InitializeComponent();
        }

        private void PotenciaBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PotenciacionForm().Show();
        }

        private void RadBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RadicacionForm().Show();
        }
    }
}
