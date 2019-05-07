using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOM.Utils
{
    public class FuncionesComunes
    {
        public NumeroComplejoFBinomica pasaDeATextoAFormaBinomica(String texto)
        {
            String real = "";
            String imaginario = "";
            string[] Numero = texto.Split(',');
            real = Numero[0].Substring(1);
            imaginario = Numero[1].Substring(0, Numero[1].Length - 1);
            return new NumeroComplejoFBinomica(Double.Parse(real), Double.Parse(imaginario));
        }

        public NumeroComplejoFPolar pasarDeTextoAFormaPolar(String texto)
        {
            String modulo;
            String angulo;
            string[] Numero = texto.Split(';');
            modulo = Numero[0].Substring(1);
            angulo = Numero[1].Substring(0, Numero[1].Length - 1);
            return new NumeroComplejoFPolar(Double.Parse(modulo), Double.Parse(angulo));
        }

        public Boolean isNumeric(string strnumero)
        {
            Double n = 0;
            return Double.TryParse(strnumero, out n);
        }

        public Boolean ValidarNumeroComplejor(string parametro)
        {
            string[] Numero = parametro.Split(',');
            if (Numero.Length == 2)
            {
                if (Numero[0].Substring(0, 1) == "(")
                {
                    if (isNumeric(Numero[0].Substring(1)))
                    {
                        if (isNumeric(Numero[1].Substring(0, Numero[1].Length - 1)))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            Numero = parametro.Split(';');

            if (Numero.Length == 2)
            {
                if (Numero[0].Substring(0, 1) == "[")
                {
                    if (isNumeric(Numero[0].Substring(1)))
                    {
                        if (isNumeric(Numero[1].Substring(0, Numero[1].Length - 1)))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public Boolean EsNumeroComplejoBinomica(string complejo)
        {
            return complejo.Substring(0, 1).Equals("(");
        }
    }
}
