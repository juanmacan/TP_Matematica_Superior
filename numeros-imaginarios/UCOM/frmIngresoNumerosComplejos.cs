using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCOM.Utils;

namespace UCOM
{
    public partial class frmIngresoNumerosComplejos : Form
    {
        public frmIngresoNumerosComplejos()
        {
            InitializeComponent();
        }

        private Boolean EsNumeroComplejoBinomica(string complejo)
        {
            return complejo.Substring(0, 1).Equals("(");
        }


        private void CalcularModulo()
        {
            FuncionesComunes objFuncion = new FuncionesComunes();
            String strNumeroIngresado = this.txtNumeroIngresado.Text;

            if (objFuncion.ValidarNumeroComplejor(strNumeroIngresado))
            {
                if (this.EsNumeroComplejoBinomica(strNumeroIngresado))
                {
                    NumeroComplejoFBinomica Complejo = objFuncion.pasaDeATextoAFormaBinomica(strNumeroIngresado);
                    this.txtResultado.Text = Complejo.Modulo().ToString();
                }
                else
                {
                    NumeroComplejoFPolar Complejo = objFuncion.pasarDeTextoAFormaPolar(strNumeroIngresado);
                    this.txtResultado.Text = Complejo.getModulo().ToString();
                }
            }else
            {
                MessageBox.Show("El número ingresado no corresponde a un número complejo", "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void CalcularArgumento()
        {
            FuncionesComunes objFuncion = new FuncionesComunes();
            String strNumeroIngresado = this.txtNumeroIngresado.Text;

            if (objFuncion.ValidarNumeroComplejor(strNumeroIngresado))
            {
                if (this.EsNumeroComplejoBinomica(strNumeroIngresado))
                {
                    NumeroComplejoFBinomica Complejo = objFuncion.pasaDeATextoAFormaBinomica(strNumeroIngresado);
                    this.txtResultado.Text = Complejo.Angulo().ToString();
                }
                else
                {
                    NumeroComplejoFPolar Complejo = objFuncion.pasarDeTextoAFormaPolar(strNumeroIngresado);
                    this.txtResultado.Text = Complejo.getAndulo().ToString();
                }
            }
            else
            {
                MessageBox.Show("El número ingresado no corresponde a un número complejo", "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModulo_Click(object sender, EventArgs e)
        {
            CalcularModulo();
        }

        private void BtnArgumento_Click(object sender, EventArgs e)
        {
            CalcularArgumento();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
