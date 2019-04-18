using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public NumeroComplejoFBinomica sumarBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2) 
        {
                return new NumeroComplejoFBinomica
                    (n1.getReal() + n2.getReal(), n1.getImaginario() + n2.getImaginario());
        }

        public NumeroComplejoFBinomica restarBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            return new NumeroComplejoFBinomica
                (n1.getReal() - n2.getReal(), n1.getImaginario() - n2.getImaginario());
        }

        public NumeroComplejoFBinomica multiplicarBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            double multiReales = (n1.getReal() * n2.getReal())
                                    -(n1.getImaginario()*n2.getImaginario());
            double multiImaginarios = (n1.getReal() * n2.getImaginario())
                                             + (n1.getImaginario() * n2.getReal());
            return new NumeroComplejoFBinomica(multiReales, multiImaginarios);
        }

        public NumeroComplejoFBinomica dividirBinomica
            (NumeroComplejoFBinomica n1, NumeroComplejoFBinomica n2)
        {
            double divisor = Math.Pow(n2.getReal(), 2) + Math.Pow(n2.getImaginario(), 2);
            NumeroComplejoFBinomica dividendo = this.multiplicarBinomica(n1,
                                            n2.conjugado());

            double multiReales = (n1.getReal() * n2.getReal())
                                    - (n1.getImaginario() * n2.getImaginario());
            double multiImaginarios = (n1.getReal() * n2.getImaginario())
                                             + (n1.getImaginario() * n2.getReal());
            return new NumeroComplejoFBinomica(multiReales, multiImaginarios);
        }

        

        private void ponerResultado(String res) {
            labelResultado.Text = res;
        }
    }
}
