using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class ClassPaís
    {
        //Atributos de la clase
        private string nomPais, idioma, color1,color2,color3;
        private double numPoblacion;

        public string País
        {
            set
            {
                nomPais = value;
            }
            get
            {
                return nomPais;
            }
        }

        public double Poblacion
        {
            set
            {
                numPoblacion = value;
            }
            get
            {
                return numPoblacion;
            }
        }

        public string Idioma
        {
            set
            {
                idioma = value;
            }
            get
            {
                return idioma;
            }
        }

        public string Color1
        {
            set
            {
                color1 = value;
            }
            get
            {
                return color1;
            }
        }

        public string Color2
        {
            set
            {
                color2 = value;
            }
            get
            {
                return color2;
            }
        }

        public string Color3
        {
            set
            {
                color3 = value;
            }
            get
            {
                return color3;
            }
        }


        public ClassPaís()
        {
            Poblacion = 0;
        }
    }
}
