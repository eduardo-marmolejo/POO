using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras_Geométricas_2
{
    class ClassFiguras
    {
        private double area, perimetro, medida, medida2, medida3, s;
        private string figuras, tipos;


        public string Figuras
        {
            set
            {
                figuras = value;
            }
            get
            {
                return figuras;
            }
        }

        public string Tipos
        {
            set
            {
                figuras = value;
            }
            get
            {
                return figuras;
            }
        }

        public double S
        {
            set
            {
                s = value;
            }
            get
            {
                return s;
            }
        }

        public double Medida
        {
            set
            {
                medida = value;
            }
            get
            {
                return medida;
            }
        }

        public double Medida2
        {
            set
            {
                medida2 = value;
            }
            get
            {
                return medida2;
            }
        }

        public double Medida3
        {
            set
            {
                medida3 = value;
            }
            get
            {
                return medida3;
            }
        }

        public double Area
        {
            set
            {
                area = value;
            }
            get
            {
                return area;
            }
        }

        public double Perimetro
        {
            set
            {
                perimetro = value;
            }
            get
            {
                return perimetro;
            }
        }

        public ClassFiguras()
        {
            Medida = 0;
            Medida2 = 0;
            Medida3 = 0;
            S = 0;
            Area = 0;
            Perimetro = 0;
        }
    }
}
