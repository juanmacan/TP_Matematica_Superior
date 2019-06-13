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

namespace UCOM.Suma_Fasores
{
    public partial class SumaFasoresForm : Form
    {
        public SumaFasoresForm()
        {
            InitializeComponent();
        }

        //Parsear un string y convertirlo a Fasor.Falta terminar
        public Fasor StringToFasor(string strFasor)
        {
            Double Amplitud = 0;
            Double Frecuencia = 0;
            Double Angulo = 0;
            Boolean esCoseno;

            int aux;
            int aux2;
            string aux3;
            string[] aux4;

            strFasor = strFasor.ToLower();
            strFasor = strFasor.Replace(" ", "");

            if (strFasor.Contains("cos"))
            {
                esCoseno = true;

                if (strFasor.StartsWith("cos"))
                {
                    Amplitud = 1;
                }
                else
                {
                    aux = strFasor.IndexOf('c');
                    if (!Double.TryParse(strFasor.Substring(0, aux), out Amplitud))
                    {
                        throw new Exception("El fasor ingresado es incorrecto.");
                    }
                }
            }
            else
            {
                if (strFasor.Contains("sen"))
                {
                    esCoseno = false;
                    if (strFasor.StartsWith("sen"))
                    {
                        Amplitud = 1;
                    }
                    else
                    {
                        aux = strFasor.IndexOf('s');
                        if (!Double.TryParse(strFasor.Substring(0, aux), out Amplitud))
                        {
                            throw new Exception("El fasor ingresado es incorrecto.");
                        }
                    }
                }
                else
                {
                    throw new Exception("El fasor ingresado es incorrecto.");
                }
            }

            aux = strFasor.IndexOf('(');
            aux2 = strFasor.IndexOf(')');

            aux3 = strFasor.Substring(aux + 1, aux2 - aux - 1);
            aux4 = aux3.Split('+');
            if (aux4.Length != 2)
            {
                aux4 = aux3.Split('-');
                if (Double.TryParse(aux4[1], out Angulo))
                {
                    Angulo *= (-1);
                }
                else
                {
                    throw new Exception("El fasor ingresado es incorrecto.");
                }
            }
            else
            {
                if (!Double.TryParse(aux4[1], out Angulo))
                {
                    throw new Exception("El fasor ingresado es incorrecto.");
                }
            }
            if (!aux4[0].Contains("t"))
            {
                throw new Exception("La frecuencia debe estar multiplicada por la variable 't', ejemplo '3t'.");
            }
            strFasor = aux4[0].Replace("t", "");
            if (!Double.TryParse(strFasor, out Frecuencia))
            {
                throw new Exception("El fasor ingresado es incorrecto.");
            }

            Fasor fas = new Fasor(Amplitud, Frecuencia, Angulo, esCoseno);

            return fas;
        }

        
        public Fasor SumarFasores(Fasor fas1, Fasor fas2)
        {
            if (fas1.GetFrecuencia() == fas2.GetFrecuencia())
            {
                NumeroComplejoFBinomica fun1 = fas1.ConvertirABinomica();
                NumeroComplejoFBinomica fun2 = fas2.ConvertirABinomica();

                NumeroComplejoFBinomica resultado = new NumeroComplejoFBinomica((fun1.Real + fun2.Real), (fun1.Imaginario + fun2.Imaginario));
                return new Fasor(resultado.Modulo(), fas1.GetFrecuencia(), resultado.Angulo(), false);
            }
            else
            {
                throw new Exception("Ingrese 2 complejos con igual frecuencia.");
            }
        }

        private void CalcularFasor()
        {
            FuncionesComunes objFuncion = new FuncionesComunes();

            string funcion1 = Fun1Txt.Text;
            string funcion2 = Fun2Txt.Text;

           
            try
            {
                Fasor fun1 = StringToFasor(funcion1);

                Fasor fun2 = StringToFasor(funcion2);

                Fasor Resultado = SumarFasores(fun1, fun2);
                RsltTxt.Text = Resultado.GetAmplitud() + " sen(" + Resultado.GetFrecuencia() + "t + " + Resultado.GetAngulo() + ")";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UCOM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SumarBtn_Click(object sender, EventArgs e)
        {
            CalcularFasor();
        }
    }
}
