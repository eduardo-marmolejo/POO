using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class ClassMesero:ClassEmpleado
    {
        //Atributos de la clase
        private double propina;

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

        //Método de la clase
        public void calcularSueldo()
        {
            Sueldo = (Pago * Diastra) + Propina;
        }

    }
}
