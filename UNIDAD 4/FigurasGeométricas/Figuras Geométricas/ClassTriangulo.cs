using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    class ClassTriangulo:ClassFigura
    {
        public void Trinagulo()
        {
            Area = (Medida * Medida2) / 2;
            Perimetro = Medida2 + Medida3 + Medida3;
        }
    }
}
