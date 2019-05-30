using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCOM.Suma_Fasores
{
    public partial class SumaFasoresForm : Form
    {
        public SumaFasoresForm()
        {
            InitializeComponent();
        }

        private void SumarBtn_Click(object sender, EventArgs e)
        {
            string funcion1 = Fun1Txt.Text;
            string funcion2 = Fun2Txt.Text;

            //Falta implementar
            Fasor fun1 = StringToFasor(funcion1);

            Fasor fun2 = StringToFasor(funcion2);

            Fasor Resultado = SumarFasores(fun1, fun2);
            RsltTxt.Text = Resultado.GetAmplitud() + "sen(" + Resultado.GetFrecuencia() + "t + " + Resultado.GetAngulo();   
        }
    }
}
