using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    class ClassCirculo:ClassFiguras
    {
        public void Circulo()
        {
            Area = 3.1416 * (Medida * Medida);
            Perimetro = (2 * 3.1416) * Medida;
        }
    }
}
