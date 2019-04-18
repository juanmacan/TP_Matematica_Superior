using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOM.Utils
{
    class AngulosHelperClass
    {
        private static AngulosHelperClass _instance;

        public static AngulosHelperClass Instance()
        {
            if(_instance == null)
            {
                _instance = new AngulosHelperClass();
            }
            return _instance;
        }

        /// <summary>
        ///Funcion Helper para obtener el cuadrante de un angulo dado 
        /// </summary>
        /// <param name="r_angulo">Angulo en radianes</param>
        /// <returns>Cuadrante en el que se encuentra el angulo</returns>
        public int GetCuadranteDelAngulo(double r_angulo)
        {
            if (r_angulo >= 0 && r_angulo < Math.PI / 2)
            {
                return 1;
            }
            else if (r_angulo >= Math.PI / 2 && r_angulo < Math.PI)
            {
                return 2;
            }
            else if (r_angulo >= -Math.PI && r_angulo < -(Math.PI / 2))
            {
                return 3;
            }
            else if (r_angulo >= -(Math.PI/2) && r_angulo < 0)
            {
                return 4;
            }

            //Nunca deberia llegar aca
            return -1;
        }

        public double GetAnguloCorregido(double rAngulo)
        {
            double angulo = 0;
            switch (GetCuadranteDelAngulo(rAngulo))
            {
                case 1: angulo = rAngulo; break;
                case 2: angulo = rAngulo + Math.PI ; break;
                case 3: angulo = rAngulo + Math.PI; break;
                case 4: angulo = rAngulo + (2*Math.PI) ; break;
                default: angulo = -1;break;
            }
            return angulo;
        }

    }
}
