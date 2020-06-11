using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_2
{
    class ClassEscaleno:ClassFiguras
    {
        public void Escaleno()
        {
            S = (Medida + Medida2 + Medida3) / 2;
            Area = Math.Sqrt(S * (S - Medida) * (S - Medida2) * (S - Medida3));
            Perimetro = Medida + Medida2 + Medida3;
        }
    }
}
