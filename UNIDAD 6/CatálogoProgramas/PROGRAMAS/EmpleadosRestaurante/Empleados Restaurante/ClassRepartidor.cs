using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class ClassRepartidor:ClassEmpleado
    {
        private double propina, zonas, abonos;

        public double Propina
        {
            set
            {
                propina = value;
            }
            get
            {
                return propina;
            }
        }

        public double Zonas
        {
            set
            {
                zonas = value;
            }
            get
            {
                return zonas;
            }
        }

        public double Abonos
        {
            set
            {
                abonos = value;
            }
            get
            {
                return abonos;
            }
        }

        public void calcularSueldo()
        {
            switch (Zona)
            {
                case "1":
                    Sueldo = (Pago * Diastra)+(5*Abonos);
                    break;

                case "2":
                    Sueldo = (Pago * Diastra) + (2 * Abonos);
                    break;
            }
        }
    }
}
