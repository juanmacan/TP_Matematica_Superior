using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOM
{
    class NumeroComplejoFBinomica
    {
        private double Real { get; set; }
        private double Imaginario { get; set; }

        public NumeroComplejoFBinomica(double dbReal, double dbImaginario)
        {
            this.Real = dbReal;
            this.Imaginario = dbImaginario;
        }

        public double Modulo()
        {
            double RealAlCuadrado = this.Real * this.Real;
            double ImaginarioAlCuadrado = this.Imaginario * this.Imaginario;

            return Math.Sqrt(RealAlCuadrado + ImaginarioAlCuadrado);
        }
        public double Angulo()
        {
            return Math.Atan(Imaginario / Real);
        }
        public NumeroComplejoFPolar TransformarAPolar()
        {
            return new NumeroComplejoFPolar(this.Modulo(),this.Angulo());
        }
    }


    class NumeroComplejoFPolar
    {
        private double Modulo { get; set; }
        private double Angulo { get; set; }

        public NumeroComplejoFPolar(double dModulo, double dAngulo)
        {
            Modulo = dModulo;
            Angulo = dAngulo;
        }

        public NumeroComplejoFBinomica TransformarABinomica()
        {
            double real = Modulo * Math.Cos(Angulo);
            double imaginario = Modulo * Math.Sin(Angulo);
            return new NumeroComplejoFBinomica(real,imaginario);
        }

    }

}
