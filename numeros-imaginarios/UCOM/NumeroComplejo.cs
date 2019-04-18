using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOM.Utils;

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

        public Double getReal()
        {
            return this.Real;
        }

        public Double getImaginario()
        {
            return this.Imaginario;
        }

        public NumeroComplejoFBinomica conjugado() {
            return new NumeroComplejoFBinomica(this.Real, this.Imaginario * -1);
        }

        public double Modulo()
        {
            double RealAlCuadrado = this.Real * this.Real;
            double ImaginarioAlCuadrado = this.Imaginario * this.Imaginario;

            return Math.Sqrt(RealAlCuadrado + ImaginarioAlCuadrado);
        }
        public double Angulo()
        {
            double angulo = Math.Atan2(Imaginario, Real);
            return AngulosHelperClass.Instance().GetAnguloCorregido(angulo);
        }

        public NumeroComplejoFPolar TransformarAPolar()
        {
            return new NumeroComplejoFPolar(this.Modulo(),this.Angulo());
        }

        public NumeroComplejoFBinomica pasaDeATextoAFormaBinomica(String texto)
        {
            String real = "";
            String imaginario = "";
            int i = texto.IndexOf(";");
            real = texto.Substring(1, i);
            imaginario = texto.Substring(i, texto.LastIndexOf(")"));
            return new NumeroComplejoFBinomica(Double.Parse(real), Double.Parse(imaginario));
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

        public double getReal() {
            return this.Modulo * Math.Cos(Angulo);
        }

        public double getImaginario() {
            return this.Modulo * Math.Sin(Angulo);
        }

        public double getModulo() {
            return this.Modulo;
        }

        public double getAndulo() {
            return this.Angulo;
        }

        public NumeroComplejoFBinomica TransformarABinomica()
        {
            double real = Modulo * Math.Cos(Angulo);
            double imaginario = Modulo * Math.Sin(Angulo);
            return new NumeroComplejoFBinomica(real,imaginario);
        }

        public NumeroComplejoFPolar pasarDeTextoAFormaPolar(String texto)
        {
            String modulo;
            String angulo;
            int i = texto.IndexOf(";");
            modulo = texto.Substring(1, i);
            angulo = texto.Substring(i, texto.LastIndexOf("]"));
            return new NumeroComplejoFPolar(Double.Parse(modulo), Double.Parse(angulo));
        }
    }

}
