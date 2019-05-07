using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCOM;
using UCOM.Utils;

namespace UCOM.Operaciones_Basicas
{
    public partial class FormOperacionesBasicas : Form
    {
        public Boolean EsBinomica;

        public FormOperacionesBasicas()
        {
            InitializeComponent();
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            this.EjecutarSuma();
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            this.EjecutarResta();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            this.EjecutarMultiplicacion();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            this.EjecutarDivision();
        }

        public void EjecutarSuma()
        {
            try
            {
                string resultado;

                NumeroComplejoFBinomica Complejo1 = obtenerNumeroEnFBinomica(this.textBoxNumero1.Text);
                NumeroComplejoFBinomica Complejo2 = obtenerNumeroEnFBinomica(this.textBoxNumero2.Text);

                NumeroComplejoFBinomica Suma = this.SumarBinomica(Complejo1, Complejo2);

                if (EsBinomica)
                {
                    resultado = "(" + Suma.Real.ToString() + ", " + Suma.Imaginario.ToString() + ")";
                }
                else
                {
                    resultado = "[" + Suma.Modulo().ToString() + "; " + Suma.Angulo().ToString() + "]";
                }

                this.ponerResultado(resultado);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EjecutarResta()
        {
            try
            {
                string resultado;

                NumeroComplejoFBinomica Complejo1 = obtenerNumeroEnFBinomica(this.textBoxNumero1.Text);
                NumeroComplejoFBinomica Complejo2 = obtenerNumeroEnFBinomica(this.textBoxNumero2.Text);

                NumeroComplejoFBinomica resta = this.restarBinomica(Complejo1, Complejo2);

                if (EsBinomica)
                {
                    resultado = "(" + resta.Real.ToString() + ", " + resta.Imaginario.ToString() + ")";
                }
                else
                {
                    resultado = "[" + resta.Modulo().ToString() + "; " + resta.Angulo().ToString() + "]";
                }

                this.ponerResultado(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EjecutarMultiplicacion()
        {
            try
            {
                string resultado;

                NumeroComplejoFBinomica Complejo1 = obtenerNumeroEnFBinomica(this.textBoxNumero1.Text);
                NumeroComplejoFBinomica Complejo2 = obtenerNumeroEnFBinomica(this.textBoxNumero2.Text);

                NumeroComplejoFBinomica multiplicacion = this.multiplicarBinomica(Complejo1, Complejo2);

                if (EsBinomica)
                {
                    resultado = "(" + multiplicacion.Real.ToString() + ", " + multiplicacion.Imaginario.ToString() + ")";
                }
                else
                {
                    resultado = "[" + multiplicacion.Modulo().ToString() + "; " + multiplicacion.Angulo().ToString() + "]";
                }

                this.ponerResultado(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EjecutarDivision()
        {
            try
            {
                string resultado;

                NumeroComplejoFBinomica Complejo1 = obtenerNumeroEnFBinomica(this.textBoxNumero1.Text);
                NumeroComplejoFBinomica Complejo2 = obtenerNumeroEnFBinomica(this.textBoxNumero2.Text);

                NumeroComplejoFBinomica division = this.dividirBinomica(Complejo1, Complejo2);

                if (EsBinomica)
                {
                    resultado = "(" + division.Real.ToString() + ", " + division.Imaginario.ToString() + ")";
                }
                else
                {
                    resultado = "[" + division.Modulo().ToString() + "; " + division.Angulo().ToString() + "]";
                }

                this.ponerResultado(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public NumeroComplejoFBinomica SumarBinomica(NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            NumeroComplejoFBinomica Resultado = new NumeroComplejoFBinomica(n1.Real + n2.Real, n1.Imaginario + n2.Imaginario);

            return Resultado;
        }

        public NumeroComplejoFBinomica restarBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            return new NumeroComplejoFBinomica
                (n1.Real - n2.Real, n1.Imaginario - n2.Imaginario);
        }

        public NumeroComplejoFBinomica multiplicarBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            double multiReales = (n1.Real * n2.Real)
                                    -(n1.Imaginario*n2.Imaginario);
            double multiImaginarios = (n1.Real * n2.Imaginario)
                                             + (n1.Imaginario * n2.Real);
            return new NumeroComplejoFBinomica(multiReales, multiImaginarios);
        }

        public NumeroComplejoFBinomica dividirBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            double divisor = Math.Pow(n2.Real, 2) + Math.Pow(n2.Imaginario, 2);
            NumeroComplejoFBinomica dividendo = this.multiplicarBinomica(n1,
                                            n2.conjugado());

            double multiReales = (n1.Real * n2.Real)
                                    - (n1.Imaginario * n2.Imaginario);
            double multiImaginarios = (n1.Real * n2.Imaginario)
                                             + (n1.Imaginario * n2.Real);
            return new NumeroComplejoFBinomica(multiReales, multiImaginarios);
        }

        public NumeroComplejoFBinomica obtenerNumeroEnFBinomica(string texto)
        {
            FuncionesComunes objFuncion = new FuncionesComunes();
            if (objFuncion.ValidarNumeroComplejor(texto))
            {
                if (objFuncion.EsNumeroComplejoBinomica(texto))
                {
                    EsBinomica = true;
                    return objFuncion.pasaDeATextoAFormaBinomica(texto);
                }
                else
                {
                    EsBinomica = false;
                    NumeroComplejoFPolar Complejo = objFuncion.pasarDeTextoAFormaPolar(texto);
                    return Complejo.TransformarABinomica();
                }
            }
            else
            {
                throw new Exception("El número ingresado no corresponde a un número complejo");
            }
        }

        private void ponerResultado(String res) {
            labelResultado.Text = res;
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
