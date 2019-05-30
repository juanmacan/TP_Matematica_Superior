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
            angulo = Numero[1].Substring(0, Numero[1].Length - 1).Replace(".",",");
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

        //Parsear un string y convertirlo a Fasor.Falta terminar
        public Fasor StringToFasor(string f)
        {
            var amplitud = f.Substring(0);

            //Fasor fas = new Fasor(Convert.ToDouble(amplitud),_,_);

            return fas;
        }

        //Convertir a binomica para facilitar las cuentas y convertir luego en fasor. Falta Terminar
        public Fasor SumarFasores(Fasor fas1,Fasor fas2)
        {
            if (fas1.GetFrecuencia() == fas2.GetFrecuencia())
            {
                NumeroComplejoFBinomica fun1 = fas1.ConvertirABinomica();
                NumeroComplejoFBinomica fun2 = fas2.ConvertirABinomica();

                NumeroComplejoFBinomica resultado = new NumeroComplejoFBinomica((fun1.Real + fun2.Real), (fun1.Imaginario + fun2.Imaginario)); 
            }
        }
        
    }
}
