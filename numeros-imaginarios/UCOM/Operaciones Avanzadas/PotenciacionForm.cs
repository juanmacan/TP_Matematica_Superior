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
        public PotenciacionForm()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            string numero = NumTxt.Text;
            double potencia = Double.Parse(PotTxt.Text);
            
            FuncionesComunes funcs = new FuncionesComunes();
            if (funcs.EsNumeroComplejoBinomica(numero))
            {
                NumeroComplejoFBinomica num = funcs.pasaDeATextoAFormaBinomica(numero);
                NumeroComplejoFPolar nump = new NumeroComplejoFPolar(Math.Pow(num.Modulo(), potencia), num.Angulo()*potencia);

                NumeroComplejoFBinomica Resultado = nump.TransformarABinomica();

                RsltTxt.Text = "(" + Resultado.Real +"," + Resultado.Imaginario +")";
            }
            else
            {
                NumeroComplejoFPolar num = funcs.pasarDeTextoAFormaPolar(numero);
                NumeroComplejoFPolar Resultado = new NumeroComplejoFPolar(Math.Pow(num.Modulo, potencia), num.Angulo * potencia);

                RsltTxt.Text = "[" + Resultado.Modulo + "," + Resultado.Angulo + "]";
            }
           
        }
       
    }
}
