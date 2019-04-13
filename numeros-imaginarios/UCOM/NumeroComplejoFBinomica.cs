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



    }
}
