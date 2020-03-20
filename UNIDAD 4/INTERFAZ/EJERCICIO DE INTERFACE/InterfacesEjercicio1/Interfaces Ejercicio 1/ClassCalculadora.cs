using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Ejercicio_1
{
    class ClassCalculadora
    {
        //Atributos de la clase
        private double num, num2, resultado;

        public double Num
        {
            set
            {
                num = value;
            }
            get
            {
                return num;
            }
        }

        public double Num2
        {
            set
            {
                num2 = value;
            }
            get
            {
                return num2;
            }
        }

        public double Resultado
        {
            set
            {
                resultado = value;
            }
            get
            {
                return resultado;
            }
        }

        public ClassCalculadora()
        {
            Num = 0;
            Num2 = 0;
            Resultado = 0;
        }
    }
}
