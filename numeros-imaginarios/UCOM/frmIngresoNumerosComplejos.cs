using System;
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
    public partial class frmIngresoNumerosComplejos : Form
    {
        public frmIngresoNumerosComplejos()
        {
            InitializeComponent();
        }

        private void CalcularModulo()
        {
            string[] strAux = new string[2];
            String strNumeroIngresado = this.txtNumeroIngresado.Text;

            strNumeroIngresado = strNumeroIngresado.Substring(1, strNumeroIngresado.Length - 2);

            strAux = strNumeroIngresado.Split(',');

            double real = Convert.ToDouble(strAux[0]); //Double.TryParse(strAux[0], );
            double imaginario = Convert.ToDouble(strAux[1]);

            NumeroComplejoFBinomica Complejo = new NumeroComplejoFBinomica(real, imaginario);

            this.txtResultado.Text = Complejo.Modulo().ToString("0.00");
        }

        private void BtnModulo_Click(object sender, EventArgs e)
        {
            CalcularModulo();
        }
    }
}
