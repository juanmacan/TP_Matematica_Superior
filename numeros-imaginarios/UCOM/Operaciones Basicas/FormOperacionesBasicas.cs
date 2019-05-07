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
                    resultado = "(" + Suma.Real.ToString().Replace(",", ".") + ", " + Suma.Imaginario.ToString().Replace(",", ".") + ")";
                }
                else
                {
                    resultado = "[" + Suma.Modulo().ToString().Replace(",", ".") + "; " + Suma.Angulo().ToString().Replace(",", ".") + "]";
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
                    resultado = "(" + resta.Real.ToString().Replace(",", ".") + ", " + resta.Imaginario.ToString().Replace(",", ".") + ")";
                }
                else
                {
                    resultado = "[" + resta.Modulo().ToString().Replace(",", ".") + "; " + resta.Angulo().ToString().Replace(",", ".") + "]";
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

                NumeroComplejoFPolar Complejo1 = obtenerNumeroEnFPolar(this.textBoxNumero1.Text);
                NumeroComplejoFPolar Complejo2 = obtenerNumeroEnFPolar(this.textBoxNumero2.Text);

                NumeroComplejoFPolar multiplicacion = this.multiplicarComplejos(Complejo1, Complejo2);

                if (EsBinomica)
                {
                    resultado = "(" + multiplicacion.getReal().ToString().Replace(",", ".") + ", " + multiplicacion.getImaginario().ToString().Replace(",", ".") + ")";
                }
                else
                {
                    resultado = "[" + multiplicacion.Modulo.ToString().Replace(",", ".") + "; " + multiplicacion.Angulo.ToString().Replace(",", ".") + "]";
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

                NumeroComplejoFPolar Complejo1 = obtenerNumeroEnFPolar(this.textBoxNumero1.Text);
                NumeroComplejoFPolar Complejo2 = obtenerNumeroEnFPolar(this.textBoxNumero2.Text);

                NumeroComplejoFPolar division = this.dividirComplejos(Complejo1, Complejo2);

                if (EsBinomica)
                {
                    resultado = "(" + division.getReal().ToString().Replace(",",".") + ", " + division.getImaginario().ToString().Replace(",", ".") + ")";
                }
                else
                {
                    resultado = "[" + division.Modulo.ToString().Replace(",", ".") + "; " + division.Angulo.ToString().Replace(",", ".") + "]";
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

        public NumeroComplejoFPolar multiplicarComplejos
            (NumeroComplejoFPolar n1, NumeroComplejoFPolar n2)
        {
            return new NumeroComplejoFPolar(n1.Modulo * n2.Modulo, n1.Angulo + n2.Angulo);
        }

        public NumeroComplejoFPolar dividirComplejos
            (NumeroComplejoFPolar n1, NumeroComplejoFPolar n2)
        {
            return new NumeroComplejoFPolar(n1.Modulo / n2.Modulo, n1.Angulo - n2.Angulo);
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
                throw new Exception("El número " + texto + " no corresponde a un número complejo válido.");
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

        private void ponerResultado(String res) {
            labelResultado.Text = res;
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
