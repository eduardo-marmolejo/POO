using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas
{
    class ClassTriangulo:ClassFiguras
    {
        public void Tipo()
        {
            switch (Tipos)
            {
                case "Equilátero":
                    Area = (Math.Sqrt(3) / 4)*(Medida*Medida);
                    Perimetro = 3 * Medida;
                    break;

                case "Isósceles":
                    Area = (2*(Math.Sqrt((Medida*Medida)-((Medida2*Medida2)/4))))/2;
                    Perimetro = (2 * Medida) + Medida2;
                    break;

                case "Escaleno":
                    S = (Medida + Medida2 + Medida3) / 2;
                    Area = Math.Sqrt(S*(S-Medida)*(S-Medida2)*(S-Medida3));
                    Perimetro = Medida + Medida2 + Medida3;
                    break;
            }
        }
    }
}
