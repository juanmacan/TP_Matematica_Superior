using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCOM.Utils;

namespace UCOM.Operaciones_Avanzadas
{
    public partial class PotenciacionForm : Form
    {
        private Boolean EsBinomica;

        public PotenciacionForm()
        {
            InitializeComponent();
        }

        private void CalcularPotencia()
        {
            try
            {
                NumeroComplejoFPolar numero = obtenerNumeroEnFPolar(NumTxt.Text);
                Double potencia = Double.Parse(PotTxt.Text);

                NumeroComplejoFPolar Resultado = new NumeroComplejoFPolar(Math.Pow(numero.Modulo, potencia), numero.Angulo * potencia);

                if (EsBinomica)
                {
                    NumeroComplejoFBinomica NBinomica = Resultado.TransformarABinomica();
                    RsltTxt.Text = "(" + NBinomica.Real +"," + NBinomica.Imaginario +")";
                }
                else
                {
                    RsltTxt.Text = "[" + Resultado.Modulo + "," + Resultado.Angulo + "]";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public NumeroComplejoFPolar obtenerNumeroEnFPolar(string texto)
        {
            FuncionesComunes objFuncion = new FuncionesComunes();
            if (objFuncion.ValidarNumeroComplejor(texto))
            {
                if (objFuncion.EsNumeroComplejoBinomica(texto))
                {
                    EsBinomica = true;
                    NumeroComplejoFBinomica Complejo = objFuncion.pasaDeATextoAFormaBinomica(texto);
                    return Complejo.TransformarAPolar();
                }
                else
                {
                    EsBinomica = false;
                    return objFuncion.pasarDeTextoAFormaPolar(texto);
                }
            }
            else
            {
                throw new Exception("El número " + texto + " no corresponde a un número complejo válido.");
            }
        }

        private string ValidarCampos()
        {
            string respuesta = "";

            if (NumTxt.Text == "")
            {
                respuesta += "Debe ingresar un número complejo.\n";
            }
            if (PotTxt.Text == "")
            {
                respuesta += "Debe ingresar una potencia.\n";
            }

            return respuesta;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string validacion = ValidarCampos();

            if (validacion == "")
            {
                this.CalcularPotencia();
            }
            else
            {
                MessageBox.Show(validacion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmIngresarPINroComplejo_Click(object sender, EventArgs e)
        {
            NumTxt.Text = NumTxt.Text + "π";
        }

        private void btmIngresarPIPotencia_Click(object sender, EventArgs e)
        {
            PotTxt.Text = PotTxt.Text + "π";
        }
    }
}
