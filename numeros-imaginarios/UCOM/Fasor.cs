using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOM.Utils;

namespace UCOM
{
   public class Fasor
    {
        private double Amplitud;
        private double Frecuencia;
        private double Angulo;
        private bool esCosenoidal;

        public Fasor(double _Amplitud, double _Frecuencia,double _Angulo,bool esCosenoidal)
        {
            Amplitud = _Amplitud;
            Frecuencia = _Frecuencia;
            Angulo = _Angulo;
            this.esCosenoidal = esCosenoidal;
        }
        public double GetFrecuencia() => Frecuencia;
        public double GetAmplitud() => Amplitud;
        public bool EsCosenoidal() => esCosenoidal;
        public double GetAngulo() => Angulo;

        public NumeroComplejoFBinomica ConvertirABinomica()
        {
            if (esCosenoidal)
            {
                double real = Amplitud * Math.Cos(AngulosHelperClass.Instance().GetAnguloCorregido(Angulo));
                double img = Amplitud * Math.Sin(AngulosHelperClass.Instance().GetAnguloCorregido(Angulo));
                return new NumeroComplejoFBinomica(real, img);
            }
            else
            {
                double real = Amplitud * Math.Cos(AngulosHelperClass.Instance().GetAnguloCorregido(Angulo) - Math.PI/2);
                double img = Amplitud * Math.Sin(AngulosHelperClass.Instance().GetAnguloCorregido(Angulo) - Math.PI/2);
                return new NumeroComplejoFBinomica(real, img);
            }
        }

    }
}
