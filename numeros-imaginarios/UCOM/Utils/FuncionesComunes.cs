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

            String pos1;
            String pos2;
            int n1, n2;
            double numAux, pi = Math.PI;
            if (real.Contains("π"))
            {
                //REEMPLAZO PI POR SU NRO 3.1415926536 QUE SE APROXIMA A PI
                pos1 = real.Substring(0, real.IndexOf("π"));
                n1 = real.IndexOf("π")+1;
                n2 = real.Length-n1;
                pos2 = real.Substring(n1, n2);
                if (pos1.Length != 0)
                {
                    numAux = Double.Parse(pos1);
                }
                else
                {
                    numAux = 1;
                }
                numAux = numAux * pi;
                if (pos2.Contains("π"))
                {
                    numAux = numAux * multiplicarSegundaCadena(pos2);
                }
                else if(pos2!="")
                {
                    numAux = numAux * Double.Parse(pos2);
                }
                real = numAux.ToString();
            }
            if (imaginario.Contains("π"))
            {
                //REEMPLAZO PI POR SU NRO 3.1415926536 QUE SE APROXIMA A PI
                pos1 = imaginario.Substring(0, imaginario.IndexOf("π"));
                n1 = imaginario.IndexOf("π") + 1;
                n2 = imaginario.Length - n1;
                pos2 = imaginario.Substring(n1, n2);
                if (pos1.Length != 0)
                {
                    numAux = Double.Parse(pos1);
                }
                else
                {
                    numAux = 1;
                }
                numAux = numAux * pi;
                if (pos2.Contains("π"))
                {
                    numAux = numAux * multiplicarSegundaCadena(pos2);
                }
                else if (pos2 != "")
                {
                    numAux = numAux * Double.Parse(pos2);
                }
                imaginario = numAux.ToString();
            }
            return new NumeroComplejoFBinomica(Double.Parse(real), Double.Parse(imaginario));
        }

        private double multiplicarSegundaCadena(String cadena) {
            double res = 0;
            String pos1;
            String pos2;
            int n1, n2;
            double numAux = 0, pi = Math.PI;
            if (cadena.Contains("π"))
            {
                //REEMPLAZO PI POR SU NRO 3.1415926536 QUE SE APROXIMA A PI
                pos1 = cadena.Substring(0, cadena.IndexOf("π"));
                n1 = cadena.IndexOf("π") + 1;
                n2 = cadena.Length - n1;
                pos2 = cadena.Substring(n1, n2);
                if (pos1.Length != 0)
                {
                    numAux = Double.Parse(pos1);
                }
                else
                {
                    numAux = 1;
                }
                numAux = numAux * pi;
                if (pos2.Contains("π")){
                    numAux = numAux * multiplicarSegundaCadena(pos2);
                } else if(pos2 != "")
                {
                    numAux = numAux * Double.Parse(pos2);
                }
            }
            res = numAux;
            return res;
        }

        public NumeroComplejoFPolar pasarDeTextoAFormaPolar(String texto)
        {
            String modulo;
            String angulo;
            string[] Numero = texto.Split(';');
            modulo = Numero[0].Substring(1);
            angulo = Numero[1].Substring(0, Numero[1].Length - 1).Replace(".", ",");
            String pos1;
            String pos2;
            double numAux, pi = Math.PI;
            int n1, n2;
            if (modulo.Contains("π"))
            {
                //REEMPLAZO PI POR SU NRO 3.1415926536 QUE SE APROXIMA A PI
                pos1 = modulo.Substring(0, modulo.IndexOf("π"));
                n1 = modulo.IndexOf("π") + 1;
                n2 = modulo.Length - n1;
                pos2 = modulo.Substring(n1, n2);
                if (pos1.Length != 0)
                {
                    numAux = Double.Parse(pos1);
                }
                else
                {
                    numAux = 1;
                }
                numAux = numAux * pi;
                if (pos2.Contains("π"))
                {
                    numAux = numAux * multiplicarSegundaCadena(pos2);
                }
                else if (pos2 != "")
                {
                    numAux = numAux * Double.Parse(pos2);
                }
                modulo = numAux.ToString();
            }
            if (angulo.Contains("π"))
            {
                //REEMPLAZO PI POR SU NRO 3.1415926536 QUE SE APROXIMA A PI
                pos1 = angulo.Substring(0, angulo.IndexOf("π"));
                n1 = angulo.IndexOf("π") + 1;
                n2 = angulo.Length - n1;
                pos2 = angulo.Substring(n1, n2);
                if (pos1.Length != 0)
                {
                    numAux = Double.Parse(pos1);
                }
                else
                {
                    numAux = 1;
                }
                numAux = numAux * pi;
                if (pos2.Contains("π"))
                {
                    numAux = numAux * multiplicarSegundaCadena(pos2);
                }
                else if (pos2 != "")
                {
                    numAux = numAux * Double.Parse(pos2);
                }
                angulo = numAux.ToString();
            }
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
                    if (isNumeric(Numero[0].Substring(1)) || Numero[0].Substring(1).Contains("π") ||
                        isNumeric(Numero[1].Substring(1)) || Numero[1].Substring(1).Contains("π"))
                    {
                        if (isNumeric(Numero[1].Substring(0, Numero[1].Length - 1)) || Numero[0].Substring(1).Contains("π") ||
                            isNumeric(Numero[1].Substring(0, Numero[1].Length - 1)) || Numero[1].Substring(1).Contains("π"))
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
                    if (isNumeric(Numero[0].Substring(1)) || Numero[0].Substring(1).Contains("π") || 
                        isNumeric(Numero[1].Substring(1)) || Numero[1].Substring(1).Contains("π"))
                    {
                        if (isNumeric(Numero[1].Substring(0, Numero[1].Length - 1)) || Numero[0].Substring(1).Contains("π")  ||
                            isNumeric(Numero[1].Substring(0, Numero[1].Length - 1)) || Numero[1].Substring(1).Contains("π"))
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
