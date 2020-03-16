using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class ClassOperación
    {
        //Atributos de la clase
        private float valor1, valor2, resultado;

        public float Valor1
        {
            set
            {
                valor1 = value;
            }

            get
            {
                return valor1;
            }
        }

        public float Valor2
        {
            set
            {
                valor2 = value;
            }

            get
            {
                return valor2;
            }
        }

        public float Resultado
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

        public ClassOperación()
        {
            Valor1 = 0;
            Valor2 = 0;
            Resultado = 0;
        }
    }
    
}
