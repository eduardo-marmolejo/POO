using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_1_Propuesta_2
{
    class ClassCal
    {
        //Atributos de la clase
        private double cal, promedion, numCal, notas;

        public double Cal
        {
            set
            {
                cal = value;
            }
            get
            {
                return cal;
            }
        }

        public double Promedion
        {
            set
            {
                promedion = value;
            }
            get
            {
                return promedion;
            }
        }

        public double NumCal
        {
            set
            {
                numCal = value;
            }
            get
            {
                return numCal;
            }
        }

        public double Notas
        {
            set
            {
                notas = value;
            }
            get
            {
                return notas;
            }
        }

        public ClassCal()
        {
            Promedion = 0;
            NumCal = 0;
        }
    }
}
