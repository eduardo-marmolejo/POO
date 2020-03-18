using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    class ClassEquilátero:ClassFiguras
    {
        public void Equilatero()
        {
            Area = (Math.Sqrt(3) / 4) * (Medida * Medida);
            Perimetro = 3 * Medida;
        }
    }
}
