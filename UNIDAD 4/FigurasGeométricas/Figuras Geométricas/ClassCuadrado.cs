using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    class ClassCuadrado:ClassFigura
    {
        //Métodos de la clase
        public void Cuadrado()
        {
            Area = Medida * Medida;
            Perimetro = Medida * 4;
        }
    }
}
