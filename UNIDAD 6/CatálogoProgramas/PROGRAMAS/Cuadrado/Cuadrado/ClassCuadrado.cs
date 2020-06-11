using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class ClassCuadrado
    {
        //Atributos de la clase
        public int area, peri,medida;
        
        //Métodos de la clase
        public void ProcesoCuadrado()
        {
            area = medida * medida;
            peri = medida * 4;
        }
    }
}
