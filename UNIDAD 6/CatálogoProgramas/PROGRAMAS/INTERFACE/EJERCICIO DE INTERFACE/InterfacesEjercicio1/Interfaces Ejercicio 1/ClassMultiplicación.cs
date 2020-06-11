using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Ejercicio_1
{
    class ClassMultiplicación:ClassCalculadora,ICalculadora
    {
        //Métodos de la clase
        public void Calcular()
        {
            Resultado = Num * Num2;
        }

    }
}
