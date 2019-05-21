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

namespace UCOM.Operaciones_Avanzadas
{
    public partial class RadicacionForm : Form
    {
        private Boolean EsBinomica;

        public RadicacionForm()
        {
            InitializeComponent();
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

        private void CalcularRaiz()
        {
            string strResultado = "";
            string strResultadoAMostrar = "";
            NumeroComplejoFPolar numero = obtenerNumeroEnFPolar(NumTxt.Text);
            Double Raiz = Double.Parse(RaizTxt.Text);

            int CantidadDeRespuestas = int.Parse(RaizTxt.Text);
            double potencia = (double)1 / CantidadDeRespuestas;

            for (int i = 0; i < CantidadDeRespuestas; i++)
            {
                Double Angulo = (numero.Angulo + (2 * i * Math.PI)) / CantidadDeRespuestas;
                NumeroComplejoFPolar Resultado = new NumeroComplejoFPolar(Math.Pow(numero.Modulo, potencia), Angulo);

                if (EsBinomica)
                {
                    NumeroComplejoFBinomica NBinomica = Resultado.TransformarABinomica();
                    strResultado = "(" + NBinomica.Real + ", " + NBinomica.Imaginario + ")";
                }
                else
                {
                    strResultado = "[" + Resultado.Modulo + "; " + Resultado.Angulo + "]";
                }

                strResultadoAMostrar += "W" + i.ToString() + " = " + strResultado+ "\n";
            }

            lblResultados.Text = strResultadoAMostrar;
        }

        private string ValidarCampos()
        {
            string respuesta = "";

            if (NumTxt.Text == "")
            {
                respuesta += "Debe ingresar un número complejo.\n";
            }
            if (RaizTxt.Text == "")
            {
                respuesta += "Debe ingresar una Raíz.\n";
            }

            return respuesta;
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string validacion = ValidarCampos();

            if (validacion == "")
            {
                this.CalcularRaiz();
            }
            else
            {
                MessageBox.Show(validacion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
