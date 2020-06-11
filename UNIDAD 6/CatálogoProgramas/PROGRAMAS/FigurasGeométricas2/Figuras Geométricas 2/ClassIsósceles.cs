using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_2
{
    class ClassIsósceles:ClassFiguras
    {
        public void Isosceles()
        {
            Area = (2 * (Math.Sqrt((Medida * Medida) - ((Medida2 * Medida2) / 4)))) / 2;
            Perimetro = (2 * Medida) + Medida2;
        }
    }
}
