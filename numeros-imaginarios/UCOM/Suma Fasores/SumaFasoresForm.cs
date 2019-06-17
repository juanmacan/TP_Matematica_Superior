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

        #region Declaraciones

        public TextBox txtObject;
        public string pi = Math.PI.ToString().Replace(",", ".");
        public static string[] letrasPermitidas = {"s", "e", "n", "c", "o"};
        public static string[] operandosPermitidos = {"+", "-", "*", "/", "(", ")", "t", "ñ"};
        public List<string> listPermitidosL = new List<string>(letrasPermitidas);
        public List<string> listPermitidosO = new List<string>(operandosPermitidos);

        #endregion

        #region Funciones

        private string ObtenerFrecuenciaYAngulo(string strCadena, ref double dblFrecuencia, ref double dblAngulo)
        {
            string strRespuesta = "";
            string[] strAux;
            string strFrecuencia = "";
            string strAngulo = "";

            if (strCadena.Contains("+"))
            {
                strAux = strCadena.Split('+');                
            }
            else
            {
                strAux = strCadena.Split('-');
            }

            if (strAux.Length != 2)
            {
                strRespuesta += "El argumento de la sinusoide ingresado es incorrecto.\n";
            }
            else
            {
                strFrecuencia = strAux[0].Replace("t", "");
                strAngulo = strAux[1];

                try
                {
                    dblFrecuencia = Convert.ToDouble(new DataTable().Compute(strFrecuencia, null));
                }
                catch (Exception)
                {
                    strRespuesta += "La frecuencia es incorrecta, por favor, no se olvide de ingresar la variable 't'.\n";
                }

                try
                {
                    dblAngulo = AngulosHelperClass.Instance().GetAnguloCorregido(Convert.ToDouble(new DataTable().Compute(strAngulo, null)));
                    if (strCadena.Contains("-"))
                    {
                        dblAngulo *= -1;
                    }

                }
                catch (Exception)
                {
                    strRespuesta += "En Ángulo es incorrecto.\n";
                }
            }

            return strRespuesta;
        }

        #endregion

        //Parsear un string y convertirlo a Fasor.Falta terminar
        public Fasor StringToFasor(string strFasor)
        {
            Double Amplitud = 0;
            Double Frecuencia = 0;
            Double Angulo = 0;
            Boolean esCoseno;

            int intIndex;
            string strArgumento;

            string strResp = "";

            strFasor = strFasor.ToLower();
            strFasor = strFasor.Replace(" ", "");
            strFasor = strFasor.Replace("ñ", this.pi);

            if (strFasor.Contains("cos"))
            {
                esCoseno = true;

                if (strFasor.StartsWith("cos"))
                {
                    Amplitud = 1;
                }
                else
                {
                    intIndex = strFasor.IndexOf('c');

                    try
                    {
                        Amplitud = Convert.ToDouble(new DataTable().Compute(strFasor.Substring(0, intIndex), null));
                    }
                    catch (Exception)
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
                        intIndex = strFasor.IndexOf('s');

                        try
                        {
                            Amplitud = Convert.ToDouble(new DataTable().Compute(strFasor.Substring(0, intIndex), null));
                        }
                        catch (Exception)
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

            strArgumento = strFasor.Substring(strFasor.IndexOf('(') + 1);
            strArgumento = strArgumento.Remove(strArgumento.Length - 1, 1);


            strResp = this.ObtenerFrecuenciaYAngulo(strArgumento, ref Frecuencia, ref Angulo);

            if (strResp!="")
            {
                throw new Exception(strResp);
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
                RsltTxt.Text = Resultado.GetAmplitud() + " cos(" + Resultado.GetFrecuencia() + "t + " + Resultado.GetAngulo() + ")";
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

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fun1Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Fun1Txt.Text.ToLower().Contains("sen") || this.Fun1Txt.Text.ToLower().Contains("cos"))
            {
                if (listPermitidosL.Contains(e.KeyChar.ToString().ToLower()))
                {
                    e.Handled = true;
                }
                else
                {
                    if (!listPermitidosO.Contains(e.KeyChar.ToString()))
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                        {
                            e.Handled = true;
                        }
                    }                    
                }
            }
            else
            {
                if (!listPermitidosO.Contains(e.KeyChar.ToString()) && !listPermitidosL.Contains(e.KeyChar.ToString()))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void Fun2Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.Fun2Txt.Text.ToLower().Contains("sen") || this.Fun2Txt.Text.ToLower().Contains("cos"))
            {
                if (listPermitidosL.Contains(e.KeyChar.ToString().ToLower()))
                {
                    e.Handled = true;
                }
                else
                {
                    if (!listPermitidosO.Contains(e.KeyChar.ToString()))
                    {
                        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
            else
            {
                if (!listPermitidosO.Contains(e.KeyChar.ToString()) && !listPermitidosL.Contains(e.KeyChar.ToString()))
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
