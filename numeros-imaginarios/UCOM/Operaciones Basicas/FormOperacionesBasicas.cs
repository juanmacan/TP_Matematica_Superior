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

namespace UCOM.Operaciones_Basicas
{
    public partial class FormOperacionesBasicas : Form
    {
        public FormOperacionesBasicas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {

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

        

        private void ponerResultado(String res) {
            labelResultado.Text = res;
        }

        private void FormOperacionesBasicas_Load(object sender, EventArgs e)
        {

        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
